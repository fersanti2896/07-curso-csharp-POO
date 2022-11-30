// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POO;
using POO.Clases;
using POO.Interfaces;
using Utilidades;

Console.WriteLine("¡Programación Orientada a Objetos!\n");

var carro = new Carro("");
carro.Marca = "Toyota";
carro.EncenderRadio();

var camion = new Camion("");
camion.Marca = "Mercedes Benz";

var bicicleta = new Bicicleta("");
bicicleta.Marca = "Benoto";

void LeerMarca(Vehiculo vehiculo) {
    var msg = $"Marca del Vehículo: { vehiculo.Marca } del tipo: { vehiculo }";
    Console.WriteLine(msg); 
}

LeerMarca(carro);
LeerMarca(camion);
LeerMarca(bicicleta);
Console.WriteLine();

Console.Write("Carro: ");
carro.reversa();
Console.WriteLine();

Console.Write("Camión: ");
camion.reversa();
Console.WriteLine();

Console.Write("Bicicleta: ");
bicicleta.reversa();
Console.WriteLine();

/* No se puede instanciar una clase que es abstracta */
// var veh = new Vehiculo();

/* MODIFICADORES DE ACCESO */
var clasePublica = new Publica();
clasePublica.PropPublica = 1;
clasePublica.metodoPublico();

void procesar(IInterfaz2 interfaz2) {
    interfaz2.miMetodoSegundaInterfaz();
}

var hostBuilder = Host.CreateDefaultBuilder(args);
hostBuilder = hostBuilder.ConfigureServices(configurarServicios);
using var host = hostBuilder.Build();

var almacenador = host.Services.GetRequiredService<IAlmacenadorArchivos>();

almacenador.Editar("archivo-viejo.png", "archivo.png");

var otroLugar = host.Services.GetRequiredService<DistintoLugar>();
otroLugar.procesar();

void configurarServicios(IServiceCollection services) {
    services.AddTransient<IAlmacenadorArchivos, AlmacenadorAzure>();
    services.AddTransient<AlmacenadorController>();
    services.AddTransient<DistintoLugar>();
}