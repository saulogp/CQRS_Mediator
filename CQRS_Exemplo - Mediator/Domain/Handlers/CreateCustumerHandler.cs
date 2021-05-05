using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS_Exemplo.Domain.Commands.Request;
using CQRS_Exemplo.Domain.Commands.Response;
using MediatR;

namespace CQRS_Exemplo.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verifica se o cliente já esta cadastrado 
            //valida os dados
            //Insere o cliente
            //Envia email de boas vindas
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Saulo",
                Email = "saulo@gmail.com",
                Date = DateTime.Now
            };
            return Task.FromResult(result);
        }
    }
}
