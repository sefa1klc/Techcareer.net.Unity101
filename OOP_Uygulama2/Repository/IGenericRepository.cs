namespace OOP_Uygulama2.Repository;

public interface IGenericRepository<TModel>
{
    void Add(TModel category);
    List<TModel> GetAll();

    TModel GetById(int id);
    void Delete(int id);
}