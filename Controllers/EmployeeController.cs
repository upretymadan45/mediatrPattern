using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using mp.Mediatr.Command;
using mp.Mediatr.Query;
using mp.Models;

namespace mp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await mediator.Send(new GetAllEmployeeQuery());
            return View(employees);
        }

        public IActionResult New()
        {

            return View(new Employee());
        }

        [HttpPost]
        public async Task<IActionResult> New(Employee model)
        {
            await mediator.Send(new NewEmployeeCommand(model));

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await mediator.Send(new GetSingleEmployeeQuery(id));

            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Employee model)
        {
            await mediator.Send(new UpdateEmployeeCommand(model));

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await mediator.Send(new GetSingleEmployeeQuery(id));

            await mediator.Send(new DeleteEmployeeCommand(employee));

            return RedirectToAction(nameof(Index));
        }
    }
}