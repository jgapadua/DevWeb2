
CREATE DATABASE bd_estacionamento;

USE bd_estacionamento;

CREATE TABLE TBL_TipoContrato(
	idTipoContrato INT NOT NULL AUTO_INCREMENT,
	descricao VARCHAR(20),
	PRIMARY KEY(idTipoContrato)
	);

CREATE TABLE TBL_Cliente (
	idCliente INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	endereco VARCHAR(100) NOT NULL,
	telefone VARCHAR(15),
	placaVeiculo CHAR(7),
	PRIMARY KEY(idCliente)
	);
	
CREATE TABLE TBL_Contrato (
	idContrato INT NOT NULL AUTO_INCREMENT,
	idCliente INT NOT NULL,
	idTipoContrato INT NOT NULL,
	valor DOUBLE NOT NULL,
	dataInicio DATE NOT NULL,
	numeroVaga INT,
	PRIMARY KEY(idContrato),
	FOREIGN KEY(idCliente) REFERENCES TBL_Cliente(idCliente),
	FOREIGN KEY(idTipoContrato) REFERENCES TBL_TipoContrato(idTipoContrato)
	);
	
	INSERT INTO TBL_TipoContrato VALUES(NULL, 'Diário');
	INSERT INTO TBL_TipoContrato VALUES(NULL, 'Semanal');
	INSERT INTO TBL_TipoContrato VALUES(NULL, 'Quinzenal');
	INSERT INTO TBL_TipoContrato VALUES(NULL, 'Mensal');
	
	INSERT INTO TBL_Cliente VALUES (NULL, 'Jacqueline Barros', 'Rua Capivari, 128 - Serra','98425-4789', 'HNZ4346');
	INSERT INTO TBL_Cliente VALUES (NULL, 'Daniel Santos', 'Rua Maranhão, 1278 apto. 101 - Funcinários', '97512-3652', 'GOH4125');
	INSERT INTO TBL_Cliente VALUES (NULL, 'André Vargas Leite', 'Rua Aimorés, 2196 - Santo Agostinho', '98841-2356', 'PNZ1232');
	INSERT INTO TBL_Cliente VALUES (NULL, 'Margarida Soares', 'Rua Elizabete Trancoso, 67 apto. 201 - Céu Azul', '99632-7412', 'OOH7542');
	INSERT INTO TBL_Cliente VALUES (NULL, 'Marilda Ferreira', 'Rua Expedicionários, 150 apto. 302 - Alípio de Melo', '99541-8753', 'GZN6842');
	INSERT INTO TBL_Cliente VALUES (NULL, 'José Luís Martins', 'Rua São Paulo, 3015 apto. 1002 - Lourdes', '97538-1456', 'NHU8250');
	
	INSERT INTO TBL_Contrato VALUES (NULL, 4, 3, 120.00, '2016/08/05', 12);
	INSERT INTO TBL_Contrato VALUES (NULL, 6, 2, 80.00,  '2016/10/09', 08);
	INSERT INTO TBL_Contrato VALUES (NULL, 1, 1, 30.00,  '2015/03/17', 03);
	INSERT INTO TBL_Contrato VALUES (NULL, 2, 4, 160.00, '2016/05/01', 07);
	INSERT INTO TBL_Contrato VALUES (NULL, 3, 3, 120.00, '2015/05/10', 15);
	INSERT INTO TBL_Contrato VALUES (NULL, 5, 4, 170.00, '2016/08/05', 01);
	
	
	
	