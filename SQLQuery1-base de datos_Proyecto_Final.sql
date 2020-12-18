create database Servicios_Prestamo

use Servicios_Prestamo

--TABLA PARA LOS CLIENTES 
create table Clientes
(
id int identity (1,1) primary key,
cedula bigint not null unique,
nombre varchar(100) not null,
correo varchar(100) not null,
direccion varchar(100) not null,
telefono bigint not null

)


go


--TABLA DE LOS SERVICIOS DE PRESTAMOS PARA LOS CLIENTES

create table prestamo
(
id int identity(1,1) primary key,
fecha date,
montoPrestamo bigint not null,
id_cliente int ,
cuotas int not null
)

create table MovimientoPrestamo
(
IdM int identity(1,1) primary key,
id_cliente int,
montoPend bigint not null
)

alter table prestamo add constraint Fk_cliente foreign key (id_cliente) references Clientes(id) 
alter table MovimientoPrestamo add constraint Fk_id_cliente foreign key (id_cliente) references Clientes(id) 

create table Pagos
(
id int identity(1,1) primary key,
fecha nvarchar(50),
id_prestamo int,
id_cliente int,
MontoPagado bigint not null
)

alter table Pagos add constraint Fk_prestamoApagar foreign key(id_prestamo) references prestamo(id)
alter table Pagos add constraint FK_ClienteApagar foreign key (id_cliente) references Clientes(id)

--#########Procedimientos Almacenados#########
create procedure InsertarPrestamo

@id_prestamo int,
@fecha date,
@MontoPrestamo bigint,
@id_cliente int,
@cuotas int
as
begin
	
	insert into prestamo values(@fecha,@Montoprestamo,@id_cliente,@cuotas)
	insert into MovimientoPrestamo values (@id_cliente,@MontoPrestamo)

end

create procedure cuota
@id_prestamo int
as
begin 
declare @a int
declare @b int
declare @c int
declare @Resultado int

Set @a =(select montoPrestamo  from prestamo where ID = @id_prestamo)
Set @b = (Select cuotas  from prestamo where ID = @id_prestamo)
Set @c = (select montoPend from MovimientoPrestamo where IdM = @id_prestamo)
Set @resultado =(  @c-@a/@b)

update MovimientoPrestamo set montoPend = @Resultado where IdM = @id_prestamo
end

create procedure MontoPago
@id_prestamo int
as
begin 
declare @a int
declare @b int
declare @Resultado int

Set @a =(select prestamo.montoPrestamo from prestamo where id = @id_prestamo)
Set @b = (Select prestamo.cuotas from prestamo where ID = @id_prestamo)
Set @resultado =(@a/@b)

update Pagos set MontoPagado = @Resultado where id_prestamo = @id_prestamo
end


create procedure InsertarPago
@fecha nvarchar(80),
@id_prestamo int,
@id_cliente int,
@MontoPagado int
as 
begin
	insert into Pagos values(@fecha,@id_prestamo,@id_cliente,@MontoPagado) 	
end

create procedure InsertarCliente
@id int, 
@cedula bigint, 
@nombre varchar(100), 
@correo varchar(100), 
@direccion varchar(100), 
@telefono bigint
as
begin
	
	insert into Clientes values(@cedula,@nombre,@correo,@direccion,@telefono)

end


create procedure EliminarPrestamo
@id int,
@id_prestamo int

as

begin
	delete from prestamo where id = @id 
	delete from MovimientoPrestamo Where id = @id_prestamo
end

create procedure EliminarCliente
@cedula bigint
as

begin
	delete from Clientes where cedula = @cedula 
end

create procedure ActualizarPrestamo
@fecha date,
@MontoPrestamo bigint,
@id_cliente int,
@cuotas int
as

begin
	update prestamo set fecha = @fecha, montoPrestamo = @MontoPrestamo, cuotas = @cuotas where id_cliente= @id_cliente
	update MovimientoPrestamo set montoPend = @MontoPrestamo where id_cliente= @id_cliente
end

create procedure ActualizarCliente
@cedula bigint, 
@nombre varchar(100), 
@correo varchar(100), 
@direccion varchar(100), 
@telefono bigint
as

begin
	update Clientes set nombre = @nombre, correo = @correo, direccion = @direccion, telefono = @telefono where cedula = @cedula 
end

create procedure BuscarPrestamo
@id_cliente int
as 
begin
	select * from prestamo where id_cliente = @id_cliente
end

create procedure BuscarMovimiento
@id_cliente int
as
begin
	select * from MovimientoPrestamo where id_cliente = @id_cliente
end

---######Consultas y pruebas######

exec BuscarMovimiento 4


select * from MovimientoPrestamo

select * from prestamo

select Clientes.id, Clientes.nombre,Clientes.cedula,Clientes.correo,Clientes.telefono,prestamo.montoPrestamo, prestamo.cuotas from Clientes 
inner join prestamo  on Clientes.id = prestamo.id_cliente 

select * from Clientes
select * from Pagos

delete from prestamo

delete from Clientes

delete from pagos

delete from MovimientoPrestamo

select prestamo.montoPrestamo from prestamo






