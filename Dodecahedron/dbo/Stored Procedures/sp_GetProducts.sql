	CREATE PROCEDURE sp_GetProducts AS

	SELECT 
		id, 
		canPurchase, 
		soldOut, 
		name, 
		price, 
		[description]
	FROM
		Product