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
	'Larissa',
	'47579795841',
	'Eai!',
	22,
	100.50,
	1.89,
	TRUE,
	'1999-06-08',
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
	
WHERE id = 3;

SELECT *
	FROM aluno
	WHERE nome = 'Arthur';
	
DELETE
	FROM aluno
	WHERE nome = 'Teste';

SELECT nome AS "Nome do Aluno",
	   idade,
	   matriculado_em AS quando_se_matriculou
	from aluno;

INSERT INTO aluno (nome) VALUES ('Vinícios Dias');
INSERT INTO aluno (nome) VALUES ('Arthur');
INSERT INTO aluno (nome) VALUES ('Larissa Nunes');
INSERT INTO aluno (nome) VALUES ('Joao Vitor');

SELECT *
	FROM aluno
 WHERE nome = 'Arthur';

SELECT *
	FROM aluno
 WHERE nome <> 'Arthur';
 
 SELECT *
	FROM aluno
 WHERE nome != 'Arthur';
 
 SELECT *
	FROM aluno
 WHERE nome LIKE '_Arthur';
 
  SELECT *
	FROM aluno
 WHERE nome LIKE 'Art_hur';
 
 SELECT *
	FROM aluno
 WHERE nome NOT LIKE 'Arthur';
 
 SELECT *
	FROM aluno
 WHERE nome LIKE '% %';
 
SELECT *
FROM aluno
WHERE cpf IS NULL;

SELECT *
FROM aluno
WHERE cpf IS NOT NULL;

SELECT *
FROM aluno
WHERE idade = 36;

SELECT *
FROM aluno
WHERE idade <> 36;

SELECT *
FROM aluno
WHERE idade >= 36;
 
SELECT *
FROM aluno
WHERE idade > 36;

SELECT *
FROM aluno
WHERE idade < 36;

SELECT *
FROM aluno
WHERE idade BETWEEN 10 AND 40;

SELECT *
FROM aluno
WHERE ativo = true;

SELECT *
FROM aluno
WHERE nome LIKE 'D%' 
AND cpf IS NOT NULL;

SELECT *
FROM aluno
WHERE nome LIKE 'Diogo' 
OR nome LIKE 'Rodrigo'
OR nome LIKE 'Arthur';
 
 
