/* FORMA 1
create table tb_contatos(
  id int primary key auto_increment,
  nome varchar(45) not null,
  email varchar(45),
  fone varchar(14)
)*/
 /*drop table tb_contatos;*/
 
 /* FORMA 2
 create table tb_contatos(
  id int not null auto_increment,
  nome varchar(45) not null,
  email varchar(45),
  fone varchar(14),
  primary key(id) 
)*/

/* FORMA 3
create table tb_contatos(
  id int not null,
  nome varchar(45) not null,
  email varchar(45),
  fone varchar(14)
);*/

/*alter table tb_contatos add constraint pk primary key(id)PRIMARY*/

/*create table tb_locais(
id int primary key auto_increment,
nome varchar(45),
rua varchar(45),
numero int
)*/

create table tb_compromissos(
id int primary key auto_increment,
descricao varchar(75),
`data` DATE,
hora TIME
)



create table tb_compromissos(
id int primary key auto_increment,
descricao varchar(45),
`data` date not null,
hora time not null,
tb_contatos_id int not null,
tb_locais_id int not null,
foreign key (tb_contatos_id) references tb_contatos(id),
foreign key (tb_locais_id) references tb_locais(id)
)

/* Criar as foreigns keys*/
alter table tb_compromissos add column tb_contatos_id int;
alter table tb_compromissos add constraint fk_contatos foreign key(tb_contatos_id) references tb_contatos(id);

alter table tb_compromissos add column tb_locais_id int;
alter table tb_compromissos add constraint fk_locais foreign key(tb_locais_id) references tb_locais(id);