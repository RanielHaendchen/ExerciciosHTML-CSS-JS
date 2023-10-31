create user gerente@localhost identified by '123456'; /*Cria o usuario*/

create user operador@localhost identified by '123456';

grant all
on vendas.*   /*Da permissao pro gerente poder fazer tudo no schema vendas*/
to gerente@localhost;

revoke all
on vendas.*  /*Tira as permissoes do gerente de fazer tudo*/
from gerente@localhost;

grant select 
on vendas.tb_categorias /* Permitindo apenas select no schema vendas na tabela tb_categorias*/
to gerente@localhost;

grant select, alter, insert
on vendas.tb_produtos /* Permitindo apenas select, alter e insert no schema vendas na tabela tb_protudos para o operador*/
to operador@localhost;

