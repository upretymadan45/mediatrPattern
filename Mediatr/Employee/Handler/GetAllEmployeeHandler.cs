using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using mp.Mediatr.Query;
using mp.Models;
using mp.Repository;

namespace mp.Mediatr.Handler{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<Employee>>{
        private readonly IEmployeeRepository employeeRepository;

        public GetAllEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Task<List<Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return Task.Run(()=>{
                return employeeRepository.FindAll();
            });
        }
    }
}