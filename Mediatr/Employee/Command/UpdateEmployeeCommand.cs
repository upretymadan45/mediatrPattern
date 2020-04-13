using MediatR;
using mp.Models;

namespace mp.Mediatr.Command{
    public class UpdateEmployeeCommand : IRequest<Employee>{
        public UpdateEmployeeCommand(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; }
    }
}