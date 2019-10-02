
insert into Pedidos
(Numero,ClienteId,Valor)
Values 
('N000000008',2,379.47),('N000000009',3,379.48),('N000000010',4,379.49)

	
select * from Pedidos
select * from Clientes

select * from Pedidos ped
inner join Clientes cli on ped.ClienteId=cli.Id
where cli.Id = 2


select IIF (SUM (ped.Valor)> 2000, 'Brinde Xiaomi','Não ganhou nada') as 'Resultado',
SUM(ped.Valor) as 'Total',
Cli.Nome
from Pedidos ped
inner join Clientes cli on ped.ClienteId=cli.Id
group by Cli.Id


select IIF (SUM (ped.Valor)> 2000, 'Brinde Xiaomi','Não ganhou nada') as 'Resultado',
SUM(ped.Valor) as 'Total',
Cli.Nome
from Clientes cli inner join Pedidos ped on Cli.Id = ped.ClienteId
group by Cli.Nome


