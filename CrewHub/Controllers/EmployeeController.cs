using CrewHub.Data.DBContext;
using Microsoft.AspNetCore.Mvc;
using SharedServices.BusinessLayers;
using SharedServices.BusinessLayers.ILayers;

namespace CrewHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Context _context;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(Context context, IEmployeeService employeeService)
        {
            _context = context;
            _employeeService = employeeService;
        }

        [HttpGet("Employee")]
        public void GetEmployeeDetails()
        {
        }


    }
}
