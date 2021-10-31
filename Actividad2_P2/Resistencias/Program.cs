using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Resistencias
{
    /*Escuela: Universidad Tecnologica Metropolitana
Materia: Aplicaciones Web Orientadas a Servicios
Maestro: Chuc Uc Joel Ivan
Actividad: Actividad 2: Resistencias
Alumno: Nayeli Osornio 
Cuatrimestre: 4
Grupo: A
Parcial: 2*/
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
