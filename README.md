## Criando seu E-commerce de Livros em C# e Angular

.....

---

# 📚 E-commerce de Livros — Backend (.NET 8 + PostgreSQL)

Este projeto é o Back-End de um e-commerce de livros, desenvolvido com **.NET 8**, **C# 12** e **Entity Framework Core**, utilizando **PostgreSQL** como banco de dados. Ele fornece uma API RESTful para listar, consultar e cadastrar livros, com estrutura moderna e escalável.

---

## 🧠 Funcionalidades da API

- `GET /api/livraria` — Lista todos os livros
- `GET /api/livraria/{id}` — Retorna um livro específico por ID
- `POST /api/livraria` — Cadastra um novo livro
- Todos os métodos são **assíncronos** com `async/await`
- Documentação automática via **Swagger**

---

## 🗂️ Estrutura de Pastas e Arquivos 

 
 
 <img width="970" height="837" alt="Screenshot_20251101-162038" src="https://github.com/user-attachments/assets/85ba9271-7ae0-48cb-9211-8ede802decc0" /> 


 ---

## 💻 Requisitos de Hardware

| Componente | Recomendado |
|------------|-------------|
| CPU        | Intel i5 ou superior |
| RAM        | 8 GB ou mais |
| Armazenamento | 2 GB livres |
| Banco de Dados | PostgreSQL 14+ instalado localmente |

---

## 🧰 Requisitos de Software

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)
- Ferramenta EF Core CLI:
  ```bash
  dotnet tool install --global dotnet-ef


---


⚙️ **Como Executar o Projeto**

1. Clone o repositório

`bash
git clone https://github.com/Santosdevbjj/ecommerceLivrosAngular
cd ecommerceLivrosAngular/Backend
`

2. Configure o PostgreSQL

Crie um banco chamado livraria e atualize o arquivo appsettings.json com suas credenciais:

`json
"ConnectionStrings": {
  "PostgresConnection": "Host=localhost;Port=5432;Database=livraria;Username=postgres;Password=senha"
}
`

3. Restaure os pacotes e aplique a migration

`bash
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
`

4. Execute a aplicação

`bash
dotnet run
`

A API estará disponível em: https://localhost:5001/swagger

---

🧪 Dados de Exemplo

O projeto inclui um script de inicialização (DbInitializer.cs) que insere automaticamente livros de exemplo no banco:

- O Senhor dos Anéis
- Clean Code
- Dom Casmurro

---

📌 Observações

- O projeto utiliza Entity Framework Core com Npgsql para integração com PostgreSQL.
- O banco é populado automaticamente na inicialização.
- O Swagger está habilitado em ambiente de desenvolvimento para testes rápidos.

---

📬 Contato

Desenvolvido por Sergio Santos  
Para dúvidas ou sugestões, abra uma issue no repositório.

---







 
