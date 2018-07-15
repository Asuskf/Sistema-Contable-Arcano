/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     13/7/2018 21:06:47                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_DETALLES_TRANSACCION') and o.name = 'FK_TB_DETAL_FK_DTRANS_TB_TRANS')
alter table TB_DETALLES_TRANSACCION
   drop constraint FK_TB_DETAL_FK_DTRANS_TB_TRANS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_DETALLE_PERFIL') and o.name = 'FK_TB_DETAL_FK_CODIGO_TB_PERFI')
alter table TB_DETALLE_PERFIL
   drop constraint FK_TB_DETAL_FK_CODIGO_TB_PERFI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_ITEM_TRANSACCION') and o.name = 'FK_TB_ITEM__FK_ITRANS_TB_DETAL')
alter table TB_ITEM_TRANSACCION
   drop constraint FK_TB_ITEM__FK_ITRANS_TB_DETAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_ITEM_TRANSACCION') and o.name = 'FK_TB_ITEM__TB_ITEM_T_TB_PLANC')
alter table TB_ITEM_TRANSACCION
   drop constraint FK_TB_ITEM__TB_ITEM_T_TB_PLANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_PLANCUENTAS_ASIENTO') and o.name = 'FK_TB_PLANC_FK_CASIEN_TB_PLANC')
alter table TB_PLANCUENTAS_ASIENTO
   drop constraint FK_TB_PLANC_FK_CASIEN_TB_PLANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_PLANCUENTAS_ITEM') and o.name = 'FK_TB_PLANC_FK_CITEM__TB_PLANC')
alter table TB_PLANCUENTAS_ITEM
   drop constraint FK_TB_PLANC_FK_CITEM__TB_PLANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_PLANCUENTAS_SUBGRUPO') and o.name = 'FK_TB_PLANC_FK_CSUBGR_TB_PLANC')
alter table TB_PLANCUENTAS_SUBGRUPO
   drop constraint FK_TB_PLANC_FK_CSUBGR_TB_PLANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_TRANSACCION') and o.name = 'FK_TB_TRANS_FK_TIPO_T_TB_TIPO_')
alter table TB_TRANSACCION
   drop constraint FK_TB_TRANS_FK_TIPO_T_TB_TIPO_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_TRANSACCION') and o.name = 'FK_TB_TRANS_FK_TRANSA_TB_DETAL')
alter table TB_TRANSACCION
   drop constraint FK_TB_TRANS_FK_TRANSA_TB_DETAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_TRANSACCION') and o.name = 'FK_TB_TRANS_FK_USUARI_TB_USUAR')
alter table TB_TRANSACCION
   drop constraint FK_TB_TRANS_FK_USUARI_TB_USUAR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_DETALLES_TRANSACCION')
            and   name  = 'FK_DTRANSACCIOON_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_DETALLES_TRANSACCION.FK_DTRANSACCIOON_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_DETALLES_TRANSACCION')
            and   type = 'U')
   drop table TB_DETALLES_TRANSACCION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_DETALLE_PERFIL')
            and   name  = 'FK_CODIGO_PERFIL_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_DETALLE_PERFIL.FK_CODIGO_PERFIL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_DETALLE_PERFIL')
            and   type = 'U')
   drop table TB_DETALLE_PERFIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_ITEM_TRANSACCION')
            and   name  = 'FK_ITRANSACCION_DTRANSACCION_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_ITEM_TRANSACCION.FK_ITRANSACCION_DTRANSACCION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_ITEM_TRANSACCION')
            and   name  = 'TB_ITEM_TRANSACCION2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_ITEM_TRANSACCION.TB_ITEM_TRANSACCION2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_ITEM_TRANSACCION')
            and   type = 'U')
   drop table TB_ITEM_TRANSACCION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_PERFILES')
            and   type = 'U')
   drop table TB_PERFILES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_PLANCUENTAS_ASIENTO')
            and   name  = 'FK_CASIENTO_CSUBGRUPO_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_PLANCUENTAS_ASIENTO.FK_CASIENTO_CSUBGRUPO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_PLANCUENTAS_ASIENTO')
            and   type = 'U')
   drop table TB_PLANCUENTAS_ASIENTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_PLANCUENTAS_GRUPO')
            and   type = 'U')
   drop table TB_PLANCUENTAS_GRUPO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_PLANCUENTAS_ITEM')
            and   name  = 'FK_CITEM_CASIENTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_PLANCUENTAS_ITEM.FK_CITEM_CASIENTO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_PLANCUENTAS_ITEM')
            and   type = 'U')
   drop table TB_PLANCUENTAS_ITEM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_PLANCUENTAS_SUBGRUPO')
            and   name  = 'FK_CSUBGRUPO_CGRUPO_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_PLANCUENTAS_SUBGRUPO.FK_CSUBGRUPO_CGRUPO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_PLANCUENTAS_SUBGRUPO')
            and   type = 'U')
   drop table TB_PLANCUENTAS_SUBGRUPO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_TIPO_TRANSACCION')
            and   type = 'U')
   drop table TB_TIPO_TRANSACCION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_TRANSACCION')
            and   name  = 'FK_TIPO_TRANSACCION_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_TRANSACCION.FK_TIPO_TRANSACCION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_TRANSACCION')
            and   name  = 'FK_USUARIO_TRANSACCION_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_TRANSACCION.FK_USUARIO_TRANSACCION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TB_TRANSACCION')
            and   name  = 'FK_TRANSACCION_CLIENTE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_TRANSACCION.FK_TRANSACCION_CLIENTE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_TRANSACCION')
            and   type = 'U')
   drop table TB_TRANSACCION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_USUARIO')
            and   type = 'U')
   drop table TB_USUARIO
