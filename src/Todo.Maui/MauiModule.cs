using Todo.Maui.Services;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Todo.Maui;

[DependsOn(typeof(AbpAutofacModule)
    )]
public class MauiModule : AbpModule
{

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddTransient<RestService>();
        //    var configuration = context.Services.GetConfiguration();

        //    Configure<OidcClientOptions>(configuration.GetSection("Oidc:Options"));

        //    context.Services.AddTransient<OidcClient>(sp =>
        //    {
        //        var options = sp.GetRequiredService<IOptions<OidcClientOptions>>().Value;
        //        options.Browser = sp.GetRequiredService<WebAuthenticatorBrowser>();
        //        return new OidcClient(options);
        //    });

        //    context.Services.AddTransient<HttpClient>(sp =>
        //        new HttpClient(sp.GetRequiredService<AccessTokenHttpMessageHandler>())
        //        {
        //            // Temporarily. We'll use ABP's Proxy for sendind requests.
        //            BaseAddress = new Uri(configuration.GetValue<string>("RemoteServices:Default:BaseUrl"))
        //        });
    }
}
