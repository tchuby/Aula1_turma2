select * from Funcionarios
select * from Salarios
insert into Funcionarios 
(Nome, DataInicio) 
values 
('Eurídice', '01/06/2019'), 
('Agamenom', '03/06/2019'), 
('Eustáquio', '02/06/2019')

update Funcionarios
set DataInicio = '06/07/2019'
select * from Funcionarios

insert into Salarios(FuncionarioId, Valor,DataCriacao)
values
(1,1800, '07/05/2019'),
(1,1700,'08/07/2019'),
(1,1800,'09/06/2019'),
(2,1400, '07/05/2019'),
(2,1400,'08/07/2019'),
(2,1400,'09/06/2019'),
(3,1600, '07/05/2019'),
(3,1600,'08/07/2019'),
(3,1600,'09/06/2019')

