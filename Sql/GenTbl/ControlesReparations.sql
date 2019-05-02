/*----------------------------------------------------------------------------
//                 TNG Software Script Generator (Tablas)                     
//----------------------------------------------------------------------------
// Fecha              : 15/04/2019 00:59
// Base de Datos      : TNGS_Mrln
// Tabla              : ControlesReparations
//----------------------------------------------------------------------------
// � 1999-2019 by TNG Software                                      Gndr 5.20
//---------------------------------------------------------------------------*/

/* ***************************************************************************
/  Atencion!!!
/     Este archivo fue generado por un programa en forma autom�tica. Cualquier
/     modificaci�n que se realize sobre �l se perder� en la pr�xima
/     regeneraci�n.
/  **************************************************************************/

/*-------------------------------------------------*/
/* Selecciono la base en la que se creara la tabla */
/*-------------------------------------------------*/

use TNGS_Mrln
go

/*-----------------------------------*/
/* Crea la tabla en la base indicada */
/*-----------------------------------*/

print 'Tabla: ControlesReparations'

if exists (select * from sysobjects where id = object_id('dbo.ControlesReparations'))
begin
   print '   - Borrando la vieja tabla'
   drop table dbo.ControlesReparations
end
go

print '   - Creando la nueva tabla'

create table ControlesReparations
   (
      ctr_cod_codctl tngs_codigo,
      ctr_nro_nroitem tngs_numero,
      ctr_cd6_codrep tngs_codigo_6,
      instante tngs_fecyhor,
      deleted tngs_borrado,
      usuario tngs_nombre,
      version tngs_numero,
      constraint ControlesReparations_pk primary key clustered
      (
         ctr_cod_codctl,
         ctr_nro_nroitem
      )
   )
go

print '   - Asignando permisos a la nueva tabla'

grant select on ControlesReparations to tngsqbe

print ' '
go

/*--------------------------------------------------------------------------
// Fin del script de creacion de la tabla: ControlesReparations
//--------------------------------------------------------------------------*/
