using MediatR;

namespace Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByPersonDocument
{
    public class GetCarByPersonDocumentQuery: IRequest<IEnumerable<GetCarByPersonDocumentQueryResponse>>
    {
        public string Document { get; set; }

        public GetCarByPersonDocumentQuery(string document)
        {
            Document = document;    
        }
    }
}