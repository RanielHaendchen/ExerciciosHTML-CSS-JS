create table clientes(
clientesID int primary key auto_increment,
nome varchar(45) not null,
telefone varchar(14) not null,
endereco varchar(50) not null
);

create table vendas(
VendasID int primary key auto_increment,
data DATE not null,
valor int not null,
clientesID int,
FOREIGN KEY (clientesID) references clientes(clientesID)
);

create table valor_receber(
valorReceberID int primary key auto_increment,
valor INT not null,
Data_Vencimento VARCHAR(45) not null,
Parcelas VARCHAR(10) not null,
VendasID int,
FOREIGN KEY (VendasID) references vendas(VendasID)
)

create table categoria(
categoriaID int primary key auto_increment, 
Nome VARCHAR(45)
)

create table fornecedores(
fornecedoresID int primary key auto_increment,
nome VARCHAR(45) not null,
telefone VARCHAR(45) not null,
endereco VARCHAR(45) not null
)

create table compras(
comprasID int primary key auto_increment,
valor INT not null,
data DATE not null,
fornecedoresID int,
FOREIGN KEY (fornecedoresID) references fornecedores(fornecedoresID)
)

create table contas_pagar(
contasPagarID int primary key auto_increment,
Nome_Duplicata VARCHAR(45) not null,
Valor INT not null,
Parcelas VARCHAR(45) not null,
Data_Vencimento DATE not null,
comprasID int,
FOREIGN KEY (comprasID) references compras(comprasID)
)

create table produto(
produtoID int primary key auto_increment,
Nome VARCHAR(45) not null,
Preço INT not null,
fornecedoresID int,
categoriaID int,
FOREIGN KEY (fornecedoresID) references fornecedores(fornecedoresID),
FOREIGN KEY (categoriaID) references categoria(categoriaID)
)

create table vendas_produto(
quantidade int not null,
valor int not null,
produtoID int,
VendasID int,
FOREIGN KEY (produtoID) references produto(produtoID),
FOREIGN KEY (VendasID) references vendas(VendasID)
)

create table compras_produtos(
quantidade int not null,
produto int not null,
comprasID int,
produtoID int,
FOREIGN KEY (comprasID) references compras(comprasID),
FOREIGN KEY (produtoID) references produto(produtoID)
)

INSERT INTO clientes (nome, telefone, endereco)
VALUES ('Paulo', '47-981582817', 'Rua 25 Janeiro'),
('Alex', '47-812985128', 'Rua São Paulo');

insert into produto (nome, preço, fornecedoresID, categoriaID)
VALUES ('GTX 1060', '1000', '1', '1')


SELECT
    produto.produtoID, produto.Nome, produto.Preço,
    fornecedores.fornecedoresID, fornecedores.nome, fornecedores.telefone, fornecedores.endereco,
    categoria.categoriaID, categoria.Nome
FROM produto
JOIN fornecedores ON produto.fornecedoresID = fornecedores.fornecedoresID
JOIN categoria ON produto.categoriaID = categoria.categoriaID;
	
    
insert into fornecedores (nome, telefone, endereco)
VALUES ('Zezin Fornece', '47-81239218', 'Rua XV 250')


insert into categoria (nome)
values ('Computador')



