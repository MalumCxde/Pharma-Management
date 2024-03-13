-- Insert 10 dummy data records into MedicineTbl using existing company names from CompanyTbl
INSERT INTO MedicineTbl (MedName, BuyingPrice, SellingPrice, MedQty, ExpDate, Company)
SELECT TOP 100
    -- Randomly select a medicine name from MedicineNames
    MedName,
    -- Generate random buying price between 1 and 100 for each record
    FLOOR(RAND(CHECKSUM(NEWID()))*(100-1+1)+1) AS BuyingPrice,
    -- Generate random selling price between 1 and 200 for each record
    FLOOR(RAND(CHECKSUM(NEWID()))*(200-1+1)+1) AS SellingPrice,
    -- Generate random quantity between 10 and 1000 for each record
    FLOOR(RAND(CHECKSUM(NEWID()))*(1000-10+1)+10) AS MedQty,
    -- Generate random expiration date within the next year for each record
    DATEADD(day, FLOOR(RAND(CHECKSUM(NEWID()))*(365)), GETDATE()) AS ExpDate,
    -- Select random company name from existing CompanyTbl
    CompName
FROM MedicineNames
CROSS JOIN CompanyTbl
ORDER BY NEWID();

