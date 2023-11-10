using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    internal class Retangulo
    {

        public double altura;
        public double largura;
       
        public double calcularArea()
        {
            return altura * largura;
        }

        public double calcularPerimetro()
        {
            return (altura * 2) + (largura * 2);
        }
        
    }
}
