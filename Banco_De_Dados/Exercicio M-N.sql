create table tb_compromisso(
id int auto_increment primary key,
descricao VARCHAR(50) not null,
data DATE,
hora TIME
);

create table tb_contato(
id int auto_increment primary key,
nome VARCHAR(50) not null,
email VARCHAR(50),
celular VARCHAR(14)
);

create table compromisso_contato(
contato_id int not null,
compromisso_id int not null,
FOREIGN KEY (contato_id) REFERENCES tb_contato(id),
FOREIGN KEY (compromisso_id) REFERENCES tb_compromisso(id)
)

select * from compromisso_contato

insert into tb_contato (nome, email, celular)
VALUES ('Paulo', 'paulo@gmail.com', '47-98898412')

insert into tb_compromisso (descricao, data, hora)
VALUES ('Comer', '2023-10-22', '16:00:00')


insert into compromisso_contato(compromisso_id,contato_id)
value(2,2)

SELECT * FROM compromisso_contato
JOIN tb_compromisso ON compromisso_contato.compromisso_id = tb_compromisso.id	
JOIN tb_contato ON compromisso_contato.contato_id = tb_contato.id;

