using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro : Veiculo
    {
        public string Modelo { get; set; }

        public void ronco()
        {
            Console.WriteLine("Ronco do carro");
        }
    }
}