namespace DependencyInjection.Services
{
    public class ScopedService2 : DisposedService
    {
        public ScopedService2() : base(nameof(ScopedService2))
        {
        }
    }
}
