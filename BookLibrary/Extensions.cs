using SoapCore;

namespace BookLibrary;

public static class Extensions
{
    public static void UseSoapServiceWithDeniedGET<Service>(this IEndpointRouteBuilder endpoints)
        where Service : class
    {
        endpoints.UseSoapEndpoint<Service>(opt =>
        {
            opt.Path = $"/{typeof(Service).Name}.svc";
            opt.HttpGetEnabled = false;
            opt.HttpsGetEnabled = false;
            opt.EncoderOptions = new SoapEncoderOptions[] { new SoapEncoderOptions() };
            opt.SoapSerializer = SoapSerializer.XmlSerializer;
        });
    }
}
