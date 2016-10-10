CREATE PROCEDURE sp_AddReview
(
 @productId int,
 @stars int,
 @author nvarchar(500),
 @body ntext
 )
 AS
 INSERT INTO Review(
 ProductId,
 stars,
 author,
 body
 )
 VALUES(
 @productId,
 @stars,
 @author,
 @body
 )