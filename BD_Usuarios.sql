-- Tabla de usuarios --
create table usuarios
(
    id_usuario int PRIMARY key auto_increment, 
    nombre VARCHAR(255), 
    apellidop varchar(255),
    apellidom varchar(255), 
    fecha_nacimiento DATE,
    rfc VARCHAR(13)
);

-- Modificacion a la tabla de usuarios --
alter table usuarios
add unique (rfc); 

-- Verificar que se haya hecho el cambio en la tabla usuarios --
describe usuarios; 

-- Tabla de permisos --
create table permisos
(
    id_permiso int PRIMARY key auto_increment,
    tipo_permiso varchar(100),
    fk_id_usuario int, 
    foreign key (fk_id_usuario) references usuarios (id_usuario)
); 

-- Modificaciones a la tabla de permisos --
ALTER table permisos
add column user varchar(100);

alter table permisos 
add column pass varchar(20);

ALTER table permisos
modify column pass varchar(255); 

ALTER TABLE permisos DROP FOREIGN KEY permisos_ibfk_1;

alter table permisos
drop column fk_id_usuario;

alter table permisos 
add column fk_rfc varchar(13); 

ALTER table permisos 
add foreign key (fk_rfc) references usuarios (rfc); 

-- Verificar que las modificaciones si se hicieron --
describe permisos; 

/* Hacemos un insercion de datos para poder usar las dos tablas para 
ver el funcionamientod*/
call p_insertar_usuarios('Jose', 'Perez', 'Prado', '2000-06-11', 'GGTN260803EM5');  
insert into permisos values (null, 'Administrador', 'jose11', sha1('1234'), 'GGTN260803EM5');
SELECT * from permisos; 

-- Tabla de refacciones --
create table refacciones
(
    codigo_barras VARCHAR(25) PRIMARY key, 
    nombre varchar(255), 
    descripcion varchar(255),
    marca varchar(255)
);
-- Tabla taller --
CREATE table taller
(
    Codigo_herramienta varchar(25) PRIMARY KEY,
    nombre varchar(255), 
    medida float,
    marca varchar(255),
    descripcion varchar(255)
);

-- MODIFICACION --
ALTER table taller
modify column medida varchar(10); 

-- Procedimiento almacenado para insertar usuarios --
-- Otras modificaciones --
drop procedure if exists p_insertar_usuarios; 
CREATE procedure p_insertar_usuarios
(
    in _nombre varchar(255),
    in _apellidop varchar(255),
    in _apellidom varchar(255), 
    in _fecha_nacimiento DATE,
    in _rfc VARCHAR(13),
    in _tipo_permiso varchar(100), 
    in _user varchar(100), 
    in _pass varchar(255)
)
begin 
    insert into usuarios (nombre, apellidop, apellidom, fecha_nacimiento, rfc) values 
    (_nombre, _apellidop, _apellidom, _fecha_nacimiento, _rfc);
    
    insert into permisos(tipo_permiso, user, pass, fk_rfc) values 
    (_tipo_permiso, _user, _pass, _rfc); 
end;

call p_insertar_usuarios('Jose', 'Perez', 'Prado', '2000-06-11', 'GGTN260803EM1', 'Administrador', 'jose11', sha1('1234'));  
select * from usuarios; 
SELECT * from permisos; 

-- Procedimiento almacenado para modificar usuarios --
drop procedure if exists p_modificar_usuarios; 
create procedure p_modificar_usuarios
(
    in _id_usuario int, 
    in _nombre varchar(255),
    in _apellidop varchar(255),
    in _apellidom varchar(255), 
    in _fecha_nacimiento DATE,
    in _tipo_permiso varchar(100), 
    in _user varchar(100), 
    in _pass varchar(255),
    in _rfc_actual VARCHAR(13), 
    in _rfc_nuevo varchar(13) 
)
begin
    update usuarios set nombre = _nombre, apellidop = _apellidop, apellidom = _apellidom, fecha_nacimiento = _fecha_nacimiento, rfc = _rfc_nuevo
    where id_usuario = _id_usuario;
        -- MODIFICACION --
    UPDATE permisos set fk_rfc = _rfc_nuevo
    where fk_rfc = _rfc_actual;
end; 

call p_modificar_usuarios(7, 'Jose', 'Perez', 'Prado', '2000-06-11', 'Empleado', 'jose11', sha1('12345'), 'GGTN260803EM1', 'GGTN260803EE1'); 


