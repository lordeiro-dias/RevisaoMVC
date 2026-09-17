CREATE DATABASE MercadoMVC
USE MercadoMVC

CREATE TABLE Usuario(
	UsuarioID INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(60) NOT NULL,
	Email VARCHAR(150) NOT NULL,
	Senha NVARCHAR(50) NOT NULL
);

CREATE TABLE Produto(
	ProdutoID INT PRIMARY KEY IDENTITY,
	NomeProduto VARCHAR(60) NOT NULL,
	Quantidade INT NOT NULL,
	FoiComprado BIT NOT NULL
);

INSERT INTO Usuario(Nome, Email, Senha) VALUES
('Joelinton', 'joelinton@email.com', '123');

SELECT * FROM Usuario