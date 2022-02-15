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
		SET nome = 'Arthur'
		WHERE id = 3;

DROP TABLE aluno_curso;

CREATE TABLE aluno_curso (
	aluno_id INTEGER,
	curso_id INTEGER,
	PRIMARY KEY (aluno_id, curso_id),
	
	FOREIGN KEY (aluno_id)
		REFERENCES aluno (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	,
	
	FOREIGN KEY (curso_id)
		REFERENCES curso (id)
);

INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (1,1);
INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (2,1);

INSERT INTO aluno_curso (aluno_id, curso_id) VALUES (3,1);

SELECT 
		 aluno.id   AS aluno_id, 
		 aluno.nome AS aluno_nome,
		 curso.id 	AS curso_id,
	     curso.nome AS curso_nome
	FROM aluno
	JOIN aluno_curso ON aluno_curso.aluno_id = aluno.id
	JOIN curso 	     ON curso.id 			 = aluno_curso.curso_id
	
	
	UPDATE aluno
		SET id = 10
		WHERE id = 2;

/* EXERCICIO */

DROP TABLE pessoas;

DROP TABLE telefones;

CREATE TABLE pessoas (
    id INTEGER PRIMARY KEY,
    nome VARCHAR(255) NOT NULL
);

CREATE TABLE telefones (
    id INTEGER PRIMARY KEY,
    pessoa_id INTEGER,
    numero VARCHAR(15) NOT NULL,
    FOREIGN KEY (pessoa_id) REFERENCES pessoas (id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

INSERT INTO pessoas (id, nome) VALUES (1,'Diogo');
INSERT INTO telefones (id, pessoa_id, numero) VALUES (1,1,'(21) 98765-4321');

UPDATE pessoas SET id = 2 WHERE nome = 'Diogo';
DELETE FROM pessoas WHERE nome = 'Diogo';

DROP TABLE funcionarios;

CREATE TABLE funcionarios(
	id		  SERIAL		  PRIMARY KEY,
	matricula VARCHAR(10),
	nome	  VARCHAR(255),
	sobrenome VARCHAR(255)
);

INSERT INTO funcionarios (matricula, nome, sobrenome) VALUES ('M001', 'Diogo', 'Mascarenhas');
INSERT INTO funcionarios (matricula, nome, sobrenome) VALUES ('M002', 'Vinícius', 'Dias');
INSERT INTO funcionarios (matricula, nome, sobrenome) VALUES ('M003', 'Nico', 'Steppat');
INSERT INTO funcionarios (matricula, nome, sobrenome) VALUES ('M004', 'João', 'Roberto');
INSERT INTO funcionarios (matricula, nome, sobrenome) VALUES ('M005', 'Diogo', 'Mascarenhas');
INSERT INTO funcionarios (matricula, nome, sobrenome) VALUES ('M006', 'Alberto', 'Martins');

SELECT *
	FROM funcionarios 
	ORDER BY nome DESC
	
SELECT *
	FROM funcionarios 
	ORDER BY nome ASC
	
SELECT *
	FROM funcionarios 
	ORDER BY 3,4,2
	
SELECT *
	FROM funcionarios 
	ORDER BY 4 DESC, funcionarios.nome DESC, 2 ASC
	
SELECT 
		 aluno.id   AS aluno_id, 
		 aluno.nome AS aluno_nome,
		 curso.id 	AS curso_id,
	     curso.nome AS curso_nome
	FROM aluno
	JOIN aluno_curso ON aluno_curso.aluno_id = aluno.id
	JOIN curso 	     ON curso.id 			 = aluno_curso.curso_id
	ORDER BY aluno.nome DESC, curso.nome
	
SELECT * FROM funcionarios 
ORDER BY id
LIMIT 5
OFFSET 2;
	
SELECT COUNT(id),
	SUM(id),
	MAX(id),
	MIN(id),
	AVG(id),
	ROUND(AVG(id),2)
FROM funcionarios;

SELECT
	nome,
	sobrenome
	COUNT(*)
FROM funcionarios
GROUP BY nome, sobrenome
ORDER BY nome;

SELECT
	nome,
	sobrenome
	COUNT(id)
FROM funcionarios
GROUP BY 1, 2
ORDER BY nome;

SELECT curso.nome,
		COUNT(aluno.id)
	FROM aluno
	JOIN aluno_curso ON aluno.id = aluno_curso.aluno_id
	JOIN curso 		 ON curso.id = aluno_curso.curso_id
GROUP BY 1
ORDER BY 1

SELECT curso.nome,
		COUNT(aluno.id)
	FROM curso
	LEFT JOIN aluno_curso ON aluno_curso.curso_id = curso.id
	LEFT JOIN aluno 	  ON aluno.id 			  = aluno_curso.aluno_id
		--WHERE curso.nome = 'Javascript'
GROUP BY 1
	HAVING COUNT(aluno.id) > 0
	
SELECT nome, 
	   COUNT(id)
	FROM funcionarios
	GROUP BY nome
	HAVING COUNT (id) = 1;
	


