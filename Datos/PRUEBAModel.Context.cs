﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PruebaBD : DbContext
    {
        public PruebaBD()
            : base("name=PruebaBD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Persona> Persona { get; set; }
    
        public virtual ObjectResult<Consultar_Persona_Result> Consultar_Persona()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Persona_Result>("Consultar_Persona");
        }
    
        public virtual int Actualizar_Persona(Nullable<long> cod_Persona, string nombre, Nullable<System.DateTime> fecha_nacimiento, string sexo)
        {
            var cod_PersonaParameter = cod_Persona.HasValue ?
                new ObjectParameter("Cod_Persona", cod_Persona) :
                new ObjectParameter("Cod_Persona", typeof(long));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fecha_nacimientoParameter = fecha_nacimiento.HasValue ?
                new ObjectParameter("Fecha_nacimiento", fecha_nacimiento) :
                new ObjectParameter("Fecha_nacimiento", typeof(System.DateTime));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Actualizar_Persona", cod_PersonaParameter, nombreParameter, fecha_nacimientoParameter, sexoParameter);
        }
    
        public virtual int Eliminar_Persona(Nullable<long> cod_Persona)
        {
            var cod_PersonaParameter = cod_Persona.HasValue ?
                new ObjectParameter("Cod_Persona", cod_Persona) :
                new ObjectParameter("Cod_Persona", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Persona", cod_PersonaParameter);
        }
    
        public virtual int Registrar_Persona(string nombre, Nullable<System.DateTime> fecha_nacimiento, string sexo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fecha_nacimientoParameter = fecha_nacimiento.HasValue ?
                new ObjectParameter("Fecha_nacimiento", fecha_nacimiento) :
                new ObjectParameter("Fecha_nacimiento", typeof(System.DateTime));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Persona", nombreParameter, fecha_nacimientoParameter, sexoParameter);
        }
    }
}
