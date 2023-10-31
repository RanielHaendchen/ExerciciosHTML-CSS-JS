select min(valorUnitario) from tb_produtos; 

select max(valorUnitario) from tb_produtos; 

select count(*) from tb_produtos;	

select sum(estoque) from tb_produtos;

select avg(estoque) from tb_produtos;

select (sum(estoque)/count(*)) from tb_produtos; /* Calcula a média dos valores na coluna estoque da tabela*/

select * from tb_produtos
where estoque = 2;

select * from tb_produtos
where descricao = "Nata";

select * from tb_produtos /* Esse comando faz com que ele retorne todas as linhas da tabela na descrição que termina com a letra A: "AlcatrA, CostelA, NatA*/
where descricao like "%a";

select * from tb_produtos /* Esse comando faz com que ele retorne todas as linhas da tabela na descrição que começa com a letra A: "Alcatra" "Açafrao"*/
where descricao like "a%";

select * from tb_produtos
where descricao like "m%A";

/*cupom fiscal*/
select tp.id, tp.descricao, tc.nome as Categoria, ti.quantidade, 
ti.preco, (ti.quantidade * ti.preco) as Subtotal 
from tb_itens_venda ti
inner join tb_produtos tp on tp.id = ti.tb_produtos_id
inner join tb_categorias tc on tc.id = tp.tb_categorias_id
where ti.tb_vendas_id = 9;|


insert into tb_itens_venda(tb_vendas_id, tb_produtos_id, quantidade, preco)
values(9, 1, 2, (select valorUnitario from tb_produtos where id = 1));

select * from tb_itens_venda;

select * from tb_vendas
where data between '2023-07-01' and '2023-08-30';

select * from tb_produtos
where tb_categorias_id not in(1);
/*where tb_categorias_id between 2 and 4*/
/*where tb_caregorias_id > 2 and tb_categorias_id < 4/*