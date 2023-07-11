
using PROIECT_OOP;
using PROIECT_OOP.Aplicatie_Cont_Bancar;

Console.WriteLine("Va rugam sa va introduceti datele necesare pentru a realiza un cont Bancar ING Bank");

Console.WriteLine("Va rugam sa va treceti numele si prenumele dvs !");

Console.Write("Nume familie : ");
string numeFamile = Console.ReadLine();

Console.Write("Acum prenumele dvs : ");
string prenume = Console.ReadLine();

Console.Write($"Varsta dvs este :  ");
int varsta = int.Parse(Console.ReadLine());

Console.Write("Adresa de domisciuliu este : ");
string adresa = Console.ReadLine();

ValidareDateClient validare = new ValidareDateClient(numeFamile, prenume, adresa, varsta);

validare.VerificareEligibitateContBancar();

Console.WriteLine(" ");

Console.WriteLine("Date client cont bancar :");

Console.WriteLine(" ");
validare.TipareteDateValidareCont();


Console.WriteLine("Datele contului bancar !");
Console.WriteLine(" ");

string adresaBanca = "Strada Libertatii nr 11 ";
string numeBanca = "ING BANK";

ContBancar contBancar = new ContBancar(adresaBanca, numeBanca);

if (validare.VerificareEligibitateContBancar() >= 18)
{
    Console.WriteLine($"Buna {numeFamile} {prenume}, {contBancar.TiparesteDateInforbatiiBanca()}");
}
else
{
    Console.WriteLine("Nu exista detalii despre acest cont deoarece nu este creat sau nu respecta conditiile eligibilitatii !");
}

Console.Write(" ");
Console.Write(" ");

Console.WriteLine($" Buna ziua {numeFamile} {prenume} ! Aici estw meniul dvs de activitati !  ");
Console.WriteLine(" ");
Console.WriteLine(" ");

int soldCurent = 600;

Tranzactii tranzactii = new Tranzactii(soldCurent);

try
{
    string meniuContAplicatieBancar = "Alegeti Optiunea dorita de dvs ! \n" +

                                      "1. Afiseaza soldul dvs curent ! \n" +
                                      "2. Efectuiaza o retragere din contul curet ! \n" +
                                      "3. Efectuati o depunere in contul curent ! \n" +
                                      "Optiune = \n";

    Console.WriteLine(" ");
    Console.WriteLine(" ");


    while (true)
    {
        Console.Write(meniuContAplicatieBancar);

        string alegeObtiune = Console.ReadLine();

        //int soldCurent = 600;



        switch (alegeObtiune)

        {

            case "1":

                Console.WriteLine($" Numele este = {numeFamile} prenume este ={prenume} Soldul curent este =  {soldCurent}");

                break;

            case "2":
                Console.Write("Retragere suma de : ");

                int baniRetrasi = int.Parse(Console.ReadLine());

                Console.WriteLine(" Bani depusi ");

                int baniDepusi = int.Parse(Console.ReadLine());

                tranzactii.RetragereBaniContCurent(soldCurent, baniRetrasi, baniDepusi);


                Console.Write($"Salut !  {numeFamile} {prenume}");

                break;

            case "3":
                Console.Write("Depui suma de : ");
                int depuneBaniContCurent = int.Parse(Console.ReadLine());

                tranzactii.DepunereBaniInContCurent(soldCurent);


                break;
        }
    }
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}