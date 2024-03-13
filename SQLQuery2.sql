DECLARE @MedicineNames TABLE (Name VARCHAR(100))
INSERT INTO @MedicineNames (Name)
VALUES
    ('Aspirin'),
    ('Paracetamol'),
    ('Ibuprofen'),
    ('Amoxicillin'),
    ('Lisinopril'),
    ('Metformin'),
    ('Simvastatin'),
    ('Loratadine'),
    ('Omeprazole'),
    ('Fluoxetine'),
    ('Albuterol'),
    ('Prednisone'),
    ('Atorvastatin'),
    ('Levothyroxine'),
    ('Ranitidine'),
    ('Losartan'),
    ('Citalopram'),
    ('Metoprolol'),
    ('Cephalexin'),
    ('Furosemide')


INSERT INTO MedicineTbl (MedName, BuyingPrice, SellingPrice, MedQty, ExpDate, Company)
SELECT
    Name AS MedName,
    ROUND(RAND() * 100, 2) AS BuyingPrice,
    ROUND(RAND() * 200, 2) AS SellingPrice,
    FLOOR(RAND() * 1000) AS MedQty,
    DATEADD(day, RAND() * 365, GETDATE()) AS ExpDate,
    CompName
FROM
    (SELECT TOP 148 ROW_NUMBER() OVER (ORDER BY CompID) AS n FROM CompanyTbl) AS Numbers,
    CompanyTbl,
    @MedicineNames
WHERE
    Name NOT IN (SELECT MedName FROM MedicineTbl);
