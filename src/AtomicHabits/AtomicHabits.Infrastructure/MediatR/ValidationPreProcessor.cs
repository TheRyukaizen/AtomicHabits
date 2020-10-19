using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;

namespace AtomicHabits.Infrastructure.MediatR
{
    public class ValidationPreProcessor<TRequest> : IRequestPreProcessor<TRequest> where TRequest : notnull
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidationPreProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            Validator.ValidateObject(request, new ValidationContext(_serviceProvider));
        }
    }
}