using System.Threading;
using System.Threading.Tasks;
using MediatR;
using mp.Mediatr.Query;
using mp.Models;
using mp.Repository;

namespace mp.Mediatr.Handler
{
    public class GetSingleEmployeeHandler : IRequestHandler<GetSingleEmployeeQuery, Employee>
    {
        private readonly IEmployeeRepository employeeRepository;

        public GetSingleEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Task<Employee> Handle(GetSingleEmployeeQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                return employeeRepository.FindById(request.Id);
            });
        }
    }
}