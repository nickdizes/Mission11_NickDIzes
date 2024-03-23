namespace Mission11_NickDizes.Models;

public interface IBookRepository
{
    public IQueryable<Book> Books { get; }
}