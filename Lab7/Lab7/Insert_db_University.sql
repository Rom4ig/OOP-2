use University

insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '�������� ������� �������', '�����', 19, '07-01-2000', 2, '�', 8.0, BulkColumn
	from OpenRowSet(bulk N'D:\1.�����\4 �������\��\���\����\OOTP_LAB_2-master\Lab7\Lab7\Foto\val.jpg', single_blob) as ����;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '�������� ��������� ����������', '�����', 19, '12-10-2000', 2, '�', 9.0, BulkColumn
	from OpenRowSet(bulk N'D:\1.�����\4 �������\��\���\����\OOTP_LAB_2-master\Lab7\Lab7\Foto\liz.jpg', single_blob) as ����;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '����������� ����� ��������', '����', 18, '30-07-1999', 2, '�', 7.0, BulkColumn
	from OpenRowSet(bulk N'D:\1.�����\4 �������\��\���\����\OOTP_LAB_2-master\Lab7\Lab7\Foto\rom.jpg', single_blob) as ����;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select '���������� ������� ���������', '�����', 19, '13-04-2000', 2, '�', 8.5, BulkColumn
	from OpenRowSet(bulk N'D:\1.�����\4 �������\��\���\����\OOTP_LAB_2-master\Lab7\Lab7\Foto\dim.jpg', single_blob) as ����;

select * from Student
select * from [Address]
insert into [Address](StudentID, Town, [Index], Street, House, Flat) values
(100, '�����', 220006, '�����������', 21, 404),
(101, '�����', 220006, '�����������', 21, 404),
(102, '�����', 220052, '��������', 21, 312),
(103, '�����', 220006, '�����������', 21, 710)

drop table Student
drop table [Address]