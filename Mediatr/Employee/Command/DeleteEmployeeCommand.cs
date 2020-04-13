using MediatR;
using mp.Models;

namespace mp.Mediatr.Command
{
    public class DeleteEmployeeCommand : IRequest<Employee>
    {
        public DeleteEmployeeCommand(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; }
    }
}