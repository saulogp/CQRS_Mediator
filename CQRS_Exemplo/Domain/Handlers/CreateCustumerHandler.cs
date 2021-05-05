using System;
using CQRS_Exemplo.Domain.Commands.Request;
using CQRS_Exemplo.Domain.Commands.Response;

namespace CQRS_Exemplo.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            //Verifica se o cliente já esta cadastrado 
            //valida os dados
            //Insere o cliente
            //Envia email de boas vindas

            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Saulo",
                Email = "saulo@gmail.com",
                Date = DateTime.Now
            };
        }
    }
}
