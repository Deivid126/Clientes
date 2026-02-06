# Clientes API

API REST desenvolvida em .NET 8 para cadastro e consulta de clientes, seguindo princípios de arquitetura limpa e boas práticas.

## 📌 Funcionalidades

- Cadastrar cliente
- Listar clientes
- Validação de dados
- Prevenção de e-mails duplicados
- Logs de execução
- Mapeamento automático com AutoMapper
- Persistência em memória (InMemory)

---

## 🛠️ Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- AutoMapper
- FluentValidation
- Swagger (OpenAPI)
- Logging nativo (.NET ILogger)
- Git

---

## 📁 Estrutura do Projeto

Clientes
│
├── Clientes.API → Camada de apresentação (Controllers)
├── Clientes.Application → Regras de negócio, Services, DTOs
├── Clientes.Domain → Entidades e regras do domínio
├── Clientes.Infra → Repositórios e persistência
└── Clientes.sln

## 🧱 Arquitetura

O projeto segue o padrão **Clean Architecture**, separando responsabilidades em camadas bem definidas:

### Domain
- Contém as entidades principais
- Não depende de nenhuma outra camada

### Application
- Contém serviços, DTOs e validações
- Orquestra as regras de negócio

### Infra
- Implementa acesso a dados
- Repositório em memória

### API
- Exposição dos endpoints
- Controllers
- Configurações

Essa separação facilita:
- Manutenção
- Testes
- Evolução do sistema
- Substituição de infraestrutura

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

- .NET SDK 8 ou superior
- Visual Studio / VS Code / Terminal

Verifique:
dotnet --version

Baixe em:
git clone <url-do-repositorio>

Vá até:
cd Clientes

Execute:
dotnet restore

Rode:
dotnet run --project Clientes.API

Acesse em (ou na porta desejada):
https://localhost:7222/swagger


