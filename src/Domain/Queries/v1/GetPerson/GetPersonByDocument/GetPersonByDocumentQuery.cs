using MediatR;

namespace Domain.Queries.v1.GetPerson.GetPersonByDocument
{
    public class GetPersonByDocumentQuery : IRequest<GetPersonByDocumentQueryResponse>
    {
        public string? Document { get; set; }

        public GetPersonByDocumentQuery(string? document)
        {
            Document = document;
        }
    }
}