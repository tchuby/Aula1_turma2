insert into Usuarios
(Nome, Login, Senha)
values
('Adagoberto', 'Urineidson', '66tapanasoreia')
GO
select * from Usuarios
update Usuarios set Ativo =0 where Id = 2