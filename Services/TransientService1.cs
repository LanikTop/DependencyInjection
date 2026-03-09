namespace DependencyInjection.Services
{
    public class TransientService1 : DisposedService
    {
        public TransientService1() : base(nameof(TransientService1))
        {
        }
    }
}
