namespace gestione_vacanze.Repos
{
    public interface IRepo <T>
    {
        List<T> GetAll();
        T? Get(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
