/*insert into tb_contatos(nome, email)values('maria','maria@gmail.com');

select * from tb_contatos;

update tb_contatos set
fone = '(47)9087-0987',
nome = 'Maria das Dores'
where id = 2*/
/*
insert into tb_locais(nome, rua)values('Pesqueiro','rua vii');
select * from tb_locais*/

/*insert into tb_compromissos
(descricao, data, hora, tb_contatos_id, tb_locais_id)
values('Jogar bocha','2023-10-15','13:00:00',1, 1),
('Pescar','2023-10-05','13:00:00',2, 1)*/

/*insert into tb_compromissos
(descricao, data, hora, tb_contatos_id, tb_locais_id)
values('Jogar bocha','2023-10-15','13:00:00',1, 1);

insert into tb_compromissos
(descricao, data, hora, tb_contatos_id, tb_locais_id)
values('Pescar','2023-10-05','13:00:00',2, 1);

select * from tb_compromissos*/
/*
select tb_compromissos.id, descricao, data, hora, nome
from tb_compromissos, tb_contatos
where tb_compromissos.tb_contatos_id = tb_contatos.id
*/

select tb_comp.id, descricao as Descrição, data, hora, nome as Contato
from tb_compromissos tb_comp, tb_contatos tc
where tb_comp.tb_contatos_id = tc.id;


SELECT tb_compromissos.id, descricao, data, hora, tb_contatos.nome AS Contato, tb_locais.nome
FROM tb_compromissos
INNER JOIN tb_contatos ON tb_compromissos.tb_contatos_id = tb_contatos.id
INNER JOIN tb_locais ON tb_compromissos.tb_locais_id = tb_locais.id
WHERE tb_compromissos.tb_contatos_id = 1;


/*update tb_contatos
SET nome = 'Josezinho' /* Isso fez com que mudasse o nome de JOSE para Josézinho
WHERE id = 1;*/

SELECT * FROM tb_contatos WHERE id = 2;

SELECT * FROM tb_compromissos WHERE tb_contatos_id = 2;
