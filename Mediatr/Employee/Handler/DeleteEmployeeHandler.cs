using System.Threading;
using System.Threading.Tasks;
using MediatR;
using mp.Mediatr.Command;
using mp.Models;
using mp.Repository;

namespace mp.Mediatr.Handler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository employeeRepository;

        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.Remove(request.Employee);
        }
    }
}