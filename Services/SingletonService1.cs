namespace DependencyInjection.Services
{
    public class SingletonService1 : DisposedService
    {
        public SingletonService1() : base(nameof(SingletonService1))
        {
        }
    }
}
