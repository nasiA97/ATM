INSERT INTO Роли VALUES 
('Бухгалтер', 0), /* Просматривает отчеты */
('Менеджер', 0), /* Создает и редактирует операции */
('Администратор', 0) /* Работает с банками, банкоматами, клиентами */

INSERT INTO Пользователи VALUES
('111', '111', 1, 0),
('222', '222', 2, 0),
('333', '333', 3, 0)

INSERT INTO Банки VALUES
('Банк 1', 'Адрес 1', 0),
('Банк 2', 'Адрес 2', 0),
('Банк 3', 'Адрес 3', 0)

INSERT INTO Клиенты VALUES 
('Louise Shamoun', 4294324476695193, 'Rua Vinte e Trs de Fevereiro 1885', 1, 0),
('Riyadh Christensen', 4294303451251933, 'Postbox 206', 1, 0),
('Arthur Dufour', 4294325802458073, 'Letalika 50', 1, 0),
('Kazj Inarkaevich', 4294309138208790, 'Clius 66', 2, 0),
('Amelia Qiu', 4294311730650312, '61 Oriana Street', 2, 0),
('Tavana Svanlaugsson', 4294295611504872, '17 Cefn Road', 3, 0)

INSERT INTO Банкоматы VALUES
('33 Sloe Lane', 1, 0),
('235 Theofanus Street', 1, 0),
('Dalmatinova 11', 1, 0),
('Ctra. de Fuentenueva 65', 2, 0),
('J. R. Wilhelmsens vei 13', 2, 0),
('5 Flax Court', 3, 0)

INSERT INTO Операции VALUES
(1, 1, GETDATE() - 1, 1000, 0),
(1, 2, GETDATE() - 1, 2000, 0),
(2, 3, GETDATE() - 1, 3000, 0),
(2, 4, GETDATE(), 4000, 0),
(3, 5, GETDATE(), 5000, 0),
(3, 6, GETDATE(), 6000, 0),
(1, 1, GETDATE() + 1, 7000, 0),
(1, 3, GETDATE() + 1, 8000, 0),
(1, 5, GETDATE() + 1, 9000, 0),
(1, 5, GETDATE() + 1, 10000, 0),
(4, 5, GETDATE() - 1, 11000, 0),
(4, 5, GETDATE(), 12000, 0),
(5, 5, GETDATE(), 13000, 0),
(5, 5, GETDATE() + 1, 14000, 0),
(6, 5, GETDATE() - 1, 15000, 0),
(6, 5, GETDATE() + 1, 16000, 0),
(1, 1, GETDATE() - 2, 17000, 0),
(1, 1, GETDATE() + 2, 18000, 0)