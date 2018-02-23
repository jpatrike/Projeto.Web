create table usuario(
 codigo         int identity(1,1) PRIMARY KEY,
 nome           nvarchar(50) NOT NULL,
 logon          nvarchar(12) NOT NULL unique,
 senha          nvarchar(50) NOT NULL,
 ultimo_acesso  datetime,
 qtd_erro_login integer,
 bl_ativo       integer,
 );