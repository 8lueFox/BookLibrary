using BookLibrary.Queries;
using MediatR;
using ServiceReference1;

namespace BookLibrary.Services;

public class BooksService : BookService
{
    private readonly IMediator _mediator;
    public BooksService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<AddBookResponse> AddBookAsync(AddBookRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<GetAllBooksResponse> GetAllBooksAsync(GetAllBooksRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<GetBookResponse> GetBookAsync(GetBookRequest request)
    {
        var query = new GetBookQuery(request);

        var result = await _mediator.Send(query);

        return result;
    }
}
