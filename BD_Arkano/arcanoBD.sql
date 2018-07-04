/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     4/7/2018 8:35:42                             */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_DETALLES_TRANSACCION') and o.name = 'FK_TB_DETAL_FK_DTRANS_TB_TRANS')
alter table TB_DETALLES_TRANSACCION
   drop constraint FK_TB_DETAL_FK_DTRANS_TB_TRANS
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
   where r.fkeyid = object_id('TB_TRANSACCION') and o.name = 'FK_TB_TRANS_FK_TRANSA_TB_CLIEN')
alter table TB_TRANSACCION
   drop constraint FK_TB_TRANS_FK_TRANSA_TB_CLIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_TRANSACCION') and o.name = 'FK_TB_TRANS_FK_TRANSA_TB_PROVE')
alter table TB_TRANSACCION
   drop constraint FK_TB_TRANS_FK_TRANSA_TB_PROVE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TB_TRANSACCION') and o.name = 'FK_TB_TRANS_FK_USUARI_TB_USUAR')
alter table TB_TRANSACCION
   drop constraint FK_TB_TRANS_FK_USUARI_TB_USUAR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TB_CLIENTE')
            and   type = 'U')
   drop table TB_CLIENTE
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
           where  id = object_id('TB_PROVEEDOR')
            and   type = 'U')
   drop table TB_PROVEEDOR
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
            and   name  = 'FK_TRANSACCION_PROVEEDOR_FK'
            and   indid > 0
            and   indid < 255)
   drop index TB_TRANSACCION.FK_TRANSACCION_PROVEEDOR_FK
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
/* Table: TB_CLIENTE                                            */
/*==============================================================*/
create table TB_CLIENTE (
   CLIENTEID            int                  not null,
   CEDULA_RUC           numeric(13)          not null,
   NOMBRE               varchar(50)          not null,
   APELLIDO             varchar(50)          not null,
   DIRECCION            text                 not null,
   constraint PK_TB_CLIENTE primary key nonclustered (CLIENTEID)
)
go

/*==============================================================*/
/* Table: TB_DETALLES_TRANSACCION                               */
/*==============================================================*/
create table TB_DETALLES_TRANSACCION (
   DETALLETRANSACCIONID int                  not null,
   TRANSACCIONID        int                  null,
   DESCRIPCION          text                 not null,
   PRECIOUNIDAD         money                not null,
   constraint PK_TB_DETALLES_TRANSACCION primary key nonclustered (DETALLETRANSACCIONID)
)
go

/*==============================================================*/
/* Index: FK_DTRANSACCIOON_FK                                   */
/*==============================================================*/
create index FK_DTRANSACCIOON_FK on TB_DETALLES_TRANSACCION (
TRANSACCIONID ASC
)
go

/*==============================================================*/
/* Table: TB_ITEM_TRANSACCION                                   */
/*==============================================================*/
create table TB_ITEM_TRANSACCION (
   ITEMTRANSACCIONID    int                  not null,
   DETALLETRANSACCIONID int                  not null,
   ITEMID               int                  not null,
   constraint PK_TB_ITEM_TRANSACCION primary key nonclustered (ITEMTRANSACCIONID)
)
go

/*==============================================================*/
/* Index: TB_ITEM_TRANSACCION2_FK                               */
/*==============================================================*/
create index TB_ITEM_TRANSACCION2_FK on TB_ITEM_TRANSACCION (
ITEMID ASC
)
go

