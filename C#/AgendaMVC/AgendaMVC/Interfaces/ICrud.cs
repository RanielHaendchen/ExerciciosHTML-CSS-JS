namespace AgendaMVC.Interfaces
{
    public interface ICrud<T>
    {
        bool salvar(T t);
        bool alterar(T t);
        void excluir(int id);
        T Consultar(int id);
        List<T> Consultar(); 
    }
}
