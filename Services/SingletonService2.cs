namespace DependencyInjection.Services
{
    public class SingletonService2 : DisposedService
    {
        public SingletonService2() : base(nameof(SingletonService2))
        {
        }
    }
}
