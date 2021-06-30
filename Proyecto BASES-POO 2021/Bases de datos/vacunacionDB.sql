DROP DATABASE vacunacionDB;
CREATE DATABASE vacunacionDB;
USE vacunacionDB;
SET LANGUAGE us_english;

CREATE TABLE TIPO_EMPLEADO (
id_tipo_empleado INT PRIMARY KEY IDENTITY,
tipo VARCHAR(30) NOT NULL,
descripcion VARCHAR(50) NOT NULL
);

CREATE TABLE EMPLEADO (
id_empleado INT PRIMARY KEY IDENTITY,
nombre VARCHAR(50) NOT NULL,
contrasenia VARCHAR(30) NOT NULL,
correo_institucional VARCHAR(30) NOT NULL,
direccion VARCHAR(60) NOT NULL,
id_tipo_empleado INT NULL
);

CREATE TABLE CABINA (
id_cabina INT PRIMARY KEY IDENTITY,
direccion VARCHAR(80) NOT NULL,
telefono INT NOT NULL UNIQUE,
correo VARCHAR(50) NOT NULL,
id_empleado INT NULL
);

CREATE TABLE REGISTRO_EMPLEADO (
id_registro INT PRIMARY KEY IDENTITY,
fecha DATETIME NOT NULL,
id_empleado INT NULL,
id_cabina INT NULL
);

CREATE TABLE INSTITUCION (
id_institucion INT PRIMARY KEY IDENTITY,
institucion VARCHAR(50) NOT NULL
);

CREATE TABLE CIUDADANO (
dui INT PRIMARY KEY,
edad INT NOT NULL,
correo_electronico VARCHAR(30) NOT NULL,
direccion VARCHAR(50) NOT NULL,
telefono INT NOT NULL UNIQUE,
id_institucion INT NULL
);

CREATE TABLE CITA (
id_cita INT PRIMARY KEY IDENTITY,
fecha DATETIME NOT NULL,
tipo_vacuna BIT NOT NULL,
id_empleado INT NULL,
dui_ciudadano INT NULL
);

CREATE TABLE PROCESO_VACUNACION (
id_proceso INT PRIMARY KEY IDENTITY,
fecha_hora DATETIME NOT NULL,
dui_ciudadano INT NULL,
id_empleado INT NULL
);

CREATE TABLE ENFERMEDADES (
id_enfermedades INT PRIMARY KEY IDENTITY,
enfermedades_cronicas VARCHAR(50) NOT NULL
);

CREATE TABLE ENFERMEDADESXCIUDADANO (
id_enfermedades INT NOT NULL,
dui_ciudadano INT NOT NULL,
CONSTRAINT pk_ENFERMEDADESXCIUDADANO PRIMARY KEY (id_enfermedades, dui_ciudadano)
);

CREATE TABLE SINTOMAS (
id_sintoma INT PRIMARY KEY IDENTITY,
sintoma VARCHAR(30) NOT NULL,
descripcion VARCHAR(60) NOT NULL
);

CREATE TABLE SINTOMASXCIUDADANO (
id_sintoma INT NOT NULL,
dui_ciudadano INT NOT NULL,
CONSTRAINT pk_SINTOMASXCIUDADANO PRIMARY KEY (id_sintoma, dui_ciudadano)
);

------------------------------------------------
-- FOREIGN KEY
------------------------------------------------
-- TIPO_EMPLEADO -> EMPLEADO
ALTER TABLE EMPLEADO ADD FOREIGN KEY (id_tipo_empleado) REFERENCES TIPO_EMPLEADO (id_tipo_empleado) ON DELETE SET NULL;
-- EMPLEADO -> REGISTRO_EMPLEADO
ALTER TABLE REGISTRO_EMPLEADO ADD FOREIGN KEY (id_empleado) REFERENCES EMPLEADO (id_empleado) ON DELETE SET NULL;
-- EMPLEADO -> CABINA
ALTER TABLE CABINA ADD FOREIGN KEY (id_empleado) REFERENCES EMPLEADO (id_empleado) ON DELETE SET NULL;
-- CABINA -> REGISTRO_EMPLEADO
ALTER TABLE REGISTRO_EMPLEADO ADD FOREIGN KEY (id_cabina) REFERENCES CABINA (id_cabina) ON DELETE SET NULL;
-- INSTITUCION -> CIUDADANO
ALTER TABLE CIUDADANO ADD FOREIGN KEY (id_institucion) REFERENCES INSTITUCION (id_institucion) ON DELETE SET NULL;
-- EMPLEADO -> CITA
ALTER TABLE CITA ADD FOREIGN KEY (id_empleado) REFERENCES EMPLEADO (id_empleado) ON DELETE SET NULL;
-- CIUDADANO -> CITA
ALTER TABLE CITA ADD FOREIGN KEY (dui_ciudadano) REFERENCES CIUDADANO (dui) ON DELETE SET NULL;
-- EMPLEADO -> PROCESO_VACUNACION
ALTER TABLE PROCESO_VACUNACION ADD FOREIGN KEY (id_empleado) REFERENCES EMPLEADO (id_empleado) ON DELETE SET NULL;
-- CIUDADANO -> PROCESO_VACUNACION
ALTER TABLE PROCESO_VACUNACION ADD FOREIGN KEY (dui_ciudadano) REFERENCES CIUDADANO (dui) ON DELETE SET NULL;
-- CIUDADANO -> ENFERMEDADESXCIUDADANO
ALTER TABLE ENFERMEDADESXCIUDADANO ADD FOREIGN KEY (dui_ciudadano) REFERENCES CIUDADANO (dui);
-- ENFERMEDADES -> ENFERMEDADESXCIUDADANO
ALTER TABLE ENFERMEDADESXCIUDADANO ADD FOREIGN KEY (id_enfermedades) REFERENCES ENFERMEDADES (id_enfermedades);
-- CIUDADANO -> SINTOMASXCIUDADANO
ALTER TABLE SINTOMASXCIUDADANO ADD FOREIGN KEY (dui_ciudadano) REFERENCES CIUDADANO (dui);
-- SINTOMAS -> SINTOMASXCIUDADANO
ALTER TABLE SINTOMASXCIUDADANO ADD FOREIGN KEY (id_sintoma) REFERENCES SINTOMAS (id_sintoma);

