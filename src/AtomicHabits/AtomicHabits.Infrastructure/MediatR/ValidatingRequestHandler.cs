using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace AtomicHabits.Infrastructure.MediatR
{
    public class ValidatingRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, ValidatedResponse<TResponse>> where TRequest : IRequest<ValidatedResponse<TResponse>>
    {
        public ValidatingRequestHandler()
        {
            var results = new Collection<ValidationResult>();
            var validator = Validator.TryValidateObject(request, new ValidationContext(request), results);
        }
    }
}