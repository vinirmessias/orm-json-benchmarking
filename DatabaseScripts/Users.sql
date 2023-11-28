BEGIN TRAN
BEGIN TRY

	IF(OBJECT_ID('[Users]') IS NULL)
		BEGIN

			CREATE TABLE [Users](
				[Id] BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
				[Username] NVARCHAR(32) NOT NULL,
				[Password] NVARCHAR(11) NOT NULL,
				[Role] TINYINT NOT NULL,
				[CreationDate] DATETIME NOT NULL,
			)
			
			PRINT 'A tabela "Users" foi criada com sucesso.'
			
		END
	ELSE
	BEGIN
		PRINT 'A tabela "Users" já existe no banco de dados.'
	END
	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	PRINT 'Ocorreu um erro ao criar a tabela "Users": '+ ERROR_MESSAGE()
END CATCH