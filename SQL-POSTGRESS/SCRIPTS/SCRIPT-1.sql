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
 
CREATE TABLE curso (
	id INTEGER NOT NULL UNIQUE,
	nome VARCHAR(255) NOT NULL
);

CREATE TABLE curso (
	id INTEGER PRIMARY KEY,
	nome VARCHAR(255) NOT NULL
);
 
INSERT INTO curso (id, nome) VALUES(NULL, NULL);
INSERT INTO curso (id, nome) VALUES(1, NULL);
INSERT INTO curso (id, nome) VALUES(NULL, 'HTML');

INSERT INTO curso (id, nome) VALUES(1, 'HTML');
INSERT INTO curso (id, nome) VALUES(2, 'JAVASCRIPT');

SELECT * FROM curso;

DROP TABLE aluno;
 
CREATE TABLE aluno (
	id SERIAL PRIMARY KEY,
	nome VARCHAR(255) NOT NULL
);


INSERT INTO aluno (nome) VALUES ('Diogo');
INSERT INTO aluno (nome) VALUES ('Vínícius');

SELECT * FROM aluno;

DROP TABLE aluno_curso;

CREATE TABLE aluno_curso (
	aluno_id INTEGER,
	curso_id INTEGER,
	PRIMARY KEY (aluno_id, curso_id),
	
	FOREIGN KEY (aluno_id)
		REFERENCES aluno (id),
	
	FOREIGN KEY (curso_id)
		REFERENCES curso (id)
);

INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (1,1);
INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (2,1);

INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (3,1);
INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (1,3);



SELECT * FROM aluno WHERE id = 1;
SELECT * FROM curso WHERE id = 1;

SELECT * FROM aluno WHERE id = 2;
SELECT * FROM curso WHERE id = 1;

SELECT * FROM aluno WHERE id = 3;
SELECT * FROM curso WHERE id = 1;


SELECT * FROM aluno;
SELECT * FROM curso;

SELECT aluno.nome AS aluno_nome,
	   curso.nome AS curso_nome
	FROM aluno
	JOIN aluno_curso ON aluno_curso.aluno_id = aluno.id
	JOIN curso 	     ON curso.id 			 = aluno_curso.curso_id
	
INSERT INTO aluno_curso (aluno_id, curso_id) VALUES(2,2);

INSERT INTO aluno_curso (aluno_id, curso_id) VALUES(2,2);

INSERT INTO aluno (nome) VALUES('Arthur');

INSERT INTO curso (id, nome) VALUES(3,'CSS');

SELECT aluno.nome AS aluno_nome,
	   curso.nome AS curso_nome
	FROM aluno
LEFT JOIN aluno_curso ON aluno_curso.aluno_id = aluno.id
LEFT JOIN curso 	  ON curso.id 	 	      = aluno_curso.curso_id

SELECT aluno.nome AS aluno_nome,
	   curso.nome AS curso_nome
	FROM aluno
RIGHT JOIN aluno_curso ON aluno_curso.aluno_id = aluno.id
RIGHT JOIN curso 	   ON curso.id 	 	       = aluno_curso.curso_id

SELECT aluno.nome AS aluno_nome,
	   curso.nome AS curso_nome
	FROM aluno
FULL JOIN aluno_curso ON aluno_curso.aluno_id = aluno.id
FULL JOIN curso 	  ON curso.id 	 	      = aluno_curso.curso_id

SELECT aluno.nome AS aluno_nome,
	   curso.nome AS curso_nome
	FROM aluno
CROSS JOIN curso

INSERT INTO aluno (nome) VALUES('Jorge');

DROP TABLE aluno_curso;

CREATE TABLE aluno_curso (
	aluno_id INTEGER,
	curso_id INTEGER,
	PRIMARY KEY (aluno_id, curso_id),
	
	FOREIGN KEY (aluno_id)
		REFERENCES aluno (id)
		ON DELETE CASCADE,
	
	FOREIGN KEY (curso_id)
		REFERENCES curso (id)
);

INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (1,1);
INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (2,1);

INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (3,1);
INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (1,3);

SELECT * FROM aluno_curso;

DELETE FROM aluno WHERE id = 1;

SELECT aluno.nome AS aluno_nome,
	   curso.nome AS curso_nome
	FROM aluno
	JOIN aluno_curso ON aluno_curso.aluno_id = aluno.id
	JOIN curso 	     ON curso.id 			 = aluno_curso.curso_id
	
	SELECT * FROM aluno;
	
	UPDATE aluno
		SET id = 10
		WHERE id = 2;
		
	UPDATE aluno
		SET id = 20
		WHERE id = 4;


