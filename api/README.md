
## Passos iniciais com DOTNET no MACOS

### Baixar o sdk do .net core
https://dotnet.microsoft.com/download


### Criando um novo projeto api no terminal
`dotnet new webapi -n api`

Quando roda o comando acima já é realizado o build da api, criando os diretórios `bin` e `obj`.


### Para fazer um novo build, digite
`dotnet build`

### Para rodar o projeto (o build será executado novamente)
`dotnet run` 

### Rodar com o observador
`dotnet watch run`

## Após criar as models e configurar o sqllite

Criar uma migrate

`dotnet ef migrations add init`

Remover uma migrate

`dotnet ef migrations add remove`

Executar a migrate

`dotnet ef database update` 



