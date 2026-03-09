namespace DependencyInjection.Services
{
    public class TransientService2 : DisposedService
    {
        public TransientService2() : base(nameof(TransientService2))
        {
        }
    }
}
