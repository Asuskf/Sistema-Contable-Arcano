/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     29/6/2018 11:23:16                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETALLESTRANSACCION') and o.name = 'FK_DETALLES_FK_DTRANS_TRANSACC')
alter table DETALLESTRANSACCION
   drop constraint FK_DETALLES_FK_DTRANS_TRANSACC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEMTRANSACCION') and o.name = 'FK_ITEMTRAN_FK_TRANSA_DETALLES')
alter table ITEMTRANSACCION
   drop constraint FK_ITEMTRAN_FK_TRANSA_DETALLES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEMTRANSACCION') and o.name = 'FK_ITEMTRAN_RELATIONS_PLANCUEN')
alter table ITEMTRANSACCION
   drop constraint FK_ITEMTRAN_RELATIONS_PLANCUEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLANCUENTASASIENTO') and o.name = 'FK_PLANCUEN_FK_CASIEN_PLANCUEN')
alter table PLANCUENTASASIENTO
   drop constraint FK_PLANCUEN_FK_CASIEN_PLANCUEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLANCUENTASITEM') and o.name = 'FK_PLANCUEN_FK_CITEM__PLANCUEN')
alter table PLANCUENTASITEM
   drop constraint FK_PLANCUEN_FK_CITEM__PLANCUEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PLANCUENTASSUBGRUPO') and o.name = 'FK_PLANCUEN_FK_CSUBGR_PLANCUEN')
alter table PLANCUENTASSUBGRUPO
   drop constraint FK_PLANCUEN_FK_CSUBGR_PLANCUEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_FK_TRANSA_CLIENTE')
alter table TRANSACCION
   drop constraint FK_TRANSACC_FK_TRANSA_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_FK_TRANSA_PROVEEDO')
alter table TRANSACCION
   drop constraint FK_TRANSACC_FK_TRANSA_PROVEEDO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRANSACCION') and o.name = 'FK_TRANSACC_FK_USUARI_USUARIO')
alter table TRANSACCION
   drop constraint FK_TRANSACC_FK_USUARI_USUARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETALLESTRANSACCION')
            and   type = 'U')
   drop table DETALLESTRANSACCION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ITEMTRANSACCION')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEMTRANSACCION.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ITEMTRANSACCION')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEMTRANSACCION.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMTRANSACCION')
            and   type = 'U')
   drop table ITEMTRANSACCION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PLANCUENTASASIENTO')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PLANCUENTASASIENTO.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PLANCUENTASASIENTO')
            and   type = 'U')
   drop table PLANCUENTASASIENTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PLANCUENTASGRUPO')
            and   type = 'U')
   drop table PLANCUENTASGRUPO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PLANCUENTASITEM')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index PLANCUENTASITEM.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PLANCUENTASITEM')
            and   type = 'U')
   drop table PLANCUENTASITEM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PLANCUENTASSUBGRUPO')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index PLANCUENTASSUBGRUPO.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PLANCUENTASSUBGRUPO')
            and   type = 'U')
   drop table PLANCUENTASSUBGRUPO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROVEEDOR')
            and   type = 'U')
   drop table PROVEEDOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSACCION')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSACCION.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSACCION')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSACCION.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRANSACCION')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRANSACCION.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRANSACCION')
            and   type = 'U')
   drop table TRANSACCION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   CLIENTEID            int                  not null,
   CEDULA_RUC           numeric(13)          not null,
   NOMBRE               text                 not null,
   APELLIDO             text                 not null,
   DIRECCION            text                 not null,
   constraint PK_CLIENTE primary key nonclustered (CLIENTEID)
)
go

/*==============================================================*/
/* Table: DETALLESTRANSACCION                                   */
/*==============================================================*/
create table DETALLESTRANSACCION (
   DETALLETRANSACCIONID int                  not null,
   TRANSACCIONID        int                  null,
   DESCIPCION           text                 not null,
   PRECIOUNIDAD         money                not null,
   constraint PK_DETALLESTRANSACCION primary key nonclustered (DETALLETRANSACCIONID)
)
go

