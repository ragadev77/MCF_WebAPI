CREATE TABLE dbo."tr_bpkb" (
	agreement_number varchar(100) CONSTRAINT tr_bpkb_an_pk PRIMARY KEY,
	bpkb_no varchar(100) NULL,
	bpkb_date datetime NULL,
	faktur_no varchar(10) NULL,
	faktur_date datetime NULL,
	LocationId varchar(10) CONSTRAINT tb_locid_fk REFERENCES ms_storage_location(LocationId), 
	police_no varchar(20),
	bpkb_date_in datetime null
);

CREATE TABLE dbo."ms_storage_location" (
	LocationId varchar(10) CONSTRAINT msl_li_pk PRIMARY KEY,
	LocationName varchar(100) NULL
);

INSERT INTO ms_storage_location 
SELECT '111','Main Warehouse'
UNION ALL 
SELECT '222','Temp Warehouse'
UNION ALL 
SELECT '333','Location 333';