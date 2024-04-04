using WebApı.Utilities.Formatters;

namespace WebApı.Extensions
{
    public static class IMvcuilderExtansions
    {
        public static IMvcBuilder AddCustomCvsFormatter(this IMvcBuilder builder) =>
            builder.AddMvcOptions(config =>
            config.OutputFormatters
            .Add(new CvsOutputFormatter()));
            
    }
}
