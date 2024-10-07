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

-- Tabla permisos -- 
create table permisos
(
    id_permiso int PRIMARY key auto_increment, 
    fk_id_usuario int, 
    tipo_permiso varchar(100), 
    user varchar(100), 
    pass varchar(255), 
    foreign key (fk_id_usuario) references usuarios (id_usuario)
); 
DESCRIBE permisos; 

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

    declare nuevo_id_usuario int; 

    insert into usuarios (nombre, apellidop, apellidom, fecha_nacimiento, rfc) values 
    (_nombre, _apellidop, _apellidom, _fecha_nacimiento, _rfc);

    set nuevo_id_usuario = last_insert_id(); 

    insert into permisos(fk_id_usuario, tipo_permiso, user, pass) values 
    (nuevo_id_usuario, _tipo_permiso, _user, _pass); 
end;

call p_insertar_usuarios('Jose', 'Perez', 'Prado', '2000-06-11', 'GGTN260813EM2', 'Administrador', 'jose11', sha1('1234'));  
select * from usuarios; 
SELECT * from permisos; 


-- Procedimiento almacenado para modificar usuarios --
drop procedure if exists p_modificar_usuarios; 
CREATE procedure p_modificar_usuarios
(
    in _id_usuario int,
    in _nombre varchar(255), 
    in _apellidop varchar(255), 
    in _apellidom varchar(255), 
    in _fecha_nacimiento date, 
    in _rfc varchar(13), 
    in _tipo_permiso varchar(100), 
    in _user varchar(100), 
    in _pass varchar(255)
)
begin 
    update usuarios set nombre = _nombre, apellidop = _apellidop, apellidom = _apellidom, fecha_nacimiento = _fecha_nacimiento, rfc = _rfc
    where id_usuario = _id_usuario;

    update permisos set tipo_permiso = _tipo_permiso, user = _user, pass = _pass
    where fk_id_usuario = _id_usuario; 
end;  
call p_modificar_usuarios(1, 'Jose', 'Perez', 'Prado', '2000-06-11', 'GGTN260803EM1', 'Empleado', 'jose12', sha1('12345')); 

describe usuarios; 
DESCRIBE permisos; 
 
SELECT * FROM usuarios;
SELECT * from permisos; 

UPDATE permisos set tipo_permiso = 'Administrador', user = 'jose11', pass = sha1('1234'), fk_rfc = 'GGTN26080QQQ'
WHERE id_permiso = 1; 

update usuarios set nombre = 'Jose', apellidop = 'Perez', apellidom = 'Prado', fecha_nacimiento = '2000-06-11', rfc = 'GGTN26080QQQ'
where id_usuario = 8; 

SET FOREIGN_KEY_CHECKS = 0;


-- Procedimiento almacenado para eliminar usuarios --
DROP procedure if exists p_eliminar_usuarios_permisos;
CREATE procedure p_eliminar_usuarios_permisos
(
    in _id_usuario int

)
begin
    delete from permisos
    where fk_id_usuario = _id_usuario;

    delete from usuarios
    where id_usuario = _id_usuario; 
end; 

call p_eliminar_usuarios_permisos(1); 

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