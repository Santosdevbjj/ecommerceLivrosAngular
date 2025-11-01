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

**1. Clone o repositório**

`bash
git clone https://github.com/Santosdevbjj/ecommerceLivrosAngular
cd ecommerceLivrosAngular/Backend
`

**2. Configure o PostgreSQL**

Crie um banco chamado livraria e atualize o arquivo appsettings.json com suas credenciais:

`json
"ConnectionStrings": {
  "PostgresConnection": "Host=localhost;Port=5432;Database=livraria;Username=postgres;Password=senha"
}
`

**3. Restaure os pacotes e aplique a migration**

`bash
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
`

**4. Execute a aplicação**

`bash
dotnet run
`

A API estará disponível em: https://localhost:5001/swagger

---

🧪 **Dados de Exemplo**

O projeto inclui um script de inicialização (DbInitializer.cs) que insere automaticamente livros de exemplo no banco:

- O Senhor dos Anéis
- Clean Code
- Dom Casmurro

---

📌 **Observações**

- O projeto utiliza Entity Framework Core com Npgsql para integração com PostgreSQL.
- O banco é populado automaticamente na inicialização.
- O Swagger está habilitado em ambiente de desenvolvimento para testes rápidos.

---

📬 **Contato**

Desenvolvido por Sergio Santos  
Para dúvidas ou sugestões, abra uma issue no repositório.

---

# 📘 E-commerce de Livros — Frontend Angular

Este projeto é o Front-End de um e-commerce de livros, desenvolvido com **Angular 16+**, **TypeScript** e **Bootstrap 5**. Ele consome a API REST criada em .NET 8 e exibe os livros de forma responsiva, com componentes reutilizáveis e design moderno.

---

## 🚀 Tecnologias Utilizadas

- **Angular 16+** — Framework SPA moderno e escalável
- **TypeScript** — Tipagem estática para maior segurança
- **Bootstrap 5** — Estilização responsiva e elegante
- **RxJS** — Programação reativa para chamadas assíncronas
- **HTTPClient** — Comunicação com a API de livros

---

## 🗂️ Estrutura de Pastas e Arquivos. 

<img width="977" height="1420" alt="Screenshot_20251101-163958" src="https://github.com/user-attachments/assets/7a989abb-36af-4efb-a9ed-eeacaf96aa70" />



---

---

## 💻 Requisitos de Hardware

| Componente     | Recomendado           |
|----------------|------------------------|
| CPU            | Intel i5 ou superior   |
| RAM            | 8 GB ou mais           |
| Armazenamento  | 2 GB livres            |
| Navegador      | Chrome, Edge ou Firefox |

---

## 🧰 Requisitos de Software

- [Node.js v18+](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [Git](https://git-scm.com/)
- Editor recomendado: [Visual Studio Code](https://code.visualstudio.com/)

---

## ⚙️ Como Executar o Projeto

### 1. Clone o repositório

```bash
git clone https://github.com/Santosdevbjj/ecommerceLivrosAngular
cd ecommerceLivrosAngular/Frontend

---
```

**2. Instale as dependências**

`bash
npm install
`

**3. Execute o projeto**

`bash
ng serve
`

Acesse no navegador: http://localhost:4200

---

🔗 **Integração com a API**

Certifique-se de que o projeto Backend esteja rodando em https://localhost:5001. O serviço produto.service.ts está configurado para consumir os dados da API de livros.

---

🧩 **Componentes Visuais**

**- NavComponent** — Menu superior com links
**- HeaderComponent** — Cabeçalho com título e descrição
**- FiltroProdutosComponent** — Campo de busca por título
**- ListaProdutosComponent** — Exibe os livros em cards
**- FooterComponent** — Rodapé com informações de copyright

---

📬 **Contato**

Desenvolvido por Sergio Santos  
Para dúvidas ou sugestões, abra uma issue no repositório.

---



🧭 **Navegação Rápida**

| Pasta/Arquivo                     | Função                                                                 |
|----------------------------------|------------------------------------------------------------------------|
| Backend/Controllers/           | Define os endpoints da API REST                                       |
| Backend/Data/                  | Gerencia o banco de dados e inicialização de dados                    |
| Backend/Models/                | Define os modelos de dados usados na API                              |
| Backend/Program.cs             | Configura e inicia o servidor da API                                  |
| Frontend/src/app/components/   | Contém todos os componentes visuais da interface                      |
| Frontend/src/app/services/     | Comunicação com a API via HTTP                                        |
| Frontend/src/app/models/       | Define a estrutura dos dados recebidos da API                         |
| Frontend/src/app/app.module.ts | Registra todos os componentes e módulos necessários                   |
| Frontend/src/app/app.component.html | Organiza visualmente os componentes na tela principal         |

--- 














 
