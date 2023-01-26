using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class produs
    {

        public int _pret { get; set; }
        public string _denumire { get; set; }

        public produs(int pret, string denumire)
        {
            _pret = pret;
            _denumire = denumire;
        }
    }
}
