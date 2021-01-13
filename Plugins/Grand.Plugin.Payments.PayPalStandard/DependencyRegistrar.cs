using Grand.Core.Configuration;
using Grand.Core.Infrastructure;
using Grand.Core.Infrastructure.DependencyManagement;
using Microsoft.Extensions.DependencyInjection;

namespace Grand.Plugin.Payments.PayPalStandard
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(IServiceCollection builder, ITypeFinder typeFinder, GrandConfig config)
        {
            builder.AddScoped<PayPalStandardPaymentProcessor>();
        }

        public int Order
        {
            get { return 10; }
        }
    }
}
