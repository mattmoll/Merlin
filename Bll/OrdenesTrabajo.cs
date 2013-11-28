#region Usings
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetAppBll;
using TNGS.NetRoutines;
using Rivn;
using Rivn.Bel;
#endregion

namespace Rivn.Bll
{
    //----------------------------------------------------------------------------
    //                         TNG Software BLL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 21/10/2013 16:14
    // Sistema                  : Rivn
    // Clase para Administrar   : Ordenes de Trabajo y sus Items
    //----------------------------------------------------------------------------
    // � 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    //    Agregue en esta clase los metodos fijos que desea incorporar 
    //****************************************************************************

    /// <summary>
    /// Mantenimiento de: Ordenes de Trabajo y sus Items
    /// </summary>
    public static partial class OrdenesTrabajo
    {
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        #region Metodos publicos de la clase


        /// <summary>
        /// Devuelve la lista entidades de ordenes de trabajo de un movil (buscando por patente)
        /// </summary>
        /// <param name="p_strPatente"></param>
        /// <param name="p_smResult"></param>
        /// <returns>ListaEOrdenes De Trabajo</returns>
        public static LEOrdenesTrabajo ObtenerOTsPorPatente(string p_strPatente, ref StatMsg p_smResult)
        {           // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "ObtenerOTsPorPatente");
            DBConn l_dbcAccess = null;
            LEOrdenesTrabajo l_LEOrdenesTrabajo = LEOrdenesTrabajo.NewEmpty();
            try
            {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Por cada equipamiento de la lista lo grabamos, con la misma coneccion todos
                 l_LEOrdenesTrabajo = Bll.OrdenesTrabajo.getByPatente(l_dbcAccess, p_strPatente, ref p_smResult);

            }
            catch (Exception l_expData)
            {
                // Error 
                p_smResult.BllError(l_expData.ToString());
            }
            finally
            {
                // Si pude abrir la conexion
                if (l_dbcAccess != null)
                {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }

                p_smResult.BllPop();
            }
            return l_LEOrdenesTrabajo;
        }


        /// <summary>
        /// Graba todos los OTItems que se encuentran en una lista entidad.
        /// </summary>
        /// <param name="p_lentOTItems"> Lista Entidad con los items a grabar </param>
        /// <param name="p_smResult">ref StatMsg</param>
        public static void GrabarOTItems(LEOTItems p_lentOTItems, ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("Moviles", "MvcoSave");
            DBConn l_dbcAccess = null;

            try
            {
                // Obtenemos una conexion y abrimos una transaccion
                l_dbcAccess = DBRuts.GetConection(Connections.Dat);
                l_dbcAccess.BeginTransaction();

                // Por cada equipamiento de la lista lo grabamos, con la misma coneccion todos
                foreach (Bel.EOTItem item in p_lentOTItems)
                {
                    // insertamos todas las entidades
                    OtitInsr(l_dbcAccess, item, ref p_smResult);
                    if (p_smResult.NOk) return;
                }

            }
            catch (Exception l_expData)
            {
                // Error 
                p_smResult.BllError(l_expData.ToString());
            }
            finally
            {
                // Si pude abrir la conexion
                if (l_dbcAccess != null)
                {
                    // Finalizo la transacci�n y la cierro
                    l_dbcAccess.EndTransaction(p_smResult);
                    l_dbcAccess.Close();
                }
                p_smResult.BllPop();
            }
        }
        #endregion

        //---------------------------------------------------------------
        // Metodos privados de la clase
        //---------------------------------------------------------------

        #region Metodos del Generador
        /// <summary>
        /// Agrega o modifica un registro de la tabla: OrdenesTrabajo
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Save_f(DBConn p_dbcAccess,
                                    ref EOrdenTrabajo p_entOrdenTrabajo,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "Save_f");

            // *********
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: OrdenesTrabajo
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNro">nro</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Enabled_f(DBConn p_dbcAccess,
                                       bool p_bEnable,
                                       int p_iNro,
                                       ref int p_iFxdVersion,
                                       ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "Enabled_f");

            // *********
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: OrdenesTrabajo
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNro">nro</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void Remove_f(DBConn p_dbcAccess,
                                      int p_iNro,
                                      int p_iFxdVersion,
                                      ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "Remove_f");

            // *********
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: OrdenTrabajo
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOrdenTrabajo">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void TInt_f(DBConn p_dbcAccess,
                                    EOrdenTrabajo p_entOrdenTrabajo,
                                    ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "TInt_f");

            // *********
            // Agregar ac� las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega o modifica un registro de la tabla: OtItems
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a procesar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitSave_f(DBConn p_dbcAccess,
                                        ref EOTItem p_entOTItem,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitSave_f");

            // *********
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Habilita/Deshabilita un registro de la tabla: OtItems
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_bEnable">Tipo de operacion</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitEnabled_f(DBConn p_dbcAccess,
                                           bool p_bEnable,
                                           int p_iNroot,
                                           int p_iNroagrupador,
                                           int p_iNroitem,
                                           ref int p_iFxdVersion,
                                           ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitEnabled_f");

            // *********
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Borra f�sicamento un registro de la tabla: OtItems
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_iNroot">nroOt</param>
        /// <param name="p_iNroagrupador">Numero de agrupador</param>
        /// <param name="p_iNroitem">Numero del item</param>
        /// <param name="p_iFxdVersion">Versi�n del registro a borrar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitRemove_f(DBConn p_dbcAccess,
                                          int p_iNroot,
                                          int p_iNroagrupador,
                                          int p_iNroitem,
                                          int p_iFxdVersion,
                                          ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitRemove_f");

            // *********
            // Agregar ac� los procesos adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        /// <summary>
        /// Agrega validacion de integridad a una entidad: OTItem
        /// (C�digo Fijo)
        /// </summary>
        /// <param name="p_dbcAccess">Conexion a la base de datos</param>
        /// <param name="p_entOTItem">Entidad con los datos a validar</param>
        /// <param name="p_smResult">Estado final de la operacion</param>
        internal static void OtitTInt_f(DBConn p_dbcAccess,
                                        EOTItem p_entOTItem,
                                        ref StatMsg p_smResult)
        {
            // No hay errores aun
            p_smResult.BllReset("OrdenesTrabajo", "OtitTInt_f");

            // *********
            // Agregar ac� las validaciones adicionales
            // *********

            // Finalizamos
            p_smResult.BllPop();
        }

        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        #endregion
    }
}
