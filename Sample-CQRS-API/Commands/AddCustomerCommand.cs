using MediatR;
using Sample_CQRS_API.Models;

namespace Sample_CQRS_API.Commands
{
     public record AddCustomerCommand(Customer Customer) : IRequest<Customer>; 
}
