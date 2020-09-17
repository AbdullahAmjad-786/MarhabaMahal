ALTER TABLE dbo.pending_payment
    ADD gst int NOT NULL 
    CONSTRAINT gst DEFAULT 16
    WITH VALUES;