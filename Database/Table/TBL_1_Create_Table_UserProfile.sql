IF NOT EXISTS (
    SELECT *
    FROM information_schema.tables 
    WHERE table_schema = 'auth' 
    AND table_name = 'UserProfile'
)
BEGIN
	CREATE TABLE auth.UserProfile(
		Id BIGINT PRIMARY KEY IDENTITY(1,1),
		Uuid UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
		Name NVARCHAR(MAX) NOT NULL,
		Description NVARCHAR(MAX) NULL,
		Status INT NOT NULL,
		DefaultData INT NOT NULL DEFAULT 0
	)
    
END;
