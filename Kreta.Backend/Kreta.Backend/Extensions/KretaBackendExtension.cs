namespace Kreta.Backend.Extensions
{
    public static class KretaBackendExtension
    {

        public static void AddBackend(this IServiceCollection services)
        {

        }

        private static void ConfigureCors(this IServiceCollection services) 
        {
            services.AddCors(option => option.AddPolicy(name: "KretaCors", policy => {
                policy.WithOrigins("https://0.0.0.0:7020/")
                .AllowAnyHeader()
                .AllowAnyMethod();
            }));


        }



    }
}
