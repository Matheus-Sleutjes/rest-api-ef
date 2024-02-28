using RestApi.Entities;

public interface ILivroService
{
    void Add(Livro livro);
    Livro Find(int id);
    void Delete(Livro livro);
    void Update(Livro livro);
    IEnumerable<Livro> GetAll();
    void SaveChanges();
}