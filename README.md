# Projeto movie-mvc
Projeto da documentação de mvc de asp.net core.

## Ferramentas

- Visual Studio Code
- Extensão C#
- AspNetCore.Mvc

## Pacotes

- Entity Framework Core: ```dotnet add package Microsoft.EntityFrameworkCore```
- SQLite: ```dotnet add package Microsoft.EntityFrameworkCore.SQLite```
- Scaffolding: ```dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design```

## Template inicial

- Criado projeto com ```dotnet new -o movie-mvc```
- Carregado com ```code -r movie-mvc```
- Certificado de desenvolvimento HTTPS  ```dotnet dev-certs https --trust```
- Lógica de roteamento de URL: ```/[Controller]/[ActionName]/[Parameters]```
- Formato de roteamento configurado no método ```Configure``` em ```Startup.cs```

### Exemplo de model binding

```cs
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Ola {name}, ID: {ID}");
        }
```

```https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&ID=4```
```https://localhost:{PORT}/HelloWorld/Welcome/3?name=Rick```