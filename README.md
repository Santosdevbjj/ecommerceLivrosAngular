## Criando seu E-commerce de Livros: Backend, Frontend em C# 12, .NET 8 e Angular



<img width="1080" height="723" alt="Screenshot_20251101-171127" src="https://github.com/user-attachments/assets/1dba6483-162e-4336-bca0-2d73e5e927e6" /> 



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

---

 **Script de Deploy para Produção**

**1. Gere o build otimizado**

`bash
ng build --configuration production
`

> Isso criará os arquivos otimizados na pasta dist/livraria.

**2. Hospede os arquivos gerados**

Você pode usar qualquer servidor web estático, como:

✅ **Com http-server**

`bash
npm install -g http-server
http-server dist/livraria
`

✅ **Com NGINX (Linux)**

Configure o NGINX para servir os arquivos da pasta dist/livraria.

✅ **Com GitHub Pages**

**Use o pacote angular-cli-ghpages:**

`bash
npm install -g angular-cli-ghpages
ng build --configuration production --base-href "https://Santosdevbjj.github.io/ecommerceLivrosAngular/"
npx angular-cli-ghpages --dir=dist/livraria
`

--- 

# 🚀 Deploy do Frontend Angular — Livraria Online

Este guia explica como publicar o projeto Frontend Angular do e-commerce de livros em ambiente de produção. O projeto foi desenvolvido com Angular 16+ e está pronto para ser hospedado em servidores estáticos, GitHub Pages ou serviços como NGINX.

---

## 📦 Pré-requisitos

Antes de iniciar o deploy, certifique-se de que:

- O projeto está funcionando localmente (`ng serve`)
- O Backend (.NET 8) está hospedado ou acessível via HTTPS
- O Angular CLI está instalado:
  ```bash
  npm install -g @angular/cli



  ---

  
---

🛠️ **Gerar o Build de Produção**

Execute o comando abaixo para gerar os arquivos otimizados:

`bash
ng build --configuration production
`

Os arquivos serão gerados na pasta:

`
dist/livraria/
`

---

🌐 **Opções de Deploy**

✅ 1. GitHub Pages

Ideal para projetos públicos e hospedagem gratuita.

Instale o pacote:

`bash
npm install -g angular-cli-ghpages
`

Gere o build com base-href:

`bash
ng build --configuration production --base-href "https://Santosdevbjj.github.io/ecommerceLivrosAngular/"
`

Publique:

`bash
npx angular-cli-ghpages --dir=dist/livraria
`

> Acesse: https://Santosdevbjj.github.io/ecommerceLivrosAngular/

---

✅ 2. Servidor Estático com http-server

Instale o servidor:

`bash
npm install -g http-server
`

Execute:

`bash
http-server dist/livraria
`

> Acesse: http://localhost:8080

---

✅ **3. NGINX (Linux)**

Configure o NGINX para servir os arquivos da pasta dist/livraria.

Exemplo de configuração:

`nginx
server {
  listen 80;
  server_name livraria.local;

  location / {
    root /caminho/para/dist/livraria;
    index index.html;
    try_files $uri $uri/ /index.html;
  }
}
`

Reinicie o NGINX:

`bash
sudo systemctl restart nginx
`

---

🔗 **Integração com a API**

Certifique-se de que o serviço Backend esteja acessível via HTTPS, por exemplo:

`ts
private apiUrl = 'https://meusite.com/api/livraria';
`

Atualize o produto.service.ts com o endpoint correto.

---

📬 **Contato**

Desenvolvido por Sergio Santos  
Para dúvidas ou sugestões, abra uma issue no repositório.

---
`

---



# 🚀 Deploy do Backend (.NET 8) — Livraria Online

Este guia explica como publicar o projeto Backend do e-commerce de livros, desenvolvido com .NET 8 e C# 12, utilizando PostgreSQL como banco de dados. O projeto pode ser hospedado em serviços como Azure, Railway ou VPS Linux.

---

## 📦 Pré-requisitos

Antes de iniciar o deploy, certifique-se de que:

- O projeto está funcionando localmente (`dotnet run`)
- O banco de dados PostgreSQL está configurado e acessível
- Você possui uma conta nos serviços desejados (Azure, Railway ou VPS)

---

## ☁️ Opção 1: Azure App Service

### 1. Instale a CLI do Azure

```bash
npm install -g azure-functions-core-tools
az login

---
```


**2. Crie o App Service**

`bash
az webapp up --name livraria-api --resource-group LivrariaRG --runtime "DOTNET|8.0"
`

**3. Configure a string de conexão**

`bash
az webapp config connection-string set \
  --name livraria-api \
  --resource-group LivrariaRG \
  --settings PostgresConnection="Host=...;Database=...;Username=...;Password=..." \
  --connection-string-type PostgreSQL
`

**4. Publique o projeto**

`bash
dotnet publish -c Release
az webapp deploy --name livraria-api --resource-group LivrariaRG --src-path ./bin/Release/net8.0/publish
`

---

🚉 **Opção 2: Railway**

1. Crie um projeto no Railway

- Acesse railway.app
- Crie um novo projeto e selecione "Deploy from GitHub"

**2. Configure variáveis de ambiente**

Adicione a variável PostgresConnection com sua string de conexão PostgreSQL.

**3. Configure o railway.json (opcional)**

`json
{
  "build": {
    "builder": "dotnet",
    "buildCommand": "dotnet publish -c Release",
    "startCommand": "dotnet Backend.dll"
  }
}
`

> **Railway detecta automaticamente projetos .NET e PostgreSQL.**

---

🖥️ **Opção 3: VPS Linux (Ubuntu + NGINX)**

**1. Instale o .NET 8 no servidor**

`bash
wget https://dotnet.microsoft.com/download/dotnet/scripts/v1/dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh -c 8.0
`


**2. Publique o projeto localmente**

`bash
dotnet publish -c Release -o ./publish
`

**3. Transfira os arquivos para o VPS**

`bash
scp -r ./publish user@vps:/var/www/livraria-api
`

**4. Configure o NGINX**

`nginx
server {
  listen 80;
  server_name api.livraria.com;

  location / {
    proxy_pass         http://localhost:5000;
    proxyhttpversion 1.1;
    proxysetheader   Upgrade $http_upgrade;
    proxysetheader   Connection keep-alive;
    proxysetheader   Host $host;
    proxycachebypass $http_upgrade;
  }
}
`

**5. Execute o projeto no VPS**

`bash
cd /var/www/livraria-api
dotnet Backend.dll
`

---

🔗 **Integração com o Frontend**

Certifique-se de que o Frontend Angular esteja configurado para consumir a API publicada:

`ts
private apiUrl = 'https://api.livraria.com/api/livraria';
`

---

📬 **Contato**


[![Portfólio Sérgio Santos](https://img.shields.io/badge/Portfólio-Sérgio_Santos-111827?style=for-the-badge&logo=githubpages&logoColor=00eaff)](https://santosdevbjj.github.io/portfolio/)
[![LinkedIn Sérgio Santos](https://img.shields.io/badge/LinkedIn-Sérgio_Santos-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://linkedin.com/in/santossergioluiz)

---














 
