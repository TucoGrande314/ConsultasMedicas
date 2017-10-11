CREATE TABLE CONSULTA(id_consulta int primary key,
					  id_paciente int,
					  id_medico int,
					  data_consulta datetime,
					  inicio_consulta time,
					  duracao int,
					  stat varchar(10),
					  foreign key (id_paciente) references PACIENTE(id_paciente),
					  foreign key (id_medico) references MEDICO(id_medico))