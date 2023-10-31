
create table tb_clientes(
  id int primary key auto_increment,
  nome varchar(45)
);

 create table tb_vendas(
    id int primary key auto_increment,
    data date,
    status char default 'A',
    tb_clientes_id int,
    foreign key(tb_clientes_id) references tb_clientes(id)
 );

create table tb_categorias(
 id int primary key auto_increment,
 nome varchar(20)
 );
 
 create table tb_produtos(
    id int primary key auto_increment,
    descricao varchar(45),
    valorUnitario decimal(8,2),
    estoque decimal(8,2),
    tb_categorias_id int,
    foreign key(tb_categorias_id) references tb_categorias(id)    
 );
 
 create table tb_itens_venda(
     tb_vendas_id int,
     tb_produtos_id int,
     quantidade decimal(8,2),
     preco decimal(8,2),
     foreign key(tb_vendas_id) references tb_vendas(id),
     foreign key(tb_produtos_id) references tb_produtos(id)
 ); 
 

 