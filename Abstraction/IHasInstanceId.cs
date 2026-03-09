using System;

namespace DependencyInjection.Abstraction
{
    public interface IHasInstanceId
    {
        Guid InstanceId { get; }
    }
}
