using System.Threading.Tasks;
using CQRS_Exemplo.Domain.Commands.Request;
using CQRS_Exemplo.Domain.Commands.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Exemplo.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}
