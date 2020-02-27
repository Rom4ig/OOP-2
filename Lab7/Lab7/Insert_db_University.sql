use University

insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Булохова Валерия Юрьевна', 'ДЭиВИ', 19, '07-01-2000', 2, 'Ж', 8.0, BulkColumn
	from OpenRowSet(bulk N'D:\1.Учёба\4 СЕМЕСТР\Моё\ООП\лабы\OOTP_LAB_2-master\Lab7\Lab7\Foto\val.jpg', single_blob) as Файл;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Кулешова Елизавета Дмитриевна', 'ДЭиВИ', 19, '12-10-2000', 2, 'ж', 9.0, BulkColumn
	from OpenRowSet(bulk N'D:\1.Учёба\4 СЕМЕСТР\Моё\ООП\лабы\OOTP_LAB_2-master\Lab7\Lab7\Foto\liz.jpg', single_blob) as Файл;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Грунковский Роман Иванович', 'ПОИТ', 18, '30-07-1999', 2, 'м', 7.0, BulkColumn
	from OpenRowSet(bulk N'D:\1.Учёба\4 СЕМЕСТР\Моё\ООП\лабы\OOTP_LAB_2-master\Lab7\Lab7\Foto\rom.jpg', single_blob) as Файл;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Романцевич Дмитрий Андреевич', 'ДЭиВИ', 19, '13-04-2000', 2, 'ж', 8.5, BulkColumn
	from OpenRowSet(bulk N'D:\1.Учёба\4 СЕМЕСТР\Моё\ООП\лабы\OOTP_LAB_2-master\Lab7\Lab7\Foto\dim.jpg', single_blob) as Файл;

select * from Student
select * from [Address]
insert into [Address](StudentID, Town, [Index], Street, House, Flat) values
(100, 'Минск', 220006, 'Белорусская', 21, 404),
(101, 'Минск', 220006, 'Белорусская', 21, 404),
(102, 'Минск', 220052, 'Гурского', 21, 312),
(103, 'Минск', 220006, 'Белорусская', 21, 710)

drop table Student
drop table [Address]