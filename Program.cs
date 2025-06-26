using Final;
using Microsoft.AspNetCore.Hosting;

namespace WebApplicationTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


//using Microsoft.Extensions.FileProviders;

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAllOrigins", policy =>
//    {
//        policy.AllowAnyOrigin()  // permite cualquier origen
//                .AllowAnyMethod()  // permite cualquier m�todo HTTP (GET, POST, etc.)
//                .AllowAnyHeader(); // permite cualquier encabezado
//    });
//});
//// Agregar servicios Swagger
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();


//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{

//    app.UseSwagger();
//    app.UseSwaggerUI(c =>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1");
//    });

//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//// Configuraci�n SPA (sin SpaServices) VUE
//if (app.Environment.IsDevelopment())
//{
//    // Redirige a servidor de desarrollo de Vue (ej. Vite)
//    app.Use(async (context, next) =>
//    {
//        if (!context.Request.Path.StartsWithSegments("/api"))
//        {
//            context.Response.Redirect("http://localhost:5173" + context.Request.Path + context.Request.QueryString);
//            return;
//        }
//        await next();
//    });
//}
//else
//{
//    // Servir archivos est�ticos de Vue desde /ClientApp/dist
//    app.UseDefaultFiles(); // buscar� index.html autom�ticamente
//    app.UseStaticFiles(new StaticFileOptions
//    {
//        FileProvider = new PhysicalFileProvider(
//            Path.Combine(app.Environment.ContentRootPath, "VistasVue", "dist")),
//        RequestPath = ""
//    });

//    // Catch-all para rutas del cliente
//    app.Use(async (context, next) =>
//    {
//        if (!context.Request.Path.StartsWithSegments("/api") &&
//            !Path.HasExtension(context.Request.Path.Value))
//        {
//            context.Request.Path = "/index.html";
//            await next();
//        }
//        else
//        {
//            await next();
//        }
//    });

//    app.UseStaticFiles(); // sirve index.html
//}
//app.UseCors("AllowAllOrigins");
//app.Run();
