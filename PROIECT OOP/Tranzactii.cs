using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_OOP
{
    namespace Aplicatie_Cont_Bancar
    {
        internal class Tranzactii
        {
            private int soldCurent = 600;
           

            public Tranzactii(int soldCurent)
            {
                this.soldCurent = soldCurent;
               
            }
            public int DepunereBaniInContCurent(int baniDepusi)
            {
                int depuneSoldInContCurent = this.soldCurent + baniDepusi;
                return depuneSoldInContCurent;
            }

            public int RetragereBaniContCurent(int soldCurent, int baniRetrasi, int baniDepusi)
            {
                if ( soldCurent < baniRetrasi)
                {
                    Console.WriteLine("Fonduri insuficiente!");
                }
                else if (baniRetrasi > soldCurent)
                {
                    Console.WriteLine($"Nu aveți fonduri suficiente! Ați încercat să retrageți o sumă mai mare decât soldul inițial pe care îl dețineți în contul dvs. Bani cont curent: {soldCurent}");
                }
                else if (baniRetrasi < 50)
                {
                    Console.WriteLine("Puteți retrage doar bancnote multiple de 50. Puteți scoate minim 50 ron! Încercați din nou!");
                }
                else
                {
                    Console.WriteLine($"Felicitări, ați retras cu succes suma de {baniRetrasi} și ați mai rămas cu un sold curent de {soldCurent} roni");
                }

 
                int retrageBaniContCurent = DepunereBaniInContCurent(baniDepusi) - baniRetrasi;
                return retrageBaniContCurent;


                
            }



        }

    }


}