using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using NivelAcohol.Domain;
 /*Escuela: Universidad Tecnologica Metropolitana
    Materia: Aplicaciones Web Orientadas a Servicios
    Maestro: Chuc Uc Joel Ivan
    Actividad: Actividad 3: Alcoholemia
    Alumno: Nayeli Osornio
    Cuatrimestre: 4
    Grupo: A
    Parcial: 2*/

namespace NivelAcohol.Infraestructure
{
    public class IngeribleRepository
    {
        List<Ingerible> _Ingerible;
        public IngeribleRepository()
        {
            var fileName = "Ingerible.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _Ingerible = JsonSerializer.Deserialize<IEnumerable<Ingerible>>(json).ToList();
            }
        }

        public IEnumerable<Ingerible> GetAll()
        {
            var query = _Ingerible.Select(Ingerible => Ingerible);
            return query;
        }

        
    }
}