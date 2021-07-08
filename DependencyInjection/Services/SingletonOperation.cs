using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public interface ISingletonOperation : IOperation
    {

    }

    public class SingletonOperation : ISingletonOperation
    {
        public Guid Id { get; }

        public SingletonOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
