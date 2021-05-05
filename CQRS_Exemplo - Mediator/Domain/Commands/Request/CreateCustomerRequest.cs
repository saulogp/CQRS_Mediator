using CQRS_Exemplo.Domain.Commands.Response;
using MediatR;

namespace CQRS_Exemplo.Domain.Commands.Request
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
