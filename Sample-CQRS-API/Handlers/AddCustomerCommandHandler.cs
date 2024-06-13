using MediatR;
using Sample_CQRS_API.Commands;
using Sample_CQRS_API.Models;

namespace Sample_CQRS_API.Handlers
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Customer>
    {
        Task<Customer> IRequestHandler<AddCustomerCommand, Customer>.Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
