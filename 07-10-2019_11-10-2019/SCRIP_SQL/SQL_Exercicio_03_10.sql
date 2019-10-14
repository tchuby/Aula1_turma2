-- Primeira tarefa
update Carros
set 
UsuInc = 1
where UsuInc = 0
GO

update Marcas
set 
UsuInc = 1
where UsuInc = 0
GO

update Usuarios
set 
UsuInc = 1
where UsuInc = 0
GO

update Vendas
set 
UsuInc = 1
where UsuInc = 0
GO

-- segunda tarefa
select 
mar.Nome
from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like '%Felipe'
GO

-- terceira tarefa
select
mar.Nome
from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%' 
GO

-- 4 Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor "colocar o order by desc   no final do select só isso "
select 
COUNT(mar.Id) as 'Quantidade'
from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
WHERE usu.Usuario like 'Felipe%'
ORDER BY 'Quantidade' DESC
GO

-- 5 Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select 
COUNT(mar.Id) as 'Quantidade'
from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by 'Quantidade' desc
GO

-- 6 Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram
select 
COUNT(mar.Id) as 'Quantidade', usu.Usuario 
from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
group by usu.Usuario
ORDER BY 'Quantidade' DESC
GO

-- 7 Trazer somente os carros que Felipe cadastrou
select
car.Modelo
from Carros car 
            inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'
GO

-- 8 Trazer somente os carros que Giomar cadastrou
select 
car.Modelo
from Carros car 
            inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
GO

-- 9 Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select
 count(car.Modelo) as 'Quantidade'
 from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
 where usu.Usuario like 'Felipe%'
 order by 'Quantidade' desc
 GO 

-- 10 - Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select
COUNT(car.Modelos) as 'Quantidade'
from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'
order by 'Quantidade' desc
GO

-- 11 Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select
COUNT(car.Modelo) as 'Quantidade', usu.Usuario
from Carros car inner join Usuarios usu on car.UsuInc = usu.Id
group by usu.Usuario
GO

-- 12 Trazer somente os carros das marcas que Felipe cadastrou
select 
car.Modelo
from Carros car inner join Marcas mar 
 on car.UsuInc = mar.Id
inner join Usuarios usu on mar.UsuInc = usu.Id
   where usu.Usuario like 'Felipe%'

--13 Trazer somente os carros das marcas que Giomar cadastrou
select
car.Modelos
from Carros car inner join Marcas mar
on 

-- 14 Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor

