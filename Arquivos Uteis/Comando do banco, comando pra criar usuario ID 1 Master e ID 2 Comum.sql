use autofolha;
-- criando usuario Master
INSERT INTO `autofolha`.`cadastromodel` 
(`Id`, `nome`, `cpf`, `cargo`, `AdmissaoData`, `email`, `senha`, `Sexo`, `salarioB`, `CadastroData`, `Perfil`) 
VALUES ('1', 'Victor', '435.650.845-93', 'Desenvolvedor Sênior', '2023-10-20', 'victor@gmail.com', 'YWFh', 
'Masculino', '15685', '2023-10-20 00:00:00.000000', '1');
-- criando usuario Comum
INSERT INTO `autofolha`.`cadastromodel` 
(`Id`, `nome`, `cpf`, `cargo`, `AdmissaoData`, `email`, `senha`, `Sexo`, `salarioB`, `CadastroData`, `Perfil`) 
VALUES ('2', 'Carina Freitas', '435.550.855-94', 'Engenheira de Software', '2023-12-25', 'carinafreitas@gmail.com', 'YWFh', 
'Feminino', '15685', '2023-10-20 00:00:00.000000', '2');

SELECT * FROM cadastromodel;
INSERT INTO nome_da_tabela (coluna1, coluna2, coluna3)
VALUES ('valor1', 'valor2', 'valor3');
UPDATE nome_da_tabela
SET coluna1 = 'novo_valor1', coluna2 = 'novo_valor2'
WHERE condição;
DELETE FROM nome_da_tabela
WHERE condição;
DESCRIBE nome_da_tabela;
SELECT * FROM nome_da_tabela ORDER BY coluna ASC; -- ASC para ordem crescente, DESC para ordem decrescente
SELECT COUNT(*) FROM nome_da_tabela;
drop database autofolha;
