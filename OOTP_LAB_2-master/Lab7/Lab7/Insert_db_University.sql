use University

insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '����', '����', 19, '08-12-1998', 2, '�', 8.0, BulkColumn
	from OpenRowSet(bulk N'F:\1.jpg', single_blob) as ����;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '����', '����������� ����������� �������������� ����������', 19, '12-10-1998', 2, '�', 7.6, BulkColumn
	from OpenRowSet(bulk N'F:\2.jpg', single_blob) as ����;

select * from Student
select * from [Address]
insert into [Address](StudentID, Town, [Index], Street, House, Flat) values
(100, '�����', 220006, '�����������', 21, 404),
(101, '�����', 220006, '�����������', 21, 404),
(102, '�����', 220052, '��������', 21, 312),
(103, '�����', 220006, '�����������', 21, 710)

