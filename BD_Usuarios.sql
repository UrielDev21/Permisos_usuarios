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
    tipo_permiso set('Lectura', 'Escritura', 'Modificacion', 'Eliminacion'),
    permiso_formulario set('Agregar_Usuarios', 'Ver_Usuarios', 'Agregar_refacciones', 'Ver_refacciones', 'Agregar_herramienta', 'Ver_herramienta'),
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
    medida VARCHAR(100),
    marca varchar(255),
    descripcion varchar(255)
);
<<<<<<< HEAD
show tables;
=======

-- MODIFICACION --
ALTER table taller
modify column medida varchar(10); 
>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e

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
    in _tipo_permiso set('Lectura', 'Escritura', 'Modificacion', 'Eliminacion'),
    in _permiso_formulario set('Agregar_Usuarios', 'Ver_Usuarios', 'Agregar_refacciones', 'Ver_refacciones', 'Agregar_herramienta', 'Ver_herramienta'),
    in _user varchar(100), 
    in _pass varchar(255)
)
begin 

    declare nuevo_id_usuario int; 

    insert into usuarios (nombre, apellidop, apellidom, fecha_nacimiento, rfc) values 
    (_nombre, _apellidop, _apellidom, _fecha_nacimiento, _rfc);

    set nuevo_id_usuario = last_insert_id(); 

    insert into permisos(fk_id_usuario, tipo_permiso, permiso_formulario, user, pass) values 
    (nuevo_id_usuario, _tipo_permiso, _permiso_formulario, _user, _pass); 
end;
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
<<<<<<< HEAD
=======
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

>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e

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

<<<<<<< HEAD
=======
call p_eliminar_usuarios_permisos(1); 
>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e

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

<<<<<<< HEAD
=======
call p_insertar_refacciones('po3iu4djfhals', 'Bomba de agua', 'Bomba de agua para sedan', 'Toyota'); 
>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e

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

<<<<<<< HEAD
=======
call p_modificar_refacciones('po3iu4djfhals', 'Bomba de gasolina', 'Una bomba de gasolita para una Pick-UP', 'Ford'); 

>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e
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

<<<<<<< HEAD
=======
call p_eliminar_refacciones('po3iu4djfhals'); 
>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e

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

<<<<<<< HEAD
=======
call p_insertar_herramienta('134208967', 'Matraca', '3/4', 'Craftman', 'Matraca perrona'); 

>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e
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

<<<<<<< HEAD
=======
call p_modificar_herramienta('134208967', 'Taladro', '10pul', 'Makita', 'Taladro perron');
>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e

-- Procedimiento almacenado para eliminar herramientas de la tabla --
CREATE procedure p_eliminar_herramienta
(
    in _Codigo_herramienta varchar(25)
)
begin 
    delete  from taller
    where Codigo_herramienta = _Codigo_herramienta;
end;

<<<<<<< HEAD
-- Vista para usuarios --
create VIEW v_vista_usuarios AS
select u.nombre, u.apellidop, u.apellidom, u.fecha_nacimiento, u.rfc, p.tipo_permiso, p.user, p.pass from usuarios u
join permisos p on u.id_usuario = p.fk_id_usuario;
select * from v_vista_usuarios WHERE nombre like '%Jose%';

-- Vista para refacciones --
create View v_vista_refacciones AS
select * from  refacciones;

select * from v_vista_refacciones where nombre like '%Empaque%';

-- Vista para taller -- 
create VIEW v_vista_taller AS
select * from taller;

select * from v_vista_taller where nombre like '%Llave%';

-- Pruebas de funcionamiento de los procedimientos almacenados --
call p_insertar_usuarios('Luis Julian', 'Hernandez', 'Trejo', '1970-08-02', 'SJOHGHOUS1247', 'Administrador', 'malvadovainilla69', sha1('1234'));
call p_insertar_usuarios('Jose Manuel', 'Vega', 'Torres', '1970-12-14', 'APAOSIHFDP122', 'Empleado', 'elUe', sha1('1234'));
call p_insertar_usuarios('Luis Fernando', 'Gomez', 'Maldonado', '1970-10-21', 'LLPOSIYFPOIA1', 'Empleado', 'ElLuis', sha1('1234'));
call p_modificar_usuarios(3, 'Luis Julian', 'Hernandez', 'Trejo', '1970-08-02', 'SJOHGHOUS1247', 'Empleado', 'malvadovainilla69', sha1('1234'));
call p_modificar_usuarios(4, 'Jose Manuel', 'Vega', 'Villagran', '1970-12-14', 'APAOSIHFDP122', 'Administrador', 'elUe', sha1('1234'));
call p_modificar_usuarios(5, 'Luis Fernando', 'Gomez', 'Maldonado', '1970-10-21', 'LLPOSIYFPOIA1', 'Administrador', 'ElLuis20', sha1('1234'));

call p_eliminar_usuarios_permisos(3);
call p_eliminar_usuarios_permisos(4);
call p_eliminar_usuarios_permisos(5);

select * from permisos;
select * from usuarios;

------------------------------------------------------------------------------------------------
call p_insertar_refacciones('6546846854657', 'Empaque de culata', 'Empaque de culata para camioneta FORD', 'Ford');
call p_modificar_refacciones('6546846854657', 'Empaque de culata', 'Empaque de culata para camioneta TOYOTA', 'TOYOTA');
CALL p_eliminar_refacciones('6546846854657');
SELECT * FROM refacciones;
-------------------------------------------------------------------------------------------------
call p_insertar_herramienta('SSAHDFLJ1', 'Llave', '1/2', 'CRAFTMAN', 'Llave de buena calidad');
call p_modificar_herramienta('SSAHDFLJ1', 'Perica', '2 pulgadas', 'TRUPER', 'Perica marca truper');

call p_eliminar_herramienta('SSAHDFLJ1');
select * from taller;
=======
call p_eliminar_herramienta('134208967'); 
>>>>>>> 3c7f75c7e1b7ca9c3a104f7e29bb1863f5e45d0e