go

/*==============================================================*/
/* Table: TB_DETALLES_TRANSACCION                               */
/*==============================================================*/
create table TB_DETALLES_TRANSACCION (
   DETA_TRANSACCION_ID  int                  not null,
   TRAN_ID              int                  null,
   DETA_DESCRIPCION     text                 not null,
   DETA_PRECIO_UNIDAD   money                not null,
   DETA_CANTIDAD        int                  null,
   constraint PK_TB_DETALLES_TRANSACCION primary key nonclustered (DETA_TRANSACCION_ID)
)
go

/*==============================================================*/
/* Index: FK_DTRANSACCIOON_FK                                   */
/*==============================================================*/
create index FK_DTRANSACCIOON_FK on TB_DETALLES_TRANSACCION (
TRAN_ID ASC
)
go

/*==============================================================*/
/* Table: TB_DETALLE_PERFIL                                     */
/*==============================================================*/
create table TB_DETALLE_PERFIL (
   DET_PER_PROVEEDOR_ID int                  not null,
   PER_CODIGO           int                  null,
   DET_PER_CEDULA_RUC   numeric(13)          not null,
   DET_PER_NOMBRE       varchar(50)          not null,
   DET_PER_APELLIDO     varchar(50)          not null,
   DET_PER_DIRECCION    text                 not null,
   DET_PER_CORREO       text                 not null,
   constraint PK_TB_DETALLE_PERFIL primary key nonclustered (DET_PER_PROVEEDOR_ID)
)
go

/*==============================================================*/
/* Index: FK_CODIGO_PERFIL_FK                                   */
/*==============================================================*/
create index FK_CODIGO_PERFIL_FK on TB_DETALLE_PERFIL (
PER_CODIGO ASC
)
go

/*==============================================================*/
/* Table: TB_ITEM_TRANSACCION                                   */
/*==============================================================*/
create table TB_ITEM_TRANSACCION (
   ITEM_TRANSACCION_ID  int                  not null,
   PLA_ITEM_ID          int                  not null,
   DETA_TRANSACCION_ID  int                  not null,
   constraint PK_TB_ITEM_TRANSACCION primary key nonclustered (ITEM_TRANSACCION_ID)
)
go

/*==============================================================*/
/* Index: TB_ITEM_TRANSACCION2_FK                               */
/*==============================================================*/
create index TB_ITEM_TRANSACCION2_FK on TB_ITEM_TRANSACCION (
PLA_ITEM_ID ASC
)
go

