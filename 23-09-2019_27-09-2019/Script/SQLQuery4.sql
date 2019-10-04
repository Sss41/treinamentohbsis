update Marcas set UsuInc=1 where UsuInc=0


select * from Marcas where UsuInc=1

select * from Marcas where UsuInc=2

select mar.Nome
from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe %'


select mar.Nome
from Marcas mar inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar %'


select  Usuarios.Usuario,count (Marcas.UsuInc) as 'Qtde  de marcas'from Marcas  
inner join Usuarios  on Marcas.UsuInc = Usuarios.Id
where Usuarios.Usuario  like 'Felipe' group by Usuarios.Usuario	order by  Usuarios.Usuario desc


select  Usuarios.Usuario,count (Marcas.UsuInc) as 'Qtde  de marcas'from Marcas  
inner join Usuarios  on Marcas.UsuInc = Usuarios.Id
where Usuarios.Usuario  like 'Giomar' group by Usuarios.Usuario	order by  Usuarios.Usuario asc


select  Usuarios.Usuario,count (Marcas.UsuInc) as 'Qtde  de marcas'from Marcas  
inner join Usuarios  on Marcas.UsuInc = Usuarios.Id
 group by Usuarios.Usuario	order by  Usuarios.Usuario desc


 
select  Usuarios.Usuario,Carros.Modelo as 'Modelo'from Carros 
inner join Usuarios  on Carros.UsuInc = Usuarios.Id
where Usuarios.Usuario  like 'Felipe' order by Usuarios.Usuario desc		

 
select  Usuarios.Usuario,Carros.Modelo as 'Modelo'from Carros 
inner join Usuarios  on Carros.UsuInc = Usuarios.Id
where Usuarios.Usuario  like 'Giomar' order by Usuarios.Usuario desc		


