﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Siglo21.DALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class SigloXXIEntities : DbContext
    {
        public SigloXXIEntities()
            : base("name=SigloXXIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BOLETA> BOLETA { get; set; }
        public DbSet<DETALLE_INSUMO> DETALLE_INSUMO { get; set; }
        public DbSet<DETALLE_PEDIDO> DETALLE_PEDIDO { get; set; }
        public DbSet<INFORME> INFORME { get; set; }
        public DbSet<INSUMO> INSUMO { get; set; }
        public DbSet<MESA> MESA { get; set; }
        public DbSet<METODO_PAGO> METODO_PAGO { get; set; }
        public DbSet<PEDIDO> PEDIDO { get; set; }
        public DbSet<PLATO> PLATO { get; set; }
        public DbSet<RESERVA> RESERVA { get; set; }
        public DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int SP_UPDATE_USUARIO(Nullable<decimal> u_IDUSER, string u_USERNAME, string u_PASSWORD, string u_NOMBRE, string u_APELLIDO, string u_RUT, Nullable<decimal> u_TELEFONO, string u_ESTADO, Nullable<decimal> u_IDTIPOUSUARIO)
        {
            var u_IDUSERParameter = u_IDUSER.HasValue ?
                new ObjectParameter("U_IDUSER", u_IDUSER) :
                new ObjectParameter("U_IDUSER", typeof(decimal));
    
            var u_USERNAMEParameter = u_USERNAME != null ?
                new ObjectParameter("U_USERNAME", u_USERNAME) :
                new ObjectParameter("U_USERNAME", typeof(string));
    
            var u_PASSWORDParameter = u_PASSWORD != null ?
                new ObjectParameter("U_PASSWORD", u_PASSWORD) :
                new ObjectParameter("U_PASSWORD", typeof(string));
    
            var u_NOMBREParameter = u_NOMBRE != null ?
                new ObjectParameter("U_NOMBRE", u_NOMBRE) :
                new ObjectParameter("U_NOMBRE", typeof(string));
    
            var u_APELLIDOParameter = u_APELLIDO != null ?
                new ObjectParameter("U_APELLIDO", u_APELLIDO) :
                new ObjectParameter("U_APELLIDO", typeof(string));
    
            var u_RUTParameter = u_RUT != null ?
                new ObjectParameter("U_RUT", u_RUT) :
                new ObjectParameter("U_RUT", typeof(string));
    
            var u_TELEFONOParameter = u_TELEFONO.HasValue ?
                new ObjectParameter("U_TELEFONO", u_TELEFONO) :
                new ObjectParameter("U_TELEFONO", typeof(decimal));
    
            var u_ESTADOParameter = u_ESTADO != null ?
                new ObjectParameter("U_ESTADO", u_ESTADO) :
                new ObjectParameter("U_ESTADO", typeof(string));
    
            var u_IDTIPOUSUARIOParameter = u_IDTIPOUSUARIO.HasValue ?
                new ObjectParameter("U_IDTIPOUSUARIO", u_IDTIPOUSUARIO) :
                new ObjectParameter("U_IDTIPOUSUARIO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_USUARIO", u_IDUSERParameter, u_USERNAMEParameter, u_PASSWORDParameter, u_NOMBREParameter, u_APELLIDOParameter, u_RUTParameter, u_TELEFONOParameter, u_ESTADOParameter, u_IDTIPOUSUARIOParameter);
        }
    
        public virtual int SP_DELETE_USUARIO(Nullable<decimal> u_IDUSER)
        {
            var u_IDUSERParameter = u_IDUSER.HasValue ?
                new ObjectParameter("U_IDUSER", u_IDUSER) :
                new ObjectParameter("U_IDUSER", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_USUARIO", u_IDUSERParameter);
        }
    
        public virtual int SP_INSERT_USUARIO(string u_USERNAME, string u_PASSWORD, string u_NOMBRE, string u_APELLIDO, string u_RUT, Nullable<decimal> u_TELEFONO, string u_ESTADO, Nullable<decimal> u_IDTIPOUSUARIO)
        {
            var u_USERNAMEParameter = u_USERNAME != null ?
                new ObjectParameter("U_USERNAME", u_USERNAME) :
                new ObjectParameter("U_USERNAME", typeof(string));
    
            var u_PASSWORDParameter = u_PASSWORD != null ?
                new ObjectParameter("U_PASSWORD", u_PASSWORD) :
                new ObjectParameter("U_PASSWORD", typeof(string));
    
            var u_NOMBREParameter = u_NOMBRE != null ?
                new ObjectParameter("U_NOMBRE", u_NOMBRE) :
                new ObjectParameter("U_NOMBRE", typeof(string));
    
            var u_APELLIDOParameter = u_APELLIDO != null ?
                new ObjectParameter("U_APELLIDO", u_APELLIDO) :
                new ObjectParameter("U_APELLIDO", typeof(string));
    
            var u_RUTParameter = u_RUT != null ?
                new ObjectParameter("U_RUT", u_RUT) :
                new ObjectParameter("U_RUT", typeof(string));
    
            var u_TELEFONOParameter = u_TELEFONO.HasValue ?
                new ObjectParameter("U_TELEFONO", u_TELEFONO) :
                new ObjectParameter("U_TELEFONO", typeof(decimal));
    
            var u_ESTADOParameter = u_ESTADO != null ?
                new ObjectParameter("U_ESTADO", u_ESTADO) :
                new ObjectParameter("U_ESTADO", typeof(string));
    
            var u_IDTIPOUSUARIOParameter = u_IDTIPOUSUARIO.HasValue ?
                new ObjectParameter("U_IDTIPOUSUARIO", u_IDTIPOUSUARIO) :
                new ObjectParameter("U_IDTIPOUSUARIO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERT_USUARIO", u_USERNAMEParameter, u_PASSWORDParameter, u_NOMBREParameter, u_APELLIDOParameter, u_RUTParameter, u_TELEFONOParameter, u_ESTADOParameter, u_IDTIPOUSUARIOParameter);
        }
    
        public virtual int SP_LOGIN(string uSERN, string pASS, ObjectParameter iDUSUARIO)
        {
            var uSERNParameter = uSERN != null ?
                new ObjectParameter("USERN", uSERN) :
                new ObjectParameter("USERN", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_LOGIN", uSERNParameter, pASSParameter, iDUSUARIO);
        }
    
        public virtual int SP_DELETE_INSUMO(Nullable<decimal> u_IDINSUMO)
        {
            var u_IDINSUMOParameter = u_IDINSUMO.HasValue ?
                new ObjectParameter("U_IDINSUMO", u_IDINSUMO) :
                new ObjectParameter("U_IDINSUMO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_INSUMO", u_IDINSUMOParameter);
        }
    
        public virtual int SP_UPDATE_INSUMO(Nullable<decimal> u_IDINSUMO, string u_NOMBREINSUMO, string u_DESCRIPCION, Nullable<decimal> u_PRECIOUNITARIO, Nullable<decimal> u_STOCK)
        {
            var u_IDINSUMOParameter = u_IDINSUMO.HasValue ?
                new ObjectParameter("U_IDINSUMO", u_IDINSUMO) :
                new ObjectParameter("U_IDINSUMO", typeof(decimal));
    
            var u_NOMBREINSUMOParameter = u_NOMBREINSUMO != null ?
                new ObjectParameter("U_NOMBREINSUMO", u_NOMBREINSUMO) :
                new ObjectParameter("U_NOMBREINSUMO", typeof(string));
    
            var u_DESCRIPCIONParameter = u_DESCRIPCION != null ?
                new ObjectParameter("U_DESCRIPCION", u_DESCRIPCION) :
                new ObjectParameter("U_DESCRIPCION", typeof(string));
    
            var u_PRECIOUNITARIOParameter = u_PRECIOUNITARIO.HasValue ?
                new ObjectParameter("U_PRECIOUNITARIO", u_PRECIOUNITARIO) :
                new ObjectParameter("U_PRECIOUNITARIO", typeof(decimal));
    
            var u_STOCKParameter = u_STOCK.HasValue ?
                new ObjectParameter("U_STOCK", u_STOCK) :
                new ObjectParameter("U_STOCK", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_INSUMO", u_IDINSUMOParameter, u_NOMBREINSUMOParameter, u_DESCRIPCIONParameter, u_PRECIOUNITARIOParameter, u_STOCKParameter);
        }
    }
}