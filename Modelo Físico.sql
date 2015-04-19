-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE Funcionário (
Nome nvarchar(50),
Endereço nvarchar(50),
Email nvarchar(50),
CPF_Funcionário int PRIMARY KEY,
Telefone int
)

CREATE TABLE Ordem_Serviço (
Número_OS int PRIMARY KEY,
Data_Iníco date,
Data_Conclusão date,
Modelo_equipamento nvarchar(50),
Marca_equipamento nvarchar(50),
Descrição_Serviço nvarchar(1000),
Valor Numeric(8,2),
CPF_Cliente int,
CPF_Funcionário int,
Armazenamento_Fotos image,
FOREIGN KEY(CPF_Funcionário) REFERENCES Funcionário (CPF_Funcionário)
)

CREATE TABLE Cliente (
Email nvarchar(50),
Nome nvarchar(50),
Endereço nvarchar(50),
CPF_Cliente int PRIMARY KEY,
Telefone int
)

CREATE TABLE Administrador (
Login nvarchar(50),
Senha int PRIMARY KEY
)

ALTER TABLE Ordem_Serviço ADD FOREIGN KEY(CPF_Cliente) REFERENCES Cliente (CPF_Cliente)
