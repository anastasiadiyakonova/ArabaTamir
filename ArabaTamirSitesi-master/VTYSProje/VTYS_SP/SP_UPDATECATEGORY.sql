CREATE PROCEDURE SP_UPDATECATEGORY
@NAME AS NVARCHAR(100),
@DESCRİPTİON AS NVARCHAR(100),
@BRANDID AS INT,
@CATEGORY1ID AS INT,
@FILTRE AS INT
AS
UPDATE Category 
SET [Name]=@NAME, [Description]=@DESCRİPTİON,[BrandId]=@BRANDID, [Category1Id]=@CATEGORY1ID
WHERE Id=@FILTRE

