
## Description

Repositorio de estudos de ASP.NET com .net 10

## Project setup

## Compile and run the project

```bash
# Executar 
$ dotnet run --project <nome_do_projeto>

# development
$ dotnet run ou dotnet run --configuration Debug

dotnet run
# ou explicitamente
dotnet run --configuration Debug
```
## New Projetct - Comand lines

Comandos basicos uteis para criação de solução e projeto 


````bash
# Criar uma nova solução
$dotnet new sln -o nome_do_projeto
````
Acessa o diretório da solução que acabou de ser criado. A partir daqui, todos os próximos comandos serão executados dentro dessa pasta.


````bash  
#
$cd nome_do_projeto
````
Cria um novo projeto do tipo webapi dentro de uma pasta com o mesmo nome. Esse template já inclui um controlador de exemplo e configuração básica para uma API REST.


````bash 
#
$dotnet new webapi -o nome_do_projeto
````
Cria um novo projeto do tipo webapi dentro de uma pasta com o mesmo nome. Esse template já inclui um controlador de exemplo e configuração básica para uma API REST.


````bash 
#
$dotnet sln add ./nome_do_projeto/nome_do_projeto.csproj
````
 Adiciona o projeto criado à solução principal. Isso é importante para que o Visual Studio ou o comando dotnet reconheça a relação entre eles.


````bash 
#
$dotnet run --project nome_do_projeto
````
Compila e executa o projeto Web API recém-criado. Após alguns segundos, o terminal exibirá o endereço local onde a API está rodando, geralmente https://localhost:7000 ou http://localhost:5000.


#