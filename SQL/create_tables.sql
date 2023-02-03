DROP TABLE Пользователи
DROP TABLE Роли
DROP TABLE Операции
DROP TABLE Банкоматы
DROP TABLE Клиенты
DROP TABLE Банки

CREATE TABLE Роли (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Название nvarchar(50),
	is_archived bit,
)

CREATE TABLE Пользователи (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Логин nvarchar(30),
	Пароль nvarchar(30),
	ID_роли int NOT NULL,
	is_archived bit,
	FOREIGN KEY (ID_роли) REFERENCES Роли (ID),
)

CREATE TABLE Банки (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Название nvarchar(50),
	Юридический_адрес nvarchar(150),
	is_archived bit,
)

CREATE TABLE Клиенты (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ФИО nvarchar(50),
	Номер_карты bigint,
	Адрес nvarchar(150),
	ID_банка int NOT NULL,
	is_archived bit,
	FOREIGN KEY (ID_банка) REFERENCES Банки (ID),
)

CREATE TABLE Банкоматы (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Адрес nvarchar(150),
	ID_банка int NOT NULL,
	is_archived bit,
	FOREIGN KEY (ID_банка) REFERENCES Банки (ID),
)

CREATE TABLE Операции (
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_клиента int NOT NULL,
	ID_банкомата int NOT NULL,
	Дата_время date,
	Сумма money,
	is_archived bit,
	FOREIGN KEY (ID_клиента) REFERENCES Клиенты (ID),
	FOREIGN KEY (ID_банкомата) REFERENCES Банкоматы (ID),
)