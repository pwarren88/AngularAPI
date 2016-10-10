/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Product(name, price, soldOut, canPurchase, [description])
VALUES ('Product 1', 2.00, 0, 1, 'This is product 1'),
	('Product 2', 4.00, 0, 1, 'This is product 2'),
	('Product 3', 2.50, 0, 1, 'This is product 3')