INSERT INTO TIPO_EMPLEADO VALUES ('Enfermera', 'Atender');
INSERT INTO TIPO_EMPLEADO VALUES ('Doctor', 'Vacunar');
INSERT INTO TIPO_EMPLEADO VALUES ('Guia','Guiar');
-----------------------------------------------------------------------------------------

INSERT INTO EMPLEADO VALUES ('Carlos', '123', 'asd@gmail.com', 'san salvador', 1)
INSERT INTO EMPLEADO VALUES ('Luis', '123', 'luis@gmail.com', 'santa ana', 2);
INSERT INTO EMPLEADO VALUES ('Ernesto', '123', 'ernesto@gmail.com', 'santa tecla', 3);
INSERT INTO EMPLEADO VALUES ('Laura', '123', 'laura@gmail.com', 'san marcos', 1);
INSERT INTO EMPLEADO VALUES ('Marcela', '123', 'marcela@gmail.com', 'el tunco', 2);
-----------------------------------------------------------------------------------------

INSERT INTO INSTITUCION VALUES ('Gobierno');
INSERT INTO INSTITUCION VALUES ('PNC');
INSERT INTO INSTITUCION VALUES ('Educacion');
-------------------------------------------------------------------------------
INSERT INTO CIUDADANO VALUES (123456789, 70, 'ama@gmail.com', 'Colonia Miguel', '7646444',1);
INSERT INTO CIUDADANO VALUES (236475899, 65, 'mixtas@gmail.com','San Salvador','889767',2 );
INSERT INTO CIUDADANO VALUES (564738297, 61, 'link@gmail.com','Mostoles','240782',3 );
-------------------------------------------------------------------------------
INSERT INTO CABINA VALUES ('San  Jacinto','25252525','askl@cabina.com',1);
INSERT INTO CABINA VALUES ('San  Luis','77751880','meresa@cabina.com',2);
INSERT INTO CABINA VALUES ('Calle las Margaritas','2582084','wasers@cabina.com',3);
-------------------------------------------------------------------------------
INSERT INTO REGISTRO_EMPLEADO VALUES ('2021-07-10 14:30:00',1,1);
INSERT INTO REGISTRO_EMPLEADO VALUES ('2020-12-22 09:25:24',2,2);
INSERT INTO REGISTRO_EMPLEADO VALUES ('2020-05-2 11:28:54',3,3);
-------------------------------------------------------------------------------
INSERT INTO CITA VALUES ('2021-04-24 12:45:55',0,1,123456789)
INSERT INTO CITA VALUES ('2021-04-24 04:45:55',0,1,236475899)
-------------------------------------------------------------------------------
INSERT INTO PROCESO_VACUNACION VALUES ('2021-07-10 14:30:00', 123456789, 1);
INSERT INTO PROCESO_VACUNACION VALUES ('2020-12-22 09:25:24', 564738297, 1);
INSERT INTO PROCESO_VACUNACION VALUES ('2021-07-11 14:30:00', 236475899, 1);

--------------------------------------------------------------------------------

INSERT INTO ENFERMEDADES VALUES ('Cáncer');
INSERT INTO ENFERMEDADES VALUES ('Diabetes');
INSERT INTO ENFERMEDADES VALUES ('Alzheimer');
INSERT INTO ENFERMEDADES VALUES ('Artritis');
INSERT INTO ENFERMEDADES VALUES ('Asma');

--------------------------------------------------------------------------------

INSERT INTO ENFERMEDADESXCIUDADANO VALUES (2, 236475899);
INSERT INTO ENFERMEDADESXCIUDADANO VALUES (2, 234567897);

--------------------------------------------------------------------------------

INSERT INTO SINTOMAS VALUES ('Tos','toser');
INSERT INTO SINTOMAS VALUES ('gripe','tener mocos');
INSERT INTO SINTOMAS VALUES ('Calentura','Estar caliente');
