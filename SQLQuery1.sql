create database SoftManager;

use SoftManager;

create table estoque(id int identity primary key , codigo int , nome varchar(max) , descricao varchar(max), valorentrada float , valorsaida float , qtd int , minimoqtd int , desconto float);

insert into estoque(codigo , nome , descricao , valorentrada , valorsaida , qtd , minimoqtd , desconto) values (123465 , 'prod' , 'teste' , 152.6 , 165.9 , 100 , 10 , 5.6);

select * from estoque;
