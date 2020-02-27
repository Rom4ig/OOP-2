use University

insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Влад', 'ПОИТ', 19, '08-12-1998', 2, 'м', 8.0, BulkColumn
	from OpenRowSet(bulk N'F:\1.jpg', single_blob) as Файл;
insert into Student(NAME, SPECIALITY, AGE, BIRTHDAY, COURSE, SEX, AVGSCORE, FOTO) 
	select 'Иван', 'Программное обеспечение информационных технологий', 19, '12-10-1998', 2, 'м', 7.6, BulkColumn
	from OpenRowSet(bulk N'F:\2.jpg', single_blob) as Файл;

select * from Student
select * from [Address]
insert into [Address](StudentID, Town, [Index], Street, House, Flat) values
(100, 'Минск', 220006, 'Белорусская', 21, 404),
(101, 'Минск', 220006, 'Белорусская', 21, 404),
(102, 'Минск', 220052, 'Гурского', 21, 312),
(103, 'Минск', 220006, 'Белорусская', 21, 710)

