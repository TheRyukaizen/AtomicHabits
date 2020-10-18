using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MediatR;

namespace AtomicHabits.Infrastructure.MediatR
{
    public class ValidatedResponse<T> : IRequest<ValidatedResponse<bool>>
    {
        public ValidatedResponse(T response, Collection<ValidationResult> results)
        {
            ValidationSuccessful = results.Any();
            ValidationResults = results;
            Response = response;
        }
        public bool ValidationSuccessful { get; private set; }
        public Collection<ValidationResult> ValidationResults { get; private set; }
        public T Response { get; set; }
    }
}