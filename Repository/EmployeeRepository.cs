using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mp.Data;
using mp.Models;

namespace mp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Employee> Create(Employee employee)
        {
            context.Employees.Add(employee);
            await context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> Edit(Employee employee)
        {
            context.Employees.Update(employee);
            await context.SaveChangesAsync();
            return employee;
        }

        public List<Employee> FindAll()
        {
            return context.Employees.ToList();
        }

        public Employee FindById(int id)
        {
            return context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Employee> Remove(Employee employee)
        {
            context.Employees.Remove(employee);
            await context.SaveChangesAsync();
            return employee;
        }
    }
}