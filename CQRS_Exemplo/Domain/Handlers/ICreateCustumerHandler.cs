using CQRS_Exemplo.Domain.Commands.Request;
using CQRS_Exemplo.Domain.Commands.Response;

namespace CQRS_Exemplo.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