/*==============================================================*/
/* Index: FK_ITRANSACCION_DTRANSACCION_FK                       */
/*==============================================================*/
create index FK_ITRANSACCION_DTRANSACCION_FK on TB_ITEM_TRANSACCION (
DETALLETRANSACCIONID ASC
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_ASIENTO                                */
/*==============================================================*/
create table TB_PLANCUENTAS_ASIENTO (
   ASIENTOID2           int                  not null,
   SUBGRUPOID           int                  null,
   NUMEROIASIENTO       char(10)             not null,
   NOMBREASIENTO        char(90)             null,
   constraint PK_TB_PLANCUENTAS_ASIENTO primary key nonclustered (ASIENTOID2)
)
go

/*==============================================================*/
/* Index: FK_CASIENTO_CSUBGRUPO_FK                              */
/*==============================================================*/
create index FK_CASIENTO_CSUBGRUPO_FK on TB_PLANCUENTAS_ASIENTO (
SUBGRUPOID ASC
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_GRUPO                                  */
/*==============================================================*/
create table TB_PLANCUENTAS_GRUPO (
   PLANCUENTASID        int                  not null,
   CODIGOGRUPO          numeric(1)           not null,
   TIPO                 varchar(31)          not null,
   constraint PK_TB_PLANCUENTAS_GRUPO primary key nonclustered (PLANCUENTASID)
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_ITEM                                   */
/*==============================================================*/
create table TB_PLANCUENTAS_ITEM (
   ITEMID               int                  not null,
   ASIENTOID2           int                  null,
   NUMEROITEM           char(14)             not null,
   NOMBREITEM           char(85)             not null,
   constraint PK_TB_PLANCUENTAS_ITEM primary key nonclustered (ITEMID)
)
go

/*==============================================================*/
/* Index: FK_CITEM_CASIENTO_FK                                  */
/*==============================================================*/
create index FK_CITEM_CASIENTO_FK on TB_PLANCUENTAS_ITEM (
ASIENTOID2 ASC
)
go

/*==============================================================*/
/* Table: TB_PLANCUENTAS_SUBGRUPO                               */
/*==============================================================*/
create table TB_PLANCUENTAS_SUBGRUPO (
   SUBGRUPOID           int                  not null,
   PLANCUENTASID        int                  null,
   CODIGOSUBGRUPO       char(4)              not null,
   NOMBRESUBGRUPO       char(65)             not null,
   constraint PK_TB_PLANCUENTAS_SUBGRUPO primary key nonclustered (SUBGRUPOID)
)
go

/*==============================================================*/
/* Index: FK_CSUBGRUPO_CGRUPO_FK                                */
/*==============================================================*/
create index FK_CSUBGRUPO_CGRUPO_FK on TB_PLANCUENTAS_SUBGRUPO (
PLANCUENTASID ASC
)
go

/*==============================================================*/
/* Table: TB_PROVEEDOR                                          */
/*==============================================================*/
create table TB_PROVEEDOR (
   PROVEEDORID          int                  not null,
   CEDULA_RUC           numeric(13)          not null,
   NOMBRE               varchar(50)          not null,
   APELLIDO             varchar(50)          not null,
   DIRECCION            text                 not null,
   constraint PK_TB_PROVEEDOR primary key nonclustered (PROVEEDORID)
)
go

/*==============================================================*/
/* Table: TB_TRANSACCION                                        */
/*==============================================================*/
create table TB_TRANSACCION (
   TRANSACCIONID        int                  not null,
   USUARIOID            int                  null,
   CLIENTEID            int                  null,
   PROVEEDORID          int                  null,
   DESCRIPCION          text                 not null,
   TIPO                 text                 not null,
   FECHA_               datetime             not null,
   AUTORIZACION         text                 not null,
   constraint PK_TB_TRANSACCION primary key nonclustered (TRANSACCIONID)
)
go

/*==============================================================*/
/* Index: FK_TRANSACCION_CLIENTE_FK                             */
/*==============================================================*/
create index FK_TRANSACCION_CLIENTE_FK on TB_TRANSACCION (
CLIENTEID ASC
)
go

/*==============================================================*/
/* Index: FK_TRANSACCION_PROVEEDOR_FK                           */
/*==============================================================*/
create index FK_TRANSACCION_PROVEEDOR_FK on TB_TRANSACCION (
PROVEEDORID ASC
)
go

/*==============================================================*/
/* Index: FK_USUARIO_TRANSACCION_FK                             */
/*==============================================================*/
create index FK_USUARIO_TRANSACCION_FK on TB_TRANSACCION (
USUARIOID ASC
)
go

/*==============================================================*/
/* Table: TB_USUARIO                                            */
/*==============================================================*/
create table TB_USUARIO (
   USUARIOID            int                  not null,
   NOMBRE               varchar(50)          not null,
   APELLIDO             varchar(50)          not null,
   DIRECCION            text                 not null,
   CORREO               varchar(30)          not null,
   FOTO                 image                null,
   NOMBRE_USUARIO       varchar(20)          null,
   CONTRASENIA_USUARIO  varchar(50)          null,
   constraint PK_TB_USUARIO primary key nonclustered (USUARIOID)
)
go

alter table TB_DETALLES_TRANSACCION
   add constraint FK_TB_DETAL_FK_DTRANS_TB_TRANS foreign key (TRANSACCIONID)
      references TB_TRANSACCION (TRANSACCIONID)
go

alter table TB_ITEM_TRANSACCION
   add constraint FK_TB_ITEM__FK_ITRANS_TB_DETAL foreign key (DETALLETRANSACCIONID)
      references TB_DETALLES_TRANSACCION (DETALLETRANSACCIONID)
go

alter table TB_ITEM_TRANSACCION
   add constraint FK_TB_ITEM__TB_ITEM_T_TB_PLANC foreign key (ITEMID)
      references TB_PLANCUENTAS_ITEM (ITEMID)
go

alter table TB_PLANCUENTAS_ASIENTO
   add constraint FK_TB_PLANC_FK_CASIEN_TB_PLANC foreign key (SUBGRUPOID)
      references TB_PLANCUENTAS_SUBGRUPO (SUBGRUPOID)
go

alter table TB_PLANCUENTAS_ITEM
   add constraint FK_TB_PLANC_FK_CITEM__TB_PLANC foreign key (ASIENTOID2)
      references TB_PLANCUENTAS_ASIENTO (ASIENTOID2)
go

alter table TB_PLANCUENTAS_SUBGRUPO
   add constraint FK_TB_PLANC_FK_CSUBGR_TB_PLANC foreign key (PLANCUENTASID)
      references TB_PLANCUENTAS_GRUPO (PLANCUENTASID)
go

alter table TB_TRANSACCION
   add constraint FK_TB_TRANS_FK_TRANSA_TB_CLIEN foreign key (CLIENTEID)
      references TB_CLIENTE (CLIENTEID)
go

alter table TB_TRANSACCION
   add constraint FK_TB_TRANS_FK_TRANSA_TB_PROVE foreign key (PROVEEDORID)
      references TB_PROVEEDOR (PROVEEDORID)
go

alter table TB_TRANSACCION
   add constraint FK_TB_TRANS_FK_USUARI_TB_USUAR foreign key (USUARIOID)
      references TB_USUARIO (USUARIOID)
go

