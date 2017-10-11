CREATE TABLE ANOTACOES(id_anotacoes int,
					   id_consulta int,
					   resultado text,
					   diagnostico text,
					   medicacao text
					   foreign key (id_consulta) references CONSULTA(id_consulta))