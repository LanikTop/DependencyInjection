namespace DependencyInjection.Services
{
    public class ScopedService1 : DisposedService
    {
        public ScopedService1() : base(nameof(ScopedService1))
        {
        }
    }
}
