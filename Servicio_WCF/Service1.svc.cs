using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicio_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public List<Consultar_Persona_Result> Consultar()
        {
            PruebaBD bd = new PruebaBD();
            var consulta = bd.Consultar_Persona().ToList();
            return consulta;
        }
        public bool Registrar(string Nombre, DateTime Fecha, string Sexo)
        {
            bool validacion = false;
            using (PruebaBD bd = new PruebaBD())
            {
                bd.Registrar_Persona(Nombre, Fecha, Sexo);
            }
            return validacion;
        }
        public bool Actualizar(long CodPersona, string Nombre, DateTime Fecha_nacimiento, string Sexo)
        {
            bool validacion = false;
            using (PruebaBD bd = new PruebaBD())
            {
                bd.Actualizar_Persona(CodPersona, Nombre, Fecha_nacimiento, Sexo);
            }
            return validacion;
        }

        public bool Eliminar(long CodPersona)
        {
            bool validacion = false;
            using (PruebaBD bd = new PruebaBD())
            {
                bd.Eliminar_Persona(CodPersona);
            }
            return validacion;
        }
    }
}
