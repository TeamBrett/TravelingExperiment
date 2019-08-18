
select *
from Player
order by name

insert into Player ([Name], GenderId)
values('Slagathor', 1)

update Player set Name = 'Padwin' where Id = 3

delete player where id = 2

insert into Player (Name, GenderId)
values('Max', 1)


create table Gender(
	Id smallint not null Primary key,
	Name nchar(25) not null,
	DisplayIndex int not null
)

drop table Gender

insert into Gender (id, name, DisplayIndex) values
  (1, 'Male', 1)
, (2, 'Female', 2)
, (3, 'Non Binary', 3)

alter table player add constraint FK__player__gender foreign key (GenderId) references Gender(Id)


select p.id, p.name as PlayerName, g.name as Gender
from player p
join gender g on p.GenderId = g.Id
order by p.Name

update player set genderid = 2 where id = 3

-- dudes or chicks?
select count(*)
from player p
join gender g on p.GenderId = g.Id
where g.name = 'Male'


select g.name, count(*)
from player p
join gender g on p.GenderId = g.Id
group by g.name


from player p
where p.genderid = 3
select p.name


-- change column definition
alter table gender alter column name nvarchar(25) not null

-- rename column
EXEC sp_rename 'Test.dbo.Gender', 'GenderId', 'COLUMN';

begin transaction
	insert into gender(id, name, displayindex)values(10, 'alien', 500)

	insert into Player ([Name], GenderId)
	values('Beau', 10)

	select * from player

--rollback
commit

select * from player
