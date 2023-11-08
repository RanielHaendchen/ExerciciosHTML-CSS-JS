namespace Exercicios_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercicioPessoas();
        }
        static void exercicioPessoas()
        {

            SortedList<string, Pessoa> pessoas = new SortedList<string, Pessoa>();

            Pessoa p1 = new Pessoa() {Sobrenome = "Haendchen", Idade = 19, Peso = 65 };
            pessoas.Add("Raniel", p1);

            Pessoa p2 = new Pessoa() {Sobrenome = "Silva", Idade = 26, Peso = 80 };
            pessoas.Add("Jorge", p2);

            foreach (var item in pessoas)
            {
                Console.WriteLine($"Key: {item.Key}, Sobrenome: {item.Value.Sobrenome}, Idade: {item.Value.Idade}, Peso: {item.Value.Peso}");
            }
        }
        static void listaProdutos()
        {
            List<Produtos> listaProdutos = new List<Produtos>();

            Produtos produto1 = new Produtos() { Categoria = "Grão", Estoque = 10, Produto = "Feijão" };
            listaProdutos.Add(produto1);

            Produtos produto2 = new Produtos() { Categoria = "Cereal", Estoque = 20, Produto = "Arroz" };
            listaProdutos.Add(produto2);

            

            
        }
    }
}