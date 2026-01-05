[🛠️ MinhaAPI – Meu Primeiro Sistema CRUD com ASP.NET Core
Este projeto marca o início da minha jornada no desenvolvimento de APIs com ASP.NET Core. Através dele, implementei um sistema básico de cadastro de produtos, aplicando os conceitos fundamentais de um CRUD (Create, Read, Update, Delete). Foi uma experiência enriquecedora que me proporcionou aprendizado prático e compreensão dos fluxos de dados em aplicações web.

🧰 Tecnologias Utilizadas
C#: Linguagem de programação principal para o desenvolvimento da API.

ASP.NET Core: Framework da Microsoft para construção de aplicações web e APIs.

Entity Framework Core: ORM (Object-Relational Mapper) utilizado para interagir com o banco de dados de forma eficiente e segura.

SQL Server: Sistema de gerenciamento de banco de dados utilizado para armazenar as informações dos produtos.

Swagger UI: Interface interativa para documentação e testes da API.

📂 Estrutura do Projeto
bash
Copiar
Editar
MinhaAPI/
├── Controllers/
│   └── ProductController.cs      # Controlador responsável pelas operações de produtos
├── Models/
│   └── Product.cs                # Modelo de dados do produto
├── Data/
│   └── ApplicationDbContext.cs   # Contexto do banco de dados
├── Program.cs                    # Ponto de entrada da aplicação
└── Startup.cs                    # Configurações e serviços da aplicação
🚀 Como Executar o Projeto Localmente
Clone o repositório:

bash
Copiar
Editar
git clone https://github.com/Daniel-Ferreira-2004/MinhaAPI.git
Abra a solução no Visual Studio ou Visual Studio Code.

Restaure os pacotes NuGet:

bash
Copiar
Editar
dotnet restore
Crie e aplique as migrações do banco de dados:

bash
Copiar
Editar
dotnet ef migrations add InitialCreate
dotnet ef database update
Execute o projeto:

bash
Copiar
Editar
dotnet run

📝 Funcionalidades Implementadas
Cadastro de Produtos: Permite o registro de novos produtos no sistema, incluindo informações como nome, descrição, preço e quantidade em estoque.

Validação de Dados: Implementação de validações para garantir a integridade e consistência dos dados inseridos.

Persistência de Dados: Utilização do Entity Framework Core para salvar e recuperar informações do banco de dados SQL Server.

📊 Visualização e Interação com a API via Swagger UI
A interface do Swagger UI oferece uma maneira prática e interativa de visualizar e testar os endpoints da API. Ao acessar a URL https://daniel-ferreira-2004.github.io/MinhaAPI/, você encontrará uma documentação gerada automaticamente que descreve os métodos disponíveis, parâmetros esperados e exemplos de respostas.
Microsoft Learn
+2
Mauro Souza
+2
DEV Community
+2
Medium

Funcionalidades do Swagger UI:
Visualização dos Endpoints: Exibe todos os métodos disponíveis na API, como GET, POST, PUT e DELETE.

Testes Interativos: Permite enviar requisições diretamente da interface, facilitando a validação e depuração dos endpoints.

Documentação Dinâmica: Atualiza automaticamente conforme alterações no código, refletindo as mudanças nos métodos e parâmetros.
Mauro Souza

Essa ferramenta foi fundamental para o desenvolvimento e testes da API, proporcionando uma maneira eficiente de interagir com os endpoints e verificar seu comportamento em tempo real.

🎯 Objetivos Alcançados
Compreensão dos conceitos de CRUD e sua aplicação prática em uma API.

Aprendizado sobre a utilização do Entity Framework Core para manipulação de dados.

Experiência no desenvolvimento de APIs RESTful com ASP.NET Core.

Familiarização com ferramentas de documentação e testes de APIs, como o Swagger UI.
](https://github.com/Daniel-Ferreira-2004/EscolaAPI)
