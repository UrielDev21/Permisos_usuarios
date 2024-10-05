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

-- Procedimiento almacenado para insertar usuarios --
CREATE procedure p_insertar_usuarios
(
    in _nombre varchar(255),
    in _apellidop varchar(255),
    in _apellidom varchar(255), 
    in _fecha_nacimiento DATE,
    in _rfc VARCHAR(13) 
)
begin 
    insert into usuarios (nombre, apellidop, apellidom, fecha_nacimiento, rfc) values 
    (_nombre, _apellidop, _apellidom, _fecha_nacimiento, _rfc);
end;

call p_insertar_usuarios('Jose', 'Perez', 'Prado', '2000-06-11', 'GGTN260803EM5')
select * from usuarios; 

-- Procedimiento almacenado para modificar usuarios --
create procedure p_modificar_usuarios
(
    in _id_usuario int, 
    in _nombre varchar(255),
    in _apellidop varchar(255),
    in _apellidom varchar(255), 
    in _fecha_nacimiento DATE,
    in _rfc VARCHAR(13) 
)
begin
    update usuarios set nombre = _nombre, apellidop = _apellidop, apellidom = _apellidom, fecha_nacimiento = _fecha_nacimiento, rfc = _rfc
    where id_usuario = _id_usuario;
end; 

call p_modificar_usuarios(1, 'Manuel', 'Perez', 'Prado', '2000-06-11', 'GGTN260803EM5'); 
select * from usuarios; 

-- Procedimiento almacenado para eliminar usuarios --
CREATE procedure p_eliminar_usuarios
(
    in _id_usuario int
)
begin
    delete from usuarios
    where id_usuario = _id_usuario; 
end; 

call p_eliminar_usuarios(1); 
select * from usuarios; 