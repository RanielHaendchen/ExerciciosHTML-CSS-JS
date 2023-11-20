using AcessandoBancoDados.dao;
using AcessandoBancoDados.entidades;

namespace AcessandoBancoDados
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contato ct = new Contato(1, "José","José@gmail.com", "(47)1234-5678");
            DaoContato daoContato = new DaoContato();
            if (daoContato.salvar(ct))
            {
                Console.WriteLine("Contato sucesso com sucesso!");
            }

           Local cl = new Local(1, "Shopping", "Rua 7 De Setembro", "340", "Blumenau", "SC");
            DaoLocais daoLocais = new DaoLocais();
            if (daoLocais.salvar(cl))
            {
                Console.WriteLine("Local salvo com sucesso!");
            }
            daoContato.consultar();
            Console.ReadKey();
        }
    }
}