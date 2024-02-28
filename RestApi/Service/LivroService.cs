using Microsoft.EntityFrameworkCore;
using RestApi.Data;
using RestApi.Entities;

public class LivroService : ILivroService
{
    private LivrosContext _context;
    public LivroService(LivrosContext context)
    {
        _context = context;
    }

    public void Add(Livro livro)
    {
        _context.Livros.Add(livro);
    }

    public Livro Find(int id)
    {
        return _context.Livros.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
    }

    public void Delete(Livro livro)
    {
        _context.Remove(livro);
    }

    public void Update(Livro livro)
    {
        _context.Update(livro);
    }

    public IEnumerable<Livro> GetAll()
    {
        return _context.Livros.AsNoTracking().ToList();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}