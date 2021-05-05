using CQRS_Exemplo.Domain.Commands.Request;
using CQRS_Exemplo.Domain.Commands.Response;
using CQRS_Exemplo.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Exemplo.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command)
        {
            return handler.Handle(command);
        }
    }
}
