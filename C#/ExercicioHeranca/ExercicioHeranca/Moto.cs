using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    internal class Moto : Veiculo
    {
        public string cilindradas { get; set; }

        public Moto(string marca, string modelo, int ano, string cilindradas)
            : base(marca, modelo, ano)
        {
            this.cilindradas = cilindradas;
        }

        public string listar()
        {
            string msgDoPai = base.listar();
            return $"{msgDoPai}\nCilindradas: {cilindradas}";
        }
    }
}