using System.Threading;
using System.Threading.Tasks;
using MediatR;
using mp.Mediatr.Command;
using mp.Models;
using mp.Repository;

namespace mp.Mediatr.Handler
{
    public class NewEmployeeHandler : IRequestHandler<NewEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository employeeRepository;

        public NewEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(NewEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.Create(request.Employee);
        }
    }
}