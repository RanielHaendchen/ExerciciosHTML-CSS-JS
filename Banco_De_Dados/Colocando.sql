insert into tb_categorias(nome)values('Cereais'),('Açougue'),('Frios');
select * from tb_categorias;

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Milho',10.55, 10, 1),('Trigo',7.50, 30, 1);

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Alcatra', 22.99, 2, 2),('Costela',19.50, 5, 2);

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Queijo',14.79, 2, 3),('Nata',3.50, 30, 3);

insert into tb_produtos(descricao, valorUnitario, estoque, tb_categorias_id)
values('Manteiga',4.79, 2, 3),('Iogurte',1.99, 30, 3);
select * from tb_produtos;

insert into tb_clientes(nome)values('Maria'),('Jose')
select * from tb_clientes;

insert into tb_vendas(data, tb_clientes_id)values('2023-09-10',1),('2023-10-10',1);
insert into tb_vendas(data, tb_clientes_id)values('2023-08-10',1),('2023-08-30',2);
insert into tb_vendas(data, tb_clientes_id)values('2023-07-10',1),('2023-07-31',3);

select * from tb_vendas;

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(1,1,2,10.55),(1,2,1,7.50);

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(2,1,2,10.55),(2,2,1,7.50),(2,3,3,22.99);

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(3,1,2,10.55),(3,2,1,7.50);

insert into tb_itens_venda(tb_vendas_id,tb_produtos_id,quantidade, preco)
values(4,1,2,10.55),(4,2,1,7.50),(4,3,3,22.99);

select * from tb_itens_venda;

insert into tb_clientes(nome)values('Paulo');

select * from tb_categorias;

INSERT INTO tb_vendas (id, data, status, tb_clientes_id)
VALUES (9, '2023-08-11', 'A', '2');

