using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicio_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Consultar_Persona_Result> Consultar();

        [OperationContract]
        bool Registrar(string Nombre, DateTime Fecha_nacimiento, string Sexo);

        [OperationContract]

        bool Actualizar(long CodPersona, string Nombre, DateTime Fecha_nacimiento, string Sexo);

        [OperationContract]
        bool Eliminar(long CodPersona);
    }
}
