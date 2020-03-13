

namespace SitecorePractice.Foundation.DependencyInjection.Controllers
{
    using Microsoft.Extensions.DependencyInjection;
    using Sitecore.DependencyInjection;

    public class RegisterDependencyInjection : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("SitecorePractice.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("SitecorePractice.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("SitecorePractice.Foundation.*");

        }
    }
}