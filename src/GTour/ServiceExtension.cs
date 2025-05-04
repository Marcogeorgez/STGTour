using Microsoft.Extensions.DependencyInjection;

namespace GTour;

public static class ServiceExtension
{

    public static IServiceCollection UseGTour(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddSingleton<Abstractions.IGTourService, GTourService>();

        serviceCollection.AddScoped<Abstractions.JsInterop.IJsInteropPopper, Interops.JsInteropPopper>();
        serviceCollection.AddScoped<Abstractions.JsInterop.IJsInteropCommon, Interops.JsInteropCommon>();

        return serviceCollection;
    }

}
