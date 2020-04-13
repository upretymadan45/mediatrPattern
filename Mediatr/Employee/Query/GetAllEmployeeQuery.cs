using System.Collections.Generic;
using MediatR;
using mp.Models;

namespace mp.Mediatr.Query
{
    public class GetAllEmployeeQuery : IRequest<List<Employee>>
    {

    }
}