IF NOT EXISTS (
    SELECT *
    FROM auth.UserProfile 
    WHERE DefaultData = 1
    AND Name = 'ADMIN'
)
BEGIN
BEGIN TRAN
    INSERT INTO auth.UserProfile (Name, Description, Status, DefaultData)
    VALUES ('ADMIN', 'Perfil Padrão', 1, 1)
COMMIT	

END;
