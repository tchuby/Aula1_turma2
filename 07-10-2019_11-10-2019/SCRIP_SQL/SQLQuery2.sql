select
fun.Nome,
SUM(sal.Valor) as 'Total no 3 mes'
from Funcionarios fun
      inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome 

select
fun.Nome,
AVG(sal.Valor) as 'Total no 3 mes'
from Funcionarios fun
      inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome 

select
fun.Nome,
COUNT(sal.Valor) as 'Quant Pagam.',
sum(sal.Valor) / COUNT(sal.Valor) as 'Noava Media'
from Funcionarios fun
      inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome 

select * from Salarios
where Id between 3 and 8

select * from Salarios
where DataCriacao between '08/06/2019' and '08/07/2019'

select top 5 * from Salarios
order by Valor desc

select * from Salarios 
where Id >= 3 and Id <= 8 

update Funcionarios
set 
DataSaida = '10/03/2019',
DataAlteracao = GETDATE(),
Ativo = 0
where Nome like 'Agamenom%' -- fazer a validacao com o select antes de executar o update para ter certeza de que serão afetadas as linhas desejadas
select * from Funcionarios where Nome like 'Agamenom%'

select
Nome,
CONVERT (VARCHAR(10), DataInicio, 103) as 'Inicio',
CONVERT(VARCHAR(10),DataSaida,103) as'Saida'
from Funcionarios