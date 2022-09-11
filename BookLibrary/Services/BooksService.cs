using ServiceReference1;

namespace BookLibrary.Services;

public class BooksService : BookService
{
    public Task<AddBookResponse> AddBookAsync(AddBookRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<GetAllBooksResponse> GetAllBooksAsync(GetAllBooksRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<GetBookResponse> GetBookAsync(GetBookRequest request)
    {
        throw new NotImplementedException();
    }
}
