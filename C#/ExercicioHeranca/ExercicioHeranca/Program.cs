namespace ExercicioHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotoPasseio passeio = new MotoPasseio("Honda", "CG 150", 2014, "150CC", "Sim", "Sim");
            Console.WriteLine(passeio.listar());

            MotoCompeticao competicao = new MotoCompeticao("Kawasaki", "Ninja", 2023, "1000CC", "Superbike");
            Console.WriteLine(competicao.listar());

        }
    }
}