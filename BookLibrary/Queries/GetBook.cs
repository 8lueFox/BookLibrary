using MediatR;
using ServiceReference1;

namespace BookLibrary.Queries;

public record GetBookQuery(GetBookRequest Request) : IRequest<GetBookResponse>;

public class GetBookQueryHandler : IRequestHandler<GetBookQuery, GetBookResponse>
{
    public Task<GetBookResponse> Handle(GetBookQuery request, CancellationToken cancellationToken)
    {
        return Task<GetBookResponse>.Factory.StartNew(() =>
        {
            return new GetBookResponse
            {
                Book = new Book
                {
                    ID = request.Request.ID,
                    Author = "K Jędrzejewski",
                    Title = "Scary history in Library"
                }
            };
        });
    }
}
