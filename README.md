# Gerador de Folha de Pagamento

O Gerador de Folha de Pagamento é um sistema desenvolvido em ASP.NET Core MVC que permite o cadastro e gerenciamento de colaboradores, além de oferecer funcionalidades para a geração de holerites.

## Funcionalidades

- Cadastro de Colaboradores
- Edição de Informações de Colaboradores
- Exclusão de Colaboradores
- Geração de Holerites

## Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) instalado
- Um ambiente de desenvolvimento para C# (como Visual Studio ou Visual Studio Code)

## Configuração do Projeto

1. Clone o repositório para sua máquina local.
2. Abra o projeto em seu ambiente de desenvolvimento.

## Executando o Projeto

1. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
2. Abra o terminal e navegue até a pasta raiz do projeto.
3. Execute o comando `dotnet ef database update` para aplicar as migrações ao banco de dados.
4. Inicie o projeto pressionando F5 ou execute `dotnet run` no terminal.

## Tecnologias Utilizadas

- ASP.NET Core MVC
- C#
- Entity Framework Core
- HTML/CSS
- Razor

## Contribuindo

1. Faça um fork do projeto.
2. Crie uma branch para sua nova feature (`git checkout -b feature/nova-feature`).
3. Faça commit das suas alterações (`git commit -m 'Adicionando nova feature'`).
4. Faça push para o repositório (`git push origin feature/nova-feature`).
5. Crie um novo Pull Request.

## Licença

Este projeto está sob a [Licença MIT](LICENSE).
