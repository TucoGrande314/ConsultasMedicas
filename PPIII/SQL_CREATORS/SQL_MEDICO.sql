CREATE TABLE MEDICO(id_medico int primary key,
					id_especializacao int,
					nome varchar(40),
					email varchar(30),
					telefone varchar(11),
					celular varchar(11),
					foto image,
					senha varchar(20),
					foreign key (id_especializacao) references ESPECIALIZACAO(id_especializacao))