/*insert into PlayList1 (Nome, Artista,Genero)values('Love on the brain','Rihanna','Pop')
insert into PlayList1 (Nome, Artista,Genero)values('Shakira','Totura','Pop')
insert into PlayList1 (Nome, Artista,Genero)values(' Skank','lugar difernte','Pop')
insert into PlayList1 (Nome, Artista,Genero)values('Anita','Poderosa','Pop')
insert into PlayList1 (Nome, Artista,Genero)values('Pablo Vittar','Bem na sua cara','Pop')
insert into PlayList1 (Nome, Artista,Genero)values('Gloria goove','Bum bum de ouro','Pop')
insert into PlayList1 (Nome, Artista,Genero)values('Karol Konk','È o poder','Pop')
insert into PlayList1 (Nome, Artista,Genero)values('Isa','Pesdão','Pop')
insert into PlayList1 (Nome, Artista,Genero)values('Elza Soares','Penha','Samba')
insert into PlayList1 (Nome, Artista,Genero)values('Beyonce','Turn left','Rock')
 
 Select   Genero,Count(Artista) from Playlist1
 group by Genero

  
   select Artista, Count(Nome) from Playlist1
   group by Artista

   select Nome,Count(Nome) from Playlist1
   group by Nome*/


   insert into genero values ('Pop'),('Samba'),('Rock')
    select * from Genero

	insert into Artistas (GeneroId,Nome) values('Shakira')
	insert into Artistas (GeneroId,Nome) values('Elza Soares')
	insert into Artistas (GeneroId,Nome) values('Beyonce')

	select*from Artistas

	Insert into Cancoes(ArtistasId,Nome)Values('Totura')
	Insert into Cancoes(ArtistasId,Nome)Values('Turn left')
	Insert into Cancoes(ArtistasId,Nome)Values('Penha')

select gen.Nome,
	   art.Nome,  
	   can.nome from  Genero gen 
	   inner join Artistas art  on Gen.Id =  art.GeneroId
	   inner join Cancoes can on  art.Id = can.ARTISTASID

select gen.Nome as 'Genero',
Count(art. Nome) as 'Quantidade Artistas'
from Genero gen
inner join Artistas art on gen.Id = art.GENEROID
group by gen.Nome-- group by agrupa as tabelas


select gen.Nome as 'Genero',
Count(art. Nome) as 'Quantidade Artistas'
from Genero gen
inner join Artistas art on gen.Id = art.GENEROID
inner join CANCOES can on art.Id = can.ARTISTASID  
group by gen.Nome
