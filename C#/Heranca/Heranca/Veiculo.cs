using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public void ronco()
        {
            Console.WriteLine("Ronco do veiculo");
        }
    }
}