using Microsoft.EntityFrameworkCore;  // Importa el espacio de nombres de Entity Framework Core
using Wepsys_eCommerce.Model;  // Importa el espacio de nombres que contiene las clases de modelo

var builder = WebApplication.CreateBuilder(args);  // Crea un objeto para configurar y construir la aplicaci�n web

// Agrega servicios al contenedor de servicios
builder.Services.AddControllers();  // Registra el servicio de controladores MVC

// Registra servicios relacionados con Swagger y la documentaci�n de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura la conexi�n a la base de datos utilizando Entity Framework Core
builder.Services.AddDbContext<ProductosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionProductos")));

var app = builder.Build();  // Construye la aplicaci�n web

// Configura el pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Habilita Swagger para la generaci�n de documentaci�n de API
    app.UseSwaggerUI();  // Habilita Swagger UI para interactuar con la documentaci�n de la API
}

app.UseHttpsRedirection();  // Middleware para redirigir autom�ticamente las solicitudes HTTP a HTTPS

app.UseAuthorization();  // Habilita el middleware de autorizaci�n para gestionar la autenticaci�n y la autorizaci�n

app.MapControllers();  // Asigna las rutas de los controladores MVC

app.Run();  // Ejecuta la aplicaci�n web para que est� lista para manejar solicitudes HTTP entrantes
