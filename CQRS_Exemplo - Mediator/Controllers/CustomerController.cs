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
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromBody] CreateCustomerRequest command)
        {
            return _mediator.Send(command);
        }
    }
}
