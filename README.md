# MinimalApiProject 🚀

Uma Minimal API simples para gerenciamento de posts de blog. 
Desenvolvida com o objetivo de consolidar conhecimentos adquiridos no programa Dev Fullstack XP da DIO.

## Tecnologias Utilizadas 🛠️

Neste projeto da Minimal API, as seguintes tecnologias foram utilizadas:

- **C#**: Linguagem de programação principal utilizada para desenvolver a API.
- **.NET 8**: Plataforma de desenvolvimento para construir a Minimal API.
- **Entity Framework Core**: ORM (Object-Relational Mapping) utilizado para interagir com o banco de dados SQL Server.
- **SQL Server**: Sistema de gerenciamento de banco de dados utilizado para armazenar os dados da aplicação.
- **Swagger**: Ferramenta integrada para documentar e testar a API de forma interativa.
- **Visual Studio 2022**: IDE utilizada para desenvolvimento do projeto.
- **Git**: Sistema de controle de versão utilizado para gerenciamento do código fonte.
- **GitHub**: Plataforma utilizada para hospedar o repositório do projeto e facilitar a colaboração.

## Badges 🎖️

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![C#](https://img.shields.io/badge/C%23-12.0-orange)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-5B9BD5)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-5B9BD5)
![Swagger](https://img.shields.io/badge/Swagger-API-yellow)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5A2D8C)
![GitHub Repo stars](https://img.shields.io/github/stars/diegomarins33/MinimalApiProject?style=social)

-------------------------------------------------------------------------------------------------------
# Endpoints

## Descrição
Esta seção descreve os endpoints disponíveis para gerenciar posts na sua API.

**Classe Responsável**: `Program.cs`

**Base das URLs**: `/posts`

| Método | URL            | Descrição                           | Parâmetros                                   | Resposta                                                                 |
|--------|----------------|-------------------------------------|---------------------------------------------|-------------------------------------------------------------------------|
| POST   | /posts          | Cria um novo post.                 | `PostModel` (corpo da requisição)           | 201 Created - Post criado com sucesso, incluindo o ID do novo post no cabeçalho Location. |
| GET    | /posts          | Obtém todos os posts.              | -                                           | 200 OK - Lista de objetos `PostModel`.                                  |
| GET    | /posts/{id}     | Obtém um post específico pelo ID.  | `id` (int, path)                            | 200 OK - Objeto `PostModel` encontrado.<br>404 Not Found - Post não encontrado. |
| PUT    | /posts/{id}     | Atualiza um post existente.        | `id` (int, path), `PostModel` (corpo da requisição) | 204 No Content - Post atualizado com sucesso.<br>404 Not Found - Post não encontrado. |
| DELETE | /posts/{id}     | Exclui um post existente.          | `id` (int, path)                            | 204 No Content - Post excluído com sucesso.<br>404 Not Found - Post não encontrado. |

## Detalhes dos Endpoints:

### POST /posts

**Corpo da requisição**: Um objeto `PostModel` contendo as propriedades `Title` (string), `Content` (string), `CreatedAt` (DateTime) e `UpdatedAt` (DateTime).

**Resposta**: O post recém-criado com o ID incluído no cabeçalho Location para facilitar o acesso ao recurso recém-criado.

---

### GET /posts

**Resposta**: Uma lista de objetos `PostModel`, onde cada objeto representa um post.

---

### GET /posts/{id}

**Parâmetro id**: Um número inteiro representando o ID único do post a ser recuperado.

---

### PUT /posts/{id}

**Corpo da requisição**: Um objeto `PostModel` contendo as propriedades atualizadas do post.

**Observação**: Apenas as propriedades incluídas no corpo da requisição serão atualizadas.

---

### DELETE /posts/{id}

**Parâmetro id**: Um número inteiro representando o ID único do post a ser excluído.  


---

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes. 📝

Agradecemos por conferir o **MinimalApiProject**! 🎉 Sinta-se à vontade para contribuir, reportar problemas ou sugerir melhorias. 💡





