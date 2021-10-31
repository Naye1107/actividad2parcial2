using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resistencias.Domain;

namespace Resistencias.Controllers
{
/*Escuela: Universidad Tecnologica Metropolitana
Materia: Aplicaciones Web Orientadas a Servicios
Maestro: Chuc Uc Joel Ivan
Actividad: Actividad 2: Resistencias
Alumno: Nayeli Osornio 
Cuatrimestre: 4
Grupo: A
Parcial: 2*/
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraResistenciaController : ControllerBase
    {
        [HttpGet]
        [Route("CALCULOS")]
        public IActionResult Calculadora(string banda1, string banda2, string banda3, string banda4)
        {
            ObtenerColor obtenercolor = new ObtenerColor();

            obtenercolor.Nombre = banda1.ToLower();
            var Respuesta = "";
            
            switch (obtenercolor.Nombre)
            {
                case "negro":
                    obtenercolor.Bandas = 0;
                break;
                case "cafe":
                    obtenercolor.Bandas = 1;
                break;
                case "rojo":
                    obtenercolor.Bandas = 2;
                break;
                case "naranja":
                    obtenercolor.Bandas = 3;
                break;
                case "amarillo":
                    obtenercolor.Bandas = 4;
                break;
                case "verde":
                    obtenercolor.Bandas = 5;
                break;
                case "azul":
                    obtenercolor.Bandas = 6;
                break;
                case "violeta":
                    obtenercolor.Bandas = 7;
                break;
                case "gris":
                    obtenercolor.Bandas = 8;
                break;
                case "blanco":
                    obtenercolor.Bandas = 9;
                break;
                default:
                    Respuesta = ($"Banda 1 Color {obtenercolor.Nombre} No existe");
                break;

            }
            var bandas1 = obtenercolor.Bandas;

            //SEGUNDO COLOR O BANDA
            obtenercolor.Nombre = banda2.ToLower();
            switch (obtenercolor.Nombre)
            {
                case "negro":
                    obtenercolor.Bandas = 0;
                break;
                case "cafe":
                    obtenercolor.Bandas = 1;
                break;
                case "rojo":
                    obtenercolor.Bandas = 2;
                break;
                case "naranja":
                    obtenercolor.Bandas = 3;
                break;
                case "amarillo":
                    obtenercolor.Bandas = 4;
                break;
                case "verde":
                    obtenercolor.Bandas = 5;
                break;
                case "azul":
                    obtenercolor.Bandas = 6;
                break;
                case "violeta":
                    obtenercolor.Bandas = 7;
                break;
                case "gris":
                    obtenercolor.Bandas = 8;
                break;
                case "blanco":
                    obtenercolor.Bandas = 9;
                break;
                default:
                    Respuesta = ($"Banda 2 Color {obtenercolor.Nombre} No existe");
                return Ok(Respuesta);

            }
            var bandas2 = obtenercolor.Bandas;

            //TERCER COLOR O BANDA
            obtenercolor.Nombre = banda3.ToLower();
            switch (obtenercolor.Nombre)
            {
                case "negro":
                    obtenercolor.Multiplicador = 1;
                break;
                case "cafe":
                    obtenercolor.Multiplicador = 10;
                break;
                case "rojo":
                    obtenercolor.Multiplicador = 100;
                break;
                case "naranja":
                    obtenercolor.Multiplicador = 1000;
                break;
                case "amarillo":
                    obtenercolor.Multiplicador = 10000;
                break;
                case "verde":
                    obtenercolor.Multiplicador = 100000;
                break;
                case "azul":
                    obtenercolor.Multiplicador = 1000000;
                break;
                case "dorado":
                    obtenercolor.Multiplicador = 10;
                break;
                case "plata":
                    obtenercolor.Multiplicador = 100;
                break;
                default:
                    Respuesta = ($"Banda 3 Color {obtenercolor.Nombre} No existe");
                return Ok(Respuesta);

            }
            var bandas3 = obtenercolor.Multiplicador;

            //CUARTO COLOR O BANDA
            obtenercolor.Nombre = banda4.ToLower();
            switch (obtenercolor.Nombre)
            {
                case "plata":
                    obtenercolor.Bandas = 10;
                break;
                case "dorado":
                    obtenercolor.Bandas = 5;
                break;
                default:
                    Respuesta = ($"Banda 4 Color {obtenercolor.Nombre} No existe");
                return Ok(Respuesta);

            }
            var bandas4 = obtenercolor.Bandas;

            float Calculo= 0;
            var Juntar = Int32.Parse($"{bandas1}{bandas2}");

            if (banda3.ToLower() == "dorado" || banda3.ToLower() == "plata")
            {
                Calculo = (Juntar/bandas3);
            }
            else
            {
                Calculo = (Juntar * bandas3);
            }

            Respuesta = $"Valor de la resistencia: {Calculo} Ohms {bandas4}%";
            return Ok(Respuesta);
        }
    }
}