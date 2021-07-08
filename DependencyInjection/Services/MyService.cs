using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public interface IMyService
    {

    }

    public class MyService : IMyService
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly ITransientOperation _transientOperation;
    
        public MyService(ISingletonOperation singletonOperation, IScopedOperation scopedOperation, ITransientOperation transientOperation)
        {
            _singletonOperation = singletonOperation;
            _scopedOperation = scopedOperation;
            _transientOperation = transientOperation;
        }
    }
}