call p_modificar_usuarios(8, 'Jose', 'Perez', 'Prado', '2000-06-11', 'Administrador', 'jose11', sha1('12345'), 'GGTN260803EM1', 'GGTN260803EN2'); 
SELECT * FROM usuarios;
SELECT * from permisos;

SELECT * FROM permisos WHERE fk_rfc = 'GGTN260803EM1';

-- Procedimiento almacenado para eliminar usuarios --
--MODIFICACIONES IMPORTANTES AL PROCEDIMIENTO --
DROP procedure if exists p_eliminar_usuarios_permisos;
CREATE procedure p_eliminar_usuarios_permisos
(
    in _id_usuario int,
    in _id_permiso int
)
begin
    delete from permisos
    where id_permiso = _id_permiso; 

    delete from usuarios
    where id_usuario = _id_usuario; 
end; 

-- Prueba de funcionamiento --
call p_eliminar_usuarios_permisos(6, null); 



-- NOTA IMPORTANTE --

/*Para poder eliminar un registro de la tabla de usuarios, se 
tiene que eliminar primero de la tabla de permisos
ese orden es muy importante*/
delete from permisos
where id_permiso = 1; 
call p_eliminar_usuarios(2); 
select * from usuarios;
SELECT * from permisos; 

-- Procedimiento almacenado para insertar en la tabla de refacciones --
create procedure p_insertar_refacciones
(
    in _codigo_barras varchar(25),
    in _nombre varchar(255), 
    in _descripcion varchar(255), 
    in _marca varchar(255)
)
begin
    insert into refacciones (codigo_barras, nombre, descripcion, marca) values 
    (_codigo_barras, _nombre, _descripcion, _marca); 
end; 

call p_insertar_refacciones('po3iu4djfhals', 'Bomba de agua', 'Bomba de agua para sedan', 'Toyota'); 

-- Procedimiento almacenado para modificar en la tabla de refacciones -- 
CREATE procedure p_modificar_refacciones
(
    in _codigo_barras varchar(25),
    in _nombre varchar(255), 
    in _descripcion varchar(255), 
    in _marca varchar(255)
)
begin
    update refacciones set nombre = _nombre, descripcion = _descripcion, marca = _marca
    where codigo_barras = _codigo_barras; 
end; 

call p_modificar_refacciones('po3iu4djfhals', 'Bomba de gasolina', 'Una bomba de gasolita para una Pick-UP', 'Ford'); 

SELECT * from refacciones; 

-- Procedimiento almacenado para eliminar refacciones en la tabla --
drop procedure if exists p_eliminar_refacciones; 
create procedure p_eliminar_refacciones
(
    in _codigo_barras varchar(25)
)
begin 
    delete from refacciones 
    where codigo_barras = _codigo_barras; 
end; 

call p_eliminar_refacciones('po3iu4djfhals'); 

-- Procedimiento almacenado para ingresar herramientas en la tabla --
drop procedure if exists p_insertar_herramienta; 
CREATE procedure p_insertar_herramienta
(
    in _Codigo_herramienta varchar(25), 
    in _nombre varchar(255), 
    in _medida varchar(10), 
    in _marca varchar(255), 
    in _descripcion  varchar(255)
)
begin 
    insert into taller (Codigo_herramienta, nombre, medida, marca, descripcion) values 
    (_Codigo_herramienta, _nombre, _medida, _marca, _descripcion);
end; 

call p_insertar_herramienta('134208967', 'Matraca', '3/4', 'Craftman', 'Matraca perrona'); 

SELECT * from taller; 

-- Procedimiento almacenado para modificar herramientas en la tabla --
drop procedure if exists p_modificar_herramienta;
CREATE procedure p_modificar_herramienta
(
    in _Codigo_herramienta varchar(25), 
    in _nombre varchar(255), 
    in _medida varchar(10), 
    in _marca varchar(255), 
    in _descripcion  varchar(255)
)
begin 
    update taller set nombre = _nombre, medida = _medida, marca = _marca, descripcion = _descripcion
    where Codigo_herramienta = _Codigo_herramienta;
end;  

call p_modificar_herramienta('134208967', 'Taladro', '10pul', 'Makita', 'Taladro perron');

-- Procedimiento almacenado para eliminar herramientas de la tabla --
CREATE procedure p_eliminar_herramienta
(
    in _Codigo_herramienta varchar(25)
)
begin 
    delete  from taller
    where Codigo_herramienta = _Codigo_herramienta;
end;

call p_eliminar_herramienta('134208967'); 