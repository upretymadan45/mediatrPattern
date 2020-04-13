using System.Collections.Generic;
using System.Threading.Tasks;
using mp.Models;

namespace mp.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> Create(Employee employee);
        Task<Employee> Edit(Employee employee);
        Task<Employee> Remove(Employee employee);
        Employee FindById(int id);
        List<Employee> FindAll();
    }
}