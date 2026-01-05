# ⚙️ MinhaAPI – ASP.NET Core Web API

API desenvolvida em **ASP.NET Core Web API** com foco em **aprendizado de backend**, organização de projeto, uso de **Entity Framework Core** e construção de **endpoints REST**. Este projeto faz parte do meu processo de evolução como desenvolvedor **.NET**, sendo utilizado para estudo e portfólio.

---

## 🚀 Funcionalidades

* Estrutura básica de uma Web API
* Endpoints REST (GET, POST, PUT, DELETE)
* Separação de responsabilidades (Controllers, Models, Data)
* Persistência de dados com Entity Framework Core
* Configuração de banco de dados
* Testes de endpoints via Swagger

---

## 🛠️ Tecnologias Utilizadas

* **C#**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **Banco de Dados Relacional** (configurável)
* **Swagger / OpenAPI**

---

## 📂 Estrutura do Projeto

```bash
MinhaAPI/
│
├── Controllers/
│   └── *.cs
│
├── Models/
│   └── *.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Migrations/
├── Program.cs
└── appsettings.json
```

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

* .NET SDK 7 ou superior
* Visual Studio ou VS Code
* Banco de dados configurado no `appsettings.json`

### Passos

```bash
# Clone o repositório
git clone https://github.com/Daniel-Ferreira-2004/MinhaAPI.git

# Acesse a pasta
cd MinhaAPI

# Restaure os pacotes
dotnet restore

# Atualize o banco de dados
dotnet ef database update

# Execute o projeto
dotnet run
```

A API estará disponível em:

```
https://localhost:5001
```

---

## 📑 Documentação da API

A documentação interativa é disponibilizada via **Swagger**:

```
https://localhost:5001/swagger
```

---

## 🎯 Objetivo do Projeto

Este projeto foi desenvolvido para:

* Consolidar conceitos de **ASP.NET Core Web API**
* Praticar **CRUD e persistência de dados**
* Entender o fluxo de uma API REST em .NET
* Evoluir como desenvolvedor backend
* Compor portfólio para **vaga júnior .NET**

---

## 👨‍💻 Autor

**Daniel Ferreira**

* GitHub: [@Daniel-Ferreira-2004](https://github.com/Daniel-Ferreira-2004)

---

⭐ Se este projeto te ajudou ou serviu como referência, deixe uma estrela!
