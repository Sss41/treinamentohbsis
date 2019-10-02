 select * from Clientes;
 select * from Pedidos;

 select * from Pedidos ped
 where ped.ClienteId in (select Cli.Id from Clientes cli
           inner join Pedidos ped on cli.Id = ped.ClienteId
 where ped.Numero in ('N000000001','N000000006','N0000000013'))
 order by ped.Valor desc