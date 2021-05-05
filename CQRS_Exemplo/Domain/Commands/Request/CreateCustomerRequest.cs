namespace CQRS_Exemplo.Domain.Commands.Request
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
