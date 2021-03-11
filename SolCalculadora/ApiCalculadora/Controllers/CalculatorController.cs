namespace ApiCalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int num_a, [FromHeader] int num_b)
        {
            return num_a + num_b;
        }
        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int num_a, [FromHeader] int num_b)
        {
            return num_a * num_b;
        }
        [HttpPost]
        [Route("Subtract")]
        public int Subtract([FromHeader] int num_a, [FromHeader] int num_b)
        {
            return num_a - num_b;
        }
        [HttpPost]
        [Route("Divide")]
        public int Divide([FromHeader] int num_a, [FromHeader] int num_b)
        {
            return num_a / num_b;
        }
    }
}
