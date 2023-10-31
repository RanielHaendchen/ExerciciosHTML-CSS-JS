insert into tb_contatos(nome, email, fone) 
values ('JOSE', 'jose@gmail.com', '47-988127478');

insert into tb_contatos(nome, email, fone)
values ('MARIA', 'MARIA@GMAIL.COM', '47-985771924');

delete from tb_contatos where id < 15;

alter table tb_contatos drop column nome;

alter table tb_contatos add column nome varchar(45) not null;

insert into tb_locais (nome, rua, numero)
values ('Clube de bocha', 'Rua XV', '200');

insert into tb_locais (nome, rua, numero)
values ('Pescaria', 'Rio ...', '250');

select * from tb_locais;


insert into tb_compromissos (descricao, data, hora, tb_contatos_id, tb_locais_id)
values ('Jogar Bocha', '2023-10-18', '18:00:00', '5', '1') 

select * from tb_contatos

update tb_contatos
SET nome = 'Josezinho' /* Isso fez com que mudasse o nome de JOSE para Josézinho*/
WHERE id = 1;

/*descricao, data, hora, tb_contatos_id tc_locais_id*/



