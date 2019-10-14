--INSERT INTO Funcionarios (Nome) Values ('Felipe'), ('Giomar')
-- Cadastrar 5 produtos ambev com seus respectivos valores
/* INSERT INTO Produtos (Nome,Valor) Values ('Skol Beats 313ml',5.49), 
('Budweiser 550ml',6.99),('Stella Artois 275ml', 3.49), 
('Patagônia Pilsener 740ml',15.90), ('Corona Extra 355ml',4.99)
select * from Funcionarios
select * from Produtos
--INSERT INTO Pedidos (FuncionarioId, ProdutoId, Quantidade) Values (1,4,2), (1,3,5), (2,2,4) */

--selecionar funcionarios por ordem alfabetica decrescente
-- select * from Funcionarios Order By Nome Desc

-- Listar produtos do mais caro para o mais barato
-- select *from Produtos Order by Valor desc

--Listar pedidos  por funcionario tranzo seu nome
-- select ped.Id, fun.Nome, ped.ProdutoId, ped.Quantidade from pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id 

-- select de pedidos agrupando por funcionario e somando suas respectivas quantidades de itens
/* select fun.Nome,
sum(ped.Quantidade) as 'Quantidades'
from Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
group by fun.Nome */

/* select 
fun.Nome,
sum(ped.Quantidade * pro.Valor)
From Pedidos ped inner join Funcionarios fun on ped.FuncionarioId = fun.Id
inner join Produtos pro on ped.ProdutoId = pro.Id 
group by fun.Nome; */

/* select pro.Nome,
       SUM(ped.Quantidade) as 'Quantidade' from Produtos pro inner join Pedidos ped on  pro.Id = ped.ProdutoId
	   Group by pro.Nome
Order By sum(ped.Quantidade) desc */

--produto que gerou a maior receita
/* select pro.Nome, SUM(ped.Quantidade * pro.Valor) as 'Receita' 
from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome
Order by 'Receita' desc*/

-- 2.12 seleção para o primeiro funcionario com  os produtos não comprados por si.
/* select * from Produtos 
Where Id not in 
(select ped.ProdutoId from Funcionarios fun 
inner join Pedidos ped on fun.Id = ped.FuncionarioId
inner join Produtos pro on ped.ProdutoID = pro.Id
Where fun.Nome Like 'Felipe%') */

-- 2.13
/* SELECT pro.Nome, count(ped.ProdutoId) as 'Quantidade' FROM Produtos pro left join  Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome 
Order by 'Quantidade' desc */