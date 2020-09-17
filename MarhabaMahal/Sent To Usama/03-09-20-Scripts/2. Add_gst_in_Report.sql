ALTER TABLE dbo.bill
    ADD gst_percent nvarchar(50) NOT NULL 
    CONSTRAINT gst_percent DEFAULT '16%'
    WITH VALUES;