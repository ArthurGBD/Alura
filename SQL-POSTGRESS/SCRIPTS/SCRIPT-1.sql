CREATE TABLE aluno(
	id SERIAL,
	nome VARCHAR(255),
	cpf CHAR (11),
	observacao TEXT,
	idade INTEGER,
	dinheiro NUMERIC(10,2),
	aluta REAL,
	ativo BOOLEAN,
	data_nascimento DATE,
	hora_aula TIME,
	matriculado_em TIMESTAMP
);

SELECT * FROM aluno;

INSERT INTO aluno (
	nome,
	cpf,
	observacao,
	idade,
	dinheiro,
	altura,
	ativo,
	data_nascimento,
	hora_aula,
	matriculado_em
				 )
VALUES (
	'Arthur',
	'47579795841',
	'Eai!',
	22,
	100.50,
	1.89,
	TRUE,
	'1999-09-28',
	'17:30:00',
	'2022-02-10 10:45:50'
);

SELECT *
	FROM aluno
WHERE id = 1;

UPDATE aluno
	SET nome = 'Teste',
	cpf = '12345678910',
	observacao = 'Teste',
	idade = 23,
	dinheiro = 100.00,
	altura = 1.90,
	ativo = FALSE,
	data_nascimento = '1975-01-15',
	hora_aula = '13:00:00',
	matriculado_em = '2020-01-02'
	
WHERE id = 1;

SELECT *
	FROM aluno
	WHERE nome = 'Arthur';
	
DELETE
	FROM aluno
	WHERE nome = 'Teste';





