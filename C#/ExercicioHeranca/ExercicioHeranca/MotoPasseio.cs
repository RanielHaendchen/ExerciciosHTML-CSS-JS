using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    internal class MotoPasseio : Moto
    {
        public string bau { get; set; }
        public string mataCachorro { get; set; }

        public MotoPasseio(string marca, string modelo, int ano, string cilindradas, string bau, string mataCachorro)
            : base(marca, modelo, ano, cilindradas)
        {
            this.bau = bau;
            this.mataCachorro = mataCachorro;
        }

        public string listar()
        {
            string msgDoPai = base.listar();
            return $"{msgDoPai}\nBau: {bau}\nMata Cachorro: {mataCachorro}";
        }
    }
}
