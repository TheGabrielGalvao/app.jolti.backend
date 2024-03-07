IF NOT EXISTS (
    SELECT *
    FROM information_schema.tables 
    WHERE table_schema = 'auth' 
    AND table_name = 'UserGroup'
)
BEGIN
    CREATE TABLE auth.UserGroup(
		Id BIGINT PRIMARY KEY IDENTITY(1,1),
		Uuid UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
		Name VARCHAR(MAX) NOT NULL,
		Description VARCHAR(MAX) NOT NULL,
		Status INT NOT NULL,
		UserProfileId BIGINT FOREIGN KEY REFERENCES auth.UserProfile(Id) ON DELETE NO ACTION ON UPDATE NO ACTION
	)
END;
