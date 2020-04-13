using MediatR;
using mp.Models;

namespace mp.Mediatr.Query
{
    public class GetSingleEmployeeQuery : IRequest<Employee>
    {
        public int Id { get; set; }
        public GetSingleEmployeeQuery(int id)
        {
            this.Id = id;
        }
    }
}