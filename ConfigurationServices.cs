namespace Configuration.Services
{
    public class ConfigurationServices
    {
        private string _allowedOrigins;
        public ConfigurationServices(string allowedOrigins)
        {
            _allowedOrigins = allowedOrigins;
        }
        public void GetConfiguration()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: _allowedOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("*");
                                  });
            });

            // services.AddResponseCaching();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors(_allowedOrigins);
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }

    }
}
