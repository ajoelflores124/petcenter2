﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet.Data.EF5.EFData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PET_DBEntities : DbContext
    {
        public PET_DBEntities()
            : base("name=PET_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACI_Chip> ACI_Chip { get; set; }
        public DbSet<ACI_Chip_OrdenAtencion> ACI_Chip_OrdenAtencion { get; set; }
        public DbSet<ACI_OrdenAtencion> ACI_OrdenAtencion { get; set; }
        public DbSet<Actividades> Actividades { get; set; }
        public DbSet<ActividadesxFichaMantenimiento> ActividadesxFichaMantenimiento { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Cartilla_Atencion> Cartilla_Atencion { get; set; }
        public DbSet<CE_AprobadorPorArea> CE_AprobadorPorArea { get; set; }
        public DbSet<CE_EmpleadoPorArea> CE_EmpleadoPorArea { get; set; }
        public DbSet<CE_Estado> CE_Estado { get; set; }
        public DbSet<CE_Prioridad> CE_Prioridad { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Comprobante_Examen> Comprobante_Examen { get; set; }
        public DbSet<Comprobante_Pago> Comprobante_Pago { get; set; }
        public DbSet<Detalle_Atencion> Detalle_Atencion { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Equipo_Sede> Equipo_Sede { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<EstadoFichaMantenimiento> EstadoFichaMantenimiento { get; set; }
        public DbSet<EstadoOrdenTrabajo> EstadoOrdenTrabajo { get; set; }
        public DbSet<EstadoSolicitud> EstadoSolicitud { get; set; }
        public DbSet<Examen> Examen { get; set; }
        public DbSet<FichaMantenimiento> FichaMantenimiento { get; set; }
        public DbSet<GPC_DetalleDeSolicitud> GPC_DetalleDeSolicitud { get; set; }
        public DbSet<GPC_HistoricoDeSolicitud> GPC_HistoricoDeSolicitud { get; set; }
        public DbSet<GPC_Recurso> GPC_Recurso { get; set; }
        public DbSet<GPC_Solicitud> GPC_Solicitud { get; set; }
        public DbSet<InformeTecnico> InformeTecnico { get; set; }
        public DbSet<Mantenimiento> Mantenimiento { get; set; }
        public DbSet<Materiales> Materiales { get; set; }
        public DbSet<MaterialesxFichaMantenimiento> MaterialesxFichaMantenimiento { get; set; }
        public DbSet<OrdenTrabajo> OrdenTrabajo { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Sede> Sede { get; set; }
        public DbSet<Solicitud> Solicitud { get; set; }
        public DbSet<Tecnico> Tecnico { get; set; }
        public DbSet<TipoMantenimiento> TipoMantenimiento { get; set; }
    
        public virtual ObjectResult<USP_CONSULTA_ACTIVIDAD_Result> USP_CONSULTA_ACTIVIDAD(string descripcionActividad)
        {
            var descripcionActividadParameter = descripcionActividad != null ?
                new ObjectParameter("DescripcionActividad", descripcionActividad) :
                new ObjectParameter("DescripcionActividad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CONSULTA_ACTIVIDAD_Result>("USP_CONSULTA_ACTIVIDAD", descripcionActividadParameter);
        }
    
        public virtual int USP_CONSULTA_FICHA_MANTENIMIENTO(Nullable<int> codigoFichaMantenimiento, string descripcionFicha, Nullable<int> codigoTipoMantenimiento, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<int> estadoFichaMantenimiento, Nullable<int> codigoSede, Nullable<int> codigoArea, string ordenCampo, string ordenOrientacion, Nullable<int> paginaActual, Nullable<int> nroRegistrosPorPagina, ObjectParameter totalRegistros, ObjectParameter cantidadPaginas)
        {
            var codigoFichaMantenimientoParameter = codigoFichaMantenimiento.HasValue ?
                new ObjectParameter("CodigoFichaMantenimiento", codigoFichaMantenimiento) :
                new ObjectParameter("CodigoFichaMantenimiento", typeof(int));
    
            var descripcionFichaParameter = descripcionFicha != null ?
                new ObjectParameter("DescripcionFicha", descripcionFicha) :
                new ObjectParameter("DescripcionFicha", typeof(string));
    
            var codigoTipoMantenimientoParameter = codigoTipoMantenimiento.HasValue ?
                new ObjectParameter("CodigoTipoMantenimiento", codigoTipoMantenimiento) :
                new ObjectParameter("CodigoTipoMantenimiento", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var estadoFichaMantenimientoParameter = estadoFichaMantenimiento.HasValue ?
                new ObjectParameter("EstadoFichaMantenimiento", estadoFichaMantenimiento) :
                new ObjectParameter("EstadoFichaMantenimiento", typeof(int));
    
            var codigoSedeParameter = codigoSede.HasValue ?
                new ObjectParameter("CodigoSede", codigoSede) :
                new ObjectParameter("CodigoSede", typeof(int));
    
            var codigoAreaParameter = codigoArea.HasValue ?
                new ObjectParameter("CodigoArea", codigoArea) :
                new ObjectParameter("CodigoArea", typeof(int));
    
            var ordenCampoParameter = ordenCampo != null ?
                new ObjectParameter("OrdenCampo", ordenCampo) :
                new ObjectParameter("OrdenCampo", typeof(string));
    
            var ordenOrientacionParameter = ordenOrientacion != null ?
                new ObjectParameter("OrdenOrientacion", ordenOrientacion) :
                new ObjectParameter("OrdenOrientacion", typeof(string));
    
            var paginaActualParameter = paginaActual.HasValue ?
                new ObjectParameter("PaginaActual", paginaActual) :
                new ObjectParameter("PaginaActual", typeof(int));
    
            var nroRegistrosPorPaginaParameter = nroRegistrosPorPagina.HasValue ?
                new ObjectParameter("NroRegistrosPorPagina", nroRegistrosPorPagina) :
                new ObjectParameter("NroRegistrosPorPagina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_CONSULTA_FICHA_MANTENIMIENTO", codigoFichaMantenimientoParameter, descripcionFichaParameter, codigoTipoMantenimientoParameter, fechaInicioParameter, fechaFinParameter, estadoFichaMantenimientoParameter, codigoSedeParameter, codigoAreaParameter, ordenCampoParameter, ordenOrientacionParameter, paginaActualParameter, nroRegistrosPorPaginaParameter, totalRegistros, cantidadPaginas);
        }
    
        public virtual int USP_CONSULTA_MANTENIMIENTO(Nullable<int> codigoSolicitud, string descripcionSolicitud, string descripcionMantenimiento, Nullable<int> codigoTipoMantenimiento, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<int> codigoSede, Nullable<int> codigoArea, string ordenCampo, string ordenOrientacion, Nullable<int> paginaActual, Nullable<int> nroRegistrosPorPagina, ObjectParameter totalRegistros, ObjectParameter cantidadPaginas)
        {
            var codigoSolicitudParameter = codigoSolicitud.HasValue ?
                new ObjectParameter("CodigoSolicitud", codigoSolicitud) :
                new ObjectParameter("CodigoSolicitud", typeof(int));
    
            var descripcionSolicitudParameter = descripcionSolicitud != null ?
                new ObjectParameter("DescripcionSolicitud", descripcionSolicitud) :
                new ObjectParameter("DescripcionSolicitud", typeof(string));
    
            var descripcionMantenimientoParameter = descripcionMantenimiento != null ?
                new ObjectParameter("DescripcionMantenimiento", descripcionMantenimiento) :
                new ObjectParameter("DescripcionMantenimiento", typeof(string));
    
            var codigoTipoMantenimientoParameter = codigoTipoMantenimiento.HasValue ?
                new ObjectParameter("CodigoTipoMantenimiento", codigoTipoMantenimiento) :
                new ObjectParameter("CodigoTipoMantenimiento", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var codigoSedeParameter = codigoSede.HasValue ?
                new ObjectParameter("CodigoSede", codigoSede) :
                new ObjectParameter("CodigoSede", typeof(int));
    
            var codigoAreaParameter = codigoArea.HasValue ?
                new ObjectParameter("CodigoArea", codigoArea) :
                new ObjectParameter("CodigoArea", typeof(int));
    
            var ordenCampoParameter = ordenCampo != null ?
                new ObjectParameter("OrdenCampo", ordenCampo) :
                new ObjectParameter("OrdenCampo", typeof(string));
    
            var ordenOrientacionParameter = ordenOrientacion != null ?
                new ObjectParameter("OrdenOrientacion", ordenOrientacion) :
                new ObjectParameter("OrdenOrientacion", typeof(string));
    
            var paginaActualParameter = paginaActual.HasValue ?
                new ObjectParameter("PaginaActual", paginaActual) :
                new ObjectParameter("PaginaActual", typeof(int));
    
            var nroRegistrosPorPaginaParameter = nroRegistrosPorPagina.HasValue ?
                new ObjectParameter("NroRegistrosPorPagina", nroRegistrosPorPagina) :
                new ObjectParameter("NroRegistrosPorPagina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_CONSULTA_MANTENIMIENTO", codigoSolicitudParameter, descripcionSolicitudParameter, descripcionMantenimientoParameter, codigoTipoMantenimientoParameter, fechaInicioParameter, fechaFinParameter, codigoSedeParameter, codigoAreaParameter, ordenCampoParameter, ordenOrientacionParameter, paginaActualParameter, nroRegistrosPorPaginaParameter, totalRegistros, cantidadPaginas);
        }
    
        public virtual int USP_CONSULTA_MATERIAL(string descripcionMaterial)
        {
            var descripcionMaterialParameter = descripcionMaterial != null ?
                new ObjectParameter("DescripcionMaterial", descripcionMaterial) :
                new ObjectParameter("DescripcionMaterial", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_CONSULTA_MATERIAL", descripcionMaterialParameter);
        }
    
        public virtual int USP_CONSULTA_SOLICITUDES(Nullable<int> codigoSolicitud, string descripcion, Nullable<int> codigoTipoMantenimiento, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<int> estado, Nullable<int> codigoSede, Nullable<int> codigoArea, string ordenCampo, string ordenOrientacion, Nullable<int> paginaActual, Nullable<int> nroRegistrosPorPagina, ObjectParameter totalRegistros, ObjectParameter cantidadPaginas)
        {
            var codigoSolicitudParameter = codigoSolicitud.HasValue ?
                new ObjectParameter("CodigoSolicitud", codigoSolicitud) :
                new ObjectParameter("CodigoSolicitud", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var codigoTipoMantenimientoParameter = codigoTipoMantenimiento.HasValue ?
                new ObjectParameter("CodigoTipoMantenimiento", codigoTipoMantenimiento) :
                new ObjectParameter("CodigoTipoMantenimiento", typeof(int));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(int));
    
            var codigoSedeParameter = codigoSede.HasValue ?
                new ObjectParameter("CodigoSede", codigoSede) :
                new ObjectParameter("CodigoSede", typeof(int));
    
            var codigoAreaParameter = codigoArea.HasValue ?
                new ObjectParameter("CodigoArea", codigoArea) :
                new ObjectParameter("CodigoArea", typeof(int));
    
            var ordenCampoParameter = ordenCampo != null ?
                new ObjectParameter("OrdenCampo", ordenCampo) :
                new ObjectParameter("OrdenCampo", typeof(string));
    
            var ordenOrientacionParameter = ordenOrientacion != null ?
                new ObjectParameter("OrdenOrientacion", ordenOrientacion) :
                new ObjectParameter("OrdenOrientacion", typeof(string));
    
            var paginaActualParameter = paginaActual.HasValue ?
                new ObjectParameter("PaginaActual", paginaActual) :
                new ObjectParameter("PaginaActual", typeof(int));
    
            var nroRegistrosPorPaginaParameter = nroRegistrosPorPagina.HasValue ?
                new ObjectParameter("NroRegistrosPorPagina", nroRegistrosPorPagina) :
                new ObjectParameter("NroRegistrosPorPagina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_CONSULTA_SOLICITUDES", codigoSolicitudParameter, descripcionParameter, codigoTipoMantenimientoParameter, fechaInicioParameter, fechaFinParameter, estadoParameter, codigoSedeParameter, codigoAreaParameter, ordenCampoParameter, ordenOrientacionParameter, paginaActualParameter, nroRegistrosPorPaginaParameter, totalRegistros, cantidadPaginas);
        }
    
        public virtual ObjectResult<USP_CONSULTAR_AREA_Result> USP_CONSULTAR_AREA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CONSULTAR_AREA_Result>("USP_CONSULTAR_AREA");
        }
    
        public virtual ObjectResult<USP_CONSULTAR_ESTADO_FICHA_MANTENIMIENTO_Result> USP_CONSULTAR_ESTADO_FICHA_MANTENIMIENTO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CONSULTAR_ESTADO_FICHA_MANTENIMIENTO_Result>("USP_CONSULTAR_ESTADO_FICHA_MANTENIMIENTO");
        }
    
        public virtual ObjectResult<USP_CONSULTAR_ESTADO_SOLICITUD_Result> USP_CONSULTAR_ESTADO_SOLICITUD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CONSULTAR_ESTADO_SOLICITUD_Result>("USP_CONSULTAR_ESTADO_SOLICITUD");
        }
    
        public virtual ObjectResult<USP_CONSULTAR_SEDE_Result> USP_CONSULTAR_SEDE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CONSULTAR_SEDE_Result>("USP_CONSULTAR_SEDE");
        }
    
        public virtual ObjectResult<USP_CONSULTAR_TIPO_MANTENIMINETO_Result> USP_CONSULTAR_TIPO_MANTENIMINETO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_CONSULTAR_TIPO_MANTENIMINETO_Result>("USP_CONSULTAR_TIPO_MANTENIMINETO");
        }
    
        public virtual ObjectResult<USP_GET_ACTIVIDADES_X_FICHAMANTENIMIENTO_Result> USP_GET_ACTIVIDADES_X_FICHAMANTENIMIENTO(Nullable<int> codigoFichaMantenimiento)
        {
            var codigoFichaMantenimientoParameter = codigoFichaMantenimiento.HasValue ?
                new ObjectParameter("CodigoFichaMantenimiento", codigoFichaMantenimiento) :
                new ObjectParameter("CodigoFichaMantenimiento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GET_ACTIVIDADES_X_FICHAMANTENIMIENTO_Result>("USP_GET_ACTIVIDADES_X_FICHAMANTENIMIENTO", codigoFichaMantenimientoParameter);
        }
    
        public virtual ObjectResult<USP_GET_FICHAMANTENIMIENTO_Result> USP_GET_FICHAMANTENIMIENTO(Nullable<int> codigoFichaMantenimiento)
        {
            var codigoFichaMantenimientoParameter = codigoFichaMantenimiento.HasValue ?
                new ObjectParameter("CodigoFichaMantenimiento", codigoFichaMantenimiento) :
                new ObjectParameter("CodigoFichaMantenimiento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GET_FICHAMANTENIMIENTO_Result>("USP_GET_FICHAMANTENIMIENTO", codigoFichaMantenimientoParameter);
        }
    
        public virtual ObjectResult<USP_GET_MATERIALES_X_FICHAMANTENIMIENTO_Result> USP_GET_MATERIALES_X_FICHAMANTENIMIENTO(Nullable<int> codigoFichaMantenimiento)
        {
            var codigoFichaMantenimientoParameter = codigoFichaMantenimiento.HasValue ?
                new ObjectParameter("CodigoFichaMantenimiento", codigoFichaMantenimiento) :
                new ObjectParameter("CodigoFichaMantenimiento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GET_MATERIALES_X_FICHAMANTENIMIENTO_Result>("USP_GET_MATERIALES_X_FICHAMANTENIMIENTO", codigoFichaMantenimientoParameter);
        }
    
        public virtual ObjectResult<USP_GETMANTENIMIENTO_Result> USP_GETMANTENIMIENTO(Nullable<int> codigoSolicitud)
        {
            var codigoSolicitudParameter = codigoSolicitud.HasValue ?
                new ObjectParameter("CodigoSolicitud", codigoSolicitud) :
                new ObjectParameter("CodigoSolicitud", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GETMANTENIMIENTO_Result>("USP_GETMANTENIMIENTO", codigoSolicitudParameter);
        }
    
        public virtual ObjectResult<USP_GETSOLICITUD_Result> USP_GETSOLICITUD(Nullable<int> codigoSolicitud)
        {
            var codigoSolicitudParameter = codigoSolicitud.HasValue ?
                new ObjectParameter("CodigoSolicitud", codigoSolicitud) :
                new ObjectParameter("CodigoSolicitud", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GETSOLICITUD_Result>("USP_GETSOLICITUD", codigoSolicitudParameter);
        }
    
        public virtual int USP_REGISTRAR_FICHA_MANTENIMIENTO(Nullable<int> codigoFichaMantenimiento, Nullable<int> codigoMantenimiento, Nullable<int> codigoEmpleado, string descripcion, Nullable<System.DateTime> fecha, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<int> cantidadTecnicos, Nullable<int> estado, string usuarioRegistro, Nullable<System.DateTime> fechaHoraRegistro, string accion, ObjectParameter codigoFichaMantenimientoOut)
        {
            var codigoFichaMantenimientoParameter = codigoFichaMantenimiento.HasValue ?
                new ObjectParameter("CodigoFichaMantenimiento", codigoFichaMantenimiento) :
                new ObjectParameter("CodigoFichaMantenimiento", typeof(int));
    
            var codigoMantenimientoParameter = codigoMantenimiento.HasValue ?
                new ObjectParameter("CodigoMantenimiento", codigoMantenimiento) :
                new ObjectParameter("CodigoMantenimiento", typeof(int));
    
            var codigoEmpleadoParameter = codigoEmpleado.HasValue ?
                new ObjectParameter("CodigoEmpleado", codigoEmpleado) :
                new ObjectParameter("CodigoEmpleado", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var cantidadTecnicosParameter = cantidadTecnicos.HasValue ?
                new ObjectParameter("CantidadTecnicos", cantidadTecnicos) :
                new ObjectParameter("CantidadTecnicos", typeof(int));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(int));
    
            var usuarioRegistroParameter = usuarioRegistro != null ?
                new ObjectParameter("UsuarioRegistro", usuarioRegistro) :
                new ObjectParameter("UsuarioRegistro", typeof(string));
    
            var fechaHoraRegistroParameter = fechaHoraRegistro.HasValue ?
                new ObjectParameter("FechaHoraRegistro", fechaHoraRegistro) :
                new ObjectParameter("FechaHoraRegistro", typeof(System.DateTime));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRAR_FICHA_MANTENIMIENTO", codigoFichaMantenimientoParameter, codigoMantenimientoParameter, codigoEmpleadoParameter, descripcionParameter, fechaParameter, fechaInicioParameter, fechaFinParameter, cantidadTecnicosParameter, estadoParameter, usuarioRegistroParameter, fechaHoraRegistroParameter, accionParameter, codigoFichaMantenimientoOut);
        }
    
        public virtual int USP_REGISTRAR_SOLICITUD(Nullable<int> codigoSolicitud, string descripcion, Nullable<System.DateTime> fecha, Nullable<int> estado, Nullable<int> codigoSede, Nullable<int> codigoArea, Nullable<int> codigoTipoMantenimiento, Nullable<int> codigoEmpleado1, string usuarioRegistro, Nullable<System.DateTime> fechaHoraRegistro, string accion, ObjectParameter codigoSolicitudOut)
        {
            var codigoSolicitudParameter = codigoSolicitud.HasValue ?
                new ObjectParameter("CodigoSolicitud", codigoSolicitud) :
                new ObjectParameter("CodigoSolicitud", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(int));
    
            var codigoSedeParameter = codigoSede.HasValue ?
                new ObjectParameter("CodigoSede", codigoSede) :
                new ObjectParameter("CodigoSede", typeof(int));
    
            var codigoAreaParameter = codigoArea.HasValue ?
                new ObjectParameter("CodigoArea", codigoArea) :
                new ObjectParameter("CodigoArea", typeof(int));
    
            var codigoTipoMantenimientoParameter = codigoTipoMantenimiento.HasValue ?
                new ObjectParameter("CodigoTipoMantenimiento", codigoTipoMantenimiento) :
                new ObjectParameter("CodigoTipoMantenimiento", typeof(int));
    
            var codigoEmpleado1Parameter = codigoEmpleado1.HasValue ?
                new ObjectParameter("CodigoEmpleado1", codigoEmpleado1) :
                new ObjectParameter("CodigoEmpleado1", typeof(int));
    
            var usuarioRegistroParameter = usuarioRegistro != null ?
                new ObjectParameter("UsuarioRegistro", usuarioRegistro) :
                new ObjectParameter("UsuarioRegistro", typeof(string));
    
            var fechaHoraRegistroParameter = fechaHoraRegistro.HasValue ?
                new ObjectParameter("FechaHoraRegistro", fechaHoraRegistro) :
                new ObjectParameter("FechaHoraRegistro", typeof(System.DateTime));
    
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRAR_SOLICITUD", codigoSolicitudParameter, descripcionParameter, fechaParameter, estadoParameter, codigoSedeParameter, codigoAreaParameter, codigoTipoMantenimientoParameter, codigoEmpleado1Parameter, usuarioRegistroParameter, fechaHoraRegistroParameter, accionParameter, codigoSolicitudOut);
        }
    
        public virtual int USP_REGISTRAR_ACTIVIDAD_X_FICHA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRAR_ACTIVIDAD_X_FICHA");
        }
    
        public virtual int USP_REGISTRAR_MANTENIMIENTO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRAR_MANTENIMIENTO");
        }
    
        public virtual int USP_REGISTRAR_MATERIAL_X_FICHA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_REGISTRAR_MATERIAL_X_FICHA");
        }
    }
}