/*==============================================================*/
/* Index: FK_ITRANSACCION_DTRANSACCION_FK                       */
/*==============================================================*/
create index FK_ITRANSACCION_DTRANSACCION_FK on TB_ITEM_TRANSACCION (
DETA_TRANSACCION_ID ASC
)
go

/*==============================================================*/
/* Table: TB_PERFILES                                           */
/*==============================================================*/
create table TB_PERFILES (
   PER_CODIGO           int                  not null,
   PER_DESCRIPCION      varchar(50)          not null,
   constraint PK_TB_PERFILES primary key nonclustered (PER_CODIGO)
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_ASIENTO                                */
/*==============================================================*/
create table TB_PLANCUENTAS_ASIENTO (
   PLA_ASI_ID           int                  not null,
   PLA_SUB_ID           int                  null,
   PLA_ASI_NUMERO_ASIENTO char(10)             not null,
   PLA_ASI_NOMBRE_ASIENTO char(90)             null,
   constraint PK_TB_PLANCUENTAS_ASIENTO primary key nonclustered (PLA_ASI_ID)
)
go

/*==============================================================*/
/* Index: FK_CASIENTO_CSUBGRUPO_FK                              */
/*==============================================================*/
create index FK_CASIENTO_CSUBGRUPO_FK on TB_PLANCUENTAS_ASIENTO (
PLA_SUB_ID ASC
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_GRUPO                                  */
/*==============================================================*/
create table TB_PLANCUENTAS_GRUPO (
   PLAN_GRUP_CUENTAS_ID int                  not null,
   PLA_GRUP_CODIGO_GRUPO numeric(1)           not null,
   PLA_GRUP_NOMBRE_GRUPO varchar(31)          not null,
   constraint PK_TB_PLANCUENTAS_GRUPO primary key nonclustered (PLAN_GRUP_CUENTAS_ID)
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_ITEM                                   */
/*==============================================================*/
create table TB_PLANCUENTAS_ITEM (
   PLA_ITEM_ID          int                  not null,
   PLA_ASI_ID           int                  null,
   PLA_ITEM_NUMERO_ITEM char(14)             not null,
   PLA_ITEM_NOMBRE_ITEM char(85)             not null,
   constraint PK_TB_PLANCUENTAS_ITEM primary key nonclustered (PLA_ITEM_ID)
)
go

/*==============================================================*/
/* Index: FK_CITEM_CASIENTO_FK                                  */
/*==============================================================*/
create index FK_CITEM_CASIENTO_FK on TB_PLANCUENTAS_ITEM (
PLA_ASI_ID ASC
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_SUBGRUPO                               */
/*==============================================================*/
create table TB_PLANCUENTAS_SUBGRUPO (
   PLA_SUB_ID           int                  not null,
   PLAN_GRUP_CUENTAS_ID int                  null,
   PLA_SUB_CODIGO_SUBGRUPO char(4)              not null,
   PLA_SUB_NOMBRE_SUBGRUPO char(65)             not null,
   constraint PK_TB_PLANCUENTAS_SUBGRUPO primary key nonclustered (PLA_SUB_ID)
)
go

/*==============================================================*/
/* Index: FK_CSUBGRUPO_CGRUPO_FK                                */
/*==============================================================*/
create index FK_CSUBGRUPO_CGRUPO_FK on TB_PLANCUENTAS_SUBGRUPO (
PLAN_GRUP_CUENTAS_ID ASC
)
go

/*==============================================================*/
/* Table: TB_TIPO_TRANSACCION                                   */
/*==============================================================*/
create table TB_TIPO_TRANSACCION (
   TIP_TRAN_ID          int                  not null,
   TIP_TRAN_DESCRIPCION_TIPO_TRANSACCION varchar(50)          not null,
   constraint PK_TB_TIPO_TRANSACCION primary key nonclustered (TIP_TRAN_ID)
)
go

/*==============================================================*/
/* Table: TB_TRANSACCION                                        */
/*==============================================================*/
create table TB_TRANSACCION (
   TRAN_ID              int                  not null,
   DET_PER_PROVEEDOR_ID int                  null,
   USU_ID               int                  null,
   TIP_TRAN_ID          int                  null,
   TRAN_DESCRIPCION     text                 not null,
   TRAN_TIPOTRANSACCION int                  not null,
   TRAN_FECHA           datetime             not null,
   TRAN_AUTORIZACION    varchar(50)          not null,
   constraint PK_TB_TRANSACCION primary key nonclustered (TRAN_ID)
)
go

/*==============================================================*/
/* Index: FK_TRANSACCION_CLIENTE_FK                             */
/*==============================================================*/
create index FK_TRANSACCION_CLIENTE_FK on TB_TRANSACCION (
DET_PER_PROVEEDOR_ID ASC
)
go

/*==============================================================*/
/* Index: FK_USUARIO_TRANSACCION_FK                             */
/*==============================================================*/
create index FK_USUARIO_TRANSACCION_FK on TB_TRANSACCION (
USU_ID ASC
)
go

/*==============================================================*/
/* Index: FK_TIPO_TRANSACCION_FK                                */
/*==============================================================*/
create index FK_TIPO_TRANSACCION_FK on TB_TRANSACCION (
TIP_TRAN_ID ASC
)
go

/*==============================================================*/
/* Table: TB_USUARIO                                            */
/*==============================================================*/
create table TB_USUARIO (
   USU_ID               int                  not null,
   USU_NOMBRE           varchar(50)          not null,
   USU_APELLIDO         varchar(50)          not null,
   USU_DIRECCION        text                 not null,
   USU_CORREO           varchar(30)          not null,
   USU_FOTO             image                null,
   USU_NOMBRE_USUARIO   varchar(20)          not null,
   USU_CONTRASENIA_USUARIO varchar(50)          not null,
   constraint PK_TB_USUARIO primary key nonclustered (USU_ID)
)
go

alter table TB_DETALLES_TRANSACCION
   add constraint FK_TB_DETAL_FK_DTRANS_TB_TRANS foreign key (TRAN_ID)
      references TB_TRANSACCION (TRAN_ID)
go

alter table TB_DETALLE_PERFIL
   add constraint FK_TB_DETAL_FK_CODIGO_TB_PERFI foreign key (PER_CODIGO)
      references TB_PERFILES (PER_CODIGO)
go

alter table TB_ITEM_TRANSACCION
   add constraint FK_TB_ITEM__FK_ITRANS_TB_DETAL foreign key (DETA_TRANSACCION_ID)
      references TB_DETALLES_TRANSACCION (DETA_TRANSACCION_ID)
go

alter table TB_ITEM_TRANSACCION
   add constraint FK_TB_ITEM__TB_ITEM_T_TB_PLANC foreign key (PLA_ITEM_ID)
      references TB_PLANCUENTAS_ITEM (PLA_ITEM_ID)
go

alter table TB_PLANCUENTAS_ASIENTO
   add constraint FK_TB_PLANC_FK_CASIEN_TB_PLANC foreign key (PLA_SUB_ID)
      references TB_PLANCUENTAS_SUBGRUPO (PLA_SUB_ID)
go

alter table TB_PLANCUENTAS_ITEM
   add constraint FK_TB_PLANC_FK_CITEM__TB_PLANC foreign key (PLA_ASI_ID)
      references TB_PLANCUENTAS_ASIENTO (PLA_ASI_ID)
go

alter table TB_PLANCUENTAS_SUBGRUPO
   add constraint FK_TB_PLANC_FK_CSUBGR_TB_PLANC foreign key (PLAN_GRUP_CUENTAS_ID)
      references TB_PLANCUENTAS_GRUPO (PLAN_GRUP_CUENTAS_ID)
go

alter table TB_TRANSACCION
   add constraint FK_TB_TRANS_FK_TIPO_T_TB_TIPO_ foreign key (TIP_TRAN_ID)
      references TB_TIPO_TRANSACCION (TIP_TRAN_ID)
go

alter table TB_TRANSACCION
   add constraint FK_TB_TRANS_FK_TRANSA_TB_DETAL foreign key (DET_PER_PROVEEDOR_ID)
      references TB_DETALLE_PERFIL (DET_PER_PROVEEDOR_ID)
go

alter table TB_TRANSACCION
   add constraint FK_TB_TRANS_FK_USUARI_TB_USUAR foreign key (USU_ID)
      references TB_USUARIO (USU_ID)
go

