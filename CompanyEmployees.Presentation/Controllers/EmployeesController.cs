using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CompanyEmployees.Presentation.Controllers;

[Route("api/companies/{companyId}/employees")]
[ApiController]
public class EmployeesController: ControllerBase
{
    private readonly IServiceManager _service;

    public EmployeesController(IServiceManager service) => _service = service;

    public IActionResult GetEmployeesForCompany(Guid id)
    {
        var employees = _service.EmployeeService.GetEmployees(id, false);
        return Ok(employees);
    }
}