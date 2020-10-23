
CREATE TABLE servicos
(
    id INT NOT NULL PRIMARY KEY,
    servico VARCHAR (50),
    descricao VARCHAR (100) ,
    preco DECIMAL (10, 2) NOT NULL 

); 

CREATE TABLE preagendamento
(
    id INT NOT NULL PRIMARY KEY,
    nome VARCHAR (100)  ,
    telefone VARCHAR (15),
    dataagendamento VARCHAR (10),
    animal VARCHAR (10),
    necessidade VARCHAR (300)  
); 

    INSERT INTO servicos (id, servico,descricao,preco)
    VALUES (1, 'Tosa', 'Corte completo com banho', 50.00);
    INSERT INTO servicos (id, servico, descricao,preco)
    VALUES (2, 'Castração', 'Castração de machos e fêmeas', 250.00);
    INSERT INTO servicos (id, servico, descricao,preco)
    VALUES (3, 'Consulta veterinária', 'Consulta clínica', 80.00);

    INSERT INTO preagendamento (id, nome,telefone, dataagendamento,animal,necessidade)
    VALUES (1, 'Maro', '51 99238 4616', '05/04/2020', 'Cachorro', 'Castração');
    INSERT INTO preagendamento (id, nome,telefone, dataagendamento,animal,necessidade)
    VALUES (2, 'Joyci', '51 99258 7648', '23/04/2020', 'Gato', 'Consulta clínica');
    INSERT INTO preagendamento (id, nome,telefone, dataagendamento,animal,necessidade)
    VALUES (3, 'Adriana', '51 98745 5697', '30/10/2020', 'Roedor', 'Castração');
    INSERT INTO preagendamento (id, nome,telefone, dataagendamento,animal,necessidade)
    VALUES (4, 'Kelly', '51 98645 3569', '15/06/2020', 'Gato', 'Corte completo com banho');
    