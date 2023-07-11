using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_OOP
{
    internal class ContBancar
    {
        private readonly string adresaBanca = "Strada Libertatii nr 11 ";
        private readonly string numeBanca = "ING BANK";

        public ContBancar(string adresaBanca, string numeBanca)
        {
            this.adresaBanca = adresaBanca;
            this.numeBanca = numeBanca;
        }

        public string TiparesteDateInforbatiiBanca()
        {

            string InformatiiBancaCont = $"Contul dvs este deschis la banca {numeBanca}, la adresa {adresaBanca}";

            return InformatiiBancaCont;
        }
    }
}

