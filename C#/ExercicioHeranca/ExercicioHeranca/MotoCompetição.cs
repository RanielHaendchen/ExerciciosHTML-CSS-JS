using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    internal class MotoCompeticao : Moto
    {
        public string categoria { get; set; }

        public MotoCompeticao(string marca, string modelo, int ano, string cilindradas, string categoria)
            : base(marca, modelo, ano, cilindradas)
        {
            this.categoria = categoria;
        }

        public string listar()
        {
            string msgDoPai = base.listar();
            return $"{msgDoPai}\nCategoria: {categoria}";
        }
    }
}
