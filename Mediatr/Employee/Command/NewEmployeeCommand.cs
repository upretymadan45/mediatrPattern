using MediatR;
using mp.Models;

namespace mp.Mediatr.Command
{
    public class NewEmployeeCommand : IRequest<Employee>
    {
        public NewEmployeeCommand(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; }
    }
}