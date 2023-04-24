CREATE TABLE Producto(
IdProducto INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50),
Precio MONEY,
Fecha DATE
)
 -------------------------------
 INSERT INTO [dbo].[Producto]
           ([Nombre]
           ,[Precio]
           ,[Fecha])
     VALUES('Leche',12,'12/15/2010')
----------------------------------
UPDATE [dbo].[Producto]
   SET [Nombre] = 'Leche Entera'
 WHERE  IdProducto=1
 ----------------------------------
 SELECT [IdProducto]
      ,[Nombre]
      ,[Precio]
      ,[Fecha]
  FROM [dbo].[Producto]
  WHERE Precio>5
  ------------------------------
  DELETE FROM dbo.Producto
