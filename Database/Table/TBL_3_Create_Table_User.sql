IF NOT EXISTS (
    SELECT *
    FROM information_schema.tables 
    WHERE table_schema = 'auth' 
    AND table_name = 'Users'
)
BEGIN
    CREATE TABLE auth.Users (
        Id BIGINT PRIMARY KEY IDENTITY(1,1),
        Uuid UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
        UserEmail VARCHAR(45) NOT NULL,
        UserName VARCHAR(45) NOT NULL,
        UserPass VARCHAR(255) NOT NULL,
        Status INT NOT NULL,
        UserProfileId BIGINT FOREIGN KEY REFERENCES auth.UserProfile(Id) ON DELETE NO ACTION ON UPDATE NO ACTION
    );
	

END;
