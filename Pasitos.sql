
CREATE DATABASE CARIDAD

USE CARIDAD

CREATE TABLE Donante
(
ID_Donante int not null,
Nombre_Don varchar(50),
Tipo_Don varchar(50),
Contacto1 int not null,
Contacto2 int,
Direccion_Don varchar(50),
RFC_Don varchar(50),
Info_Don varchar(100)
PRIMARY KEY(ID_Donante),
FOREIGN KEY(Contacto1) REFERENCES Contacto(ID_Contacto),
FOREIGN KEY(Contacto2) REFERENCES Contacto(ID_Contacto)
)


CREATE TABLE Contacto
(
ID_Contacto int not null,
Nombre_Con varchar(50) not null,
Tel_Con int not null,
Correo_Con varchar(50),
Puesto_Con varchar(50),
Cumpleaños_Con date,
Hora_Atencion varchar,
Info_Con varchar(100)
PRIMARY KEY(ID_Contacto)
)

CREATE TABLE Beneficiario
(
ID_Beneficiario int not null,
Nombre_Ben varchar(50) not null,
Edad_Ben int,
Genero_Ben char(6),
Padecimiento_Ben varchar(50),
Necesidad_Ben varchar(50),
PRIMARY KEY(ID_Beneficiario)
)

CREATE TABLE Donativo
(
ID_Donativo int not null,
ID_Donante int not null,
Tipo_Donativo varchar(50),
Fecha_inicio smalldatetime,
Periodicidad varchar(50),
Don_monetario money,
Forma_pago varchar(50),
ID_beneficiario int not null,
Uso varchar(50),
Estado varchar(50),
PRIMARY KEY(ID_Donativo),
FOREIGN KEY(ID_Donante) REFERENCES Donante(ID_Donante),
FOREIGN KEY(ID_Beneficiario) REFERENCES Beneficiario(ID_Beneficiario),
)

CREATE TABLE RegistroDonativo
(
ID_Registro int not null,
ID_Donativo int not null,
Estado varchar(50),
Fecha smalldatetime,
Comentario varchar(100),
PRIMARY KEY(ID_Registro),
FOREIGN KEY(ID_Donativo) REFERENCES Donativo(ID_Donativo),
)

CREATE TABLE ComunicacionContacto
(
ID_Comunicacion int not null,
ID_Empleado int not null,
ID_Contacto int not null,
Fecha smalldatetime,
Obsrvaciones  varchar(100),
NuevaCita date,
PRIMARY KEY(ID_Comunicacion),
FOREIGN KEY(ID_Empleado) REFERENCES Empleado(ID_Empleado),
FOREIGN KEY(ID_Contacto) REFERENCES Contacto(ID_Contacto),
)

CREATE TABLE Empleado
(
ID_Empleado int not null,
Nombre_Emp varchar(50),
Puesto_Emp varchar(50),
Horario varchar(50),
PRIMARY KEY(ID_Empleado)
)



SELECT MAX(ID_Donante) FROM Donante

-- Consulta Beneficiario
 Select b.ID_Beneficiario,b.Nombre_Ben,b.Fec_Nac_Ben,g.Genero,b.Padecimiento_Ben,b.Necesidad_Ben From Beneficiario b
 join Genero g on b.ID_Genero_Ben=g.ID_Genero
 
 -- Consulta Contacto
 select d.Nombre_Don,c.ID_Contacto,c.Nombre_Con,c.Tel_Con,c.Correo_Con,c.Puesto_Con,c.Hora_Atencion,c.Info_Con,c.Cumpleaños_Con from Contacto c
inner join Donante d on d.ID_Donante=c.ID_Donante

select * from Contacto

select d.ID_Donante,d.Nombre_Don,t.TipoDon,d.Direccion_Don,d.RFC_Don,d.Info_Don From Donante d join TipoDonante t on t.ID_Tipo_Don=d.ID_Tipo_Don where ID_Estatus=2
 
 select * from Donante 
 
 select * from Tutor
 select * from Beneficiario
  select * from Relaciontutor

CREATE TABLE RelacionTutor
(
ID_Relacion int not null identity(1,1),
ID_Benefiario int,
ID_Tutor int,
PRIMARY KEY (ID_Relacion)
)


SELECT b.ID_Beneficiario,b.Nombre_Ben,b.Fec_Nac_Ben,g.Genero,b.Padecimiento_Ben,b.Necesidad_Ben,* FROM Tutor T
JOIN RELACIONTUTOR R ON T.ID_Tutor=R.ID_Tutor
JOIN Beneficiario B ON R.ID_Benefiario=B.ID_Beneficiario
join genero g on g.ID_Genero=b.ID_Genero_Ben
WHERE B.ID_Beneficiario=9