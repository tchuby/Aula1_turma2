update -- palavra reservada que atualiza indomacoes
Livros -- nossa tablea será alterado a informaçõa
set -- set inicializa a primeira alteração em nosso sql
Ativo = 0 -- expressão que vai ser alterada
 where -- Palavra que inicializa as condições para realizar esta alteração
 Id = (
select ID from Livros 
where Ativo = 1
order by id desc
OFFSET 1 ROW FETCH NEXT 1 ROWS ONLY)