using System.Threading;
using System.Threading.Tasks;
using MediatR;
using mp.Mediatr.Command;
using mp.Models;
using mp.Repository;

namespace mp.Mediatr.Handler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository employeeRepository;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.Edit(request.Employee);
        }
    }
}