/*==============================================================*/
/* Table: ITEMTRANSACCION                                       */
/*==============================================================*/
create table ITEMTRANSACCION (
   DETALLETRANSACCIONID int                  not null,
   ITEMID               int                  not null,
   constraint PK_ITEMTRANSACCION primary key nonclustered (DETALLETRANSACCIONID, ITEMID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on ITEMTRANSACCION (
ITEMID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on ITEMTRANSACCION (
DETALLETRANSACCIONID ASC
)
go

/*==============================================================*/
/* Table: PLANCUENTASASIENTO                                    */
/*==============================================================*/
create table PLANCUENTASASIENTO (
   ASIENTOID2           int                  not null,
   SUBGRUPOID           int                  null,
   NUMEROIASIENTO       text                 not null,
   NOMBREASIENTO        text                 null,
   constraint PK_PLANCUENTASASIENTO primary key nonclustered (ASIENTOID2)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on PLANCUENTASASIENTO (
SUBGRUPOID ASC
)
go

/*==============================================================*/
/* Table: PLANCUENTASGRUPO                                      */
/*==============================================================*/
create table PLANCUENTASGRUPO (
   PLANCUENTASID        int                  not null,
   CODIGOGRUPO          numeric(2)           not null,
   TIPO                 text                 not null,
   constraint PK_PLANCUENTASGRUPO primary key nonclustered (PLANCUENTASID)
)
go

/*==============================================================*/
/* Table: PLANCUENTASITEM                                       */
/*==============================================================*/
create table PLANCUENTASITEM (
   ITEMID               int                  not null,
   ASIENTOID2           int                  null,
   NUMEROITEM           text                 not null,
   NOMBREITEM           text                 not null,
   constraint PK_PLANCUENTASITEM primary key nonclustered (ITEMID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on PLANCUENTASITEM (
ASIENTOID2 ASC
)
go

/*==============================================================*/
/* Table: PLANCUENTASSUBGRUPO                                   */
/*==============================================================*/
create table PLANCUENTASSUBGRUPO (
   SUBGRUPOID           int                  not null,
   PLANCUENTASID        int                  null,
   CODIGOSUBGRUPO       text                 not null,
   NOMBRESUBGRUPO       text                 not null,
   constraint PK_PLANCUENTASSUBGRUPO primary key nonclustered (SUBGRUPOID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on PLANCUENTASSUBGRUPO (
PLANCUENTASID ASC
)
go

/*==============================================================*/
/* Table: PROVEEDOR                                             */
/*==============================================================*/
create table PROVEEDOR (
   CLIENTEID2           int                  not null,
   CEDULA_RUC           numeric(13)          not null,
   NOMBRE               text                 not null,
   APELLIDO             text                 not null,
   DIRECCION            text                 not null,
   constraint PK_PROVEEDOR primary key nonclustered (CLIENTEID2)
)
go

/*==============================================================*/
/* Table: TRANSACCION                                           */
/*==============================================================*/
create table TRANSACCION (
   TRANSACCIONID        int                  not null,
   CLIENTEID2           int                  null,
   CLIENTEID3           int                  null,
   CLIENTEID            int                  null,
   DESCRIPCION          text                 not null,
   TIPO                 text                 not null,
   FECHA_               datetime             not null,
   AUTORIZACION         text                 not null,
   constraint PK_TRANSACCION primary key nonclustered (TRANSACCIONID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on TRANSACCION (
CLIENTEID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on TRANSACCION (
CLIENTEID2 ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_8_FK on TRANSACCION (
CLIENTEID3 ASC
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   CLIENTEID3           int                  not null,
   NOMBRE               text                 not null,
   APELLIDO             text                 not null,
   DIRECCION            text                 not null,
   CORREO               text                 not null,
   FOTO                 image                null,
   constraint PK_USUARIO primary key nonclustered (CLIENTEID3)
)
go

alter table DETALLESTRANSACCION
   add constraint FK_DETALLES_FK_DTRANS_TRANSACC foreign key (TRANSACCIONID)
      references TRANSACCION (TRANSACCIONID)
go

alter table ITEMTRANSACCION
   add constraint FK_ITEMTRAN_FK_TRANSA_DETALLES foreign key (DETALLETRANSACCIONID)
      references DETALLESTRANSACCION (DETALLETRANSACCIONID)
go

alter table ITEMTRANSACCION
   add constraint FK_ITEMTRAN_RELATIONS_PLANCUEN foreign key (ITEMID)
      references PLANCUENTASITEM (ITEMID)
go

alter table PLANCUENTASASIENTO
   add constraint FK_PLANCUEN_FK_CASIEN_PLANCUEN foreign key (SUBGRUPOID)
      references PLANCUENTASSUBGRUPO (SUBGRUPOID)
go

alter table PLANCUENTASITEM
   add constraint FK_PLANCUEN_FK_CITEM__PLANCUEN foreign key (ASIENTOID2)
      references PLANCUENTASASIENTO (ASIENTOID2)
go

alter table PLANCUENTASSUBGRUPO
   add constraint FK_PLANCUEN_FK_CSUBGR_PLANCUEN foreign key (PLANCUENTASID)
      references PLANCUENTASGRUPO (PLANCUENTASID)
go

alter table TRANSACCION
   add constraint FK_TRANSACC_FK_TRANSA_CLIENTE foreign key (CLIENTEID)
      references CLIENTE (CLIENTEID)
go

alter table TRANSACCION
   add constraint FK_TRANSACC_FK_TRANSA_PROVEEDO foreign key (CLIENTEID2)
      references PROVEEDOR (CLIENTEID2)
go

alter table TRANSACCION
   add constraint FK_TRANSACC_FK_USUARI_USUARIO foreign key (CLIENTEID3)
      references USUARIO (CLIENTEID3)
go

