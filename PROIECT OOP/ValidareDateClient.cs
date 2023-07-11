using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_OOP
{
    internal class ValidareDateClient
    {
        private readonly string numeFamilie;
        private readonly string prenume;
        private readonly string adresa;
        private readonly int varsta;

        public ValidareDateClient(string numeFamilie, string prenume, string adresa, int varsta)
        {
            this.numeFamilie = numeFamilie;
            this.prenume = prenume;
            this.adresa = adresa;
            this.varsta = varsta;
        }

        public int VerificareEligibitateContBancar()
        {

            if (varsta <= 17 )
            {
                Console.WriteLine("Contul bancar se poate deschide doar cu insotitor !");
                Console.WriteLine("Contul nu se poate deschide deoarece nu intruneste conditiile de eligibilitate ! Clientul trebuie sa aiba varsta minima de 16 ani ! ");
            }
            else if (varsta >= 18)
            {
                Console.WriteLine("Felicitari,  contul a fost realizat cu succes ! ");
            }

            return varsta;
        }
        public void TipareteDateValidareCont()
        {
            int varstaValidareDate = 18;

            if (VerificareEligibitateContBancar() >= varstaValidareDate)
            {
                Console.WriteLine($"Contul bancar este pe numele {numeFamilie} {prenume}, cu varsta {varsta} ani , la adresa de locuinta cu strada {adresa} ");
            }
            else
            {
                Console.WriteLine("Contul dvs nu poate fi inregistrat ! ");
            }

        }


    }
}

