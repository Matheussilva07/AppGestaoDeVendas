# 🛒 App Gestão de Vendas

![Imagem do App](src/assets/appGestaoVendas.png)

Sistema de gerenciamento de vendas desenvolvido com arquitetura em camadas e princípios do DDD (Domain-Driven Design). A aplicação é composta por uma API em C# integrada com banco de dados MySQL e um front-end desenvolvido em WinForms.

---

## 🧱 Arquitetura

O projeto segue os princípios da arquitetura em camadas e DDD (Domain-Driven Design), com separação clara entre as responsabilidades:

- **Domain**: Entidades de negócio e regras de domínio
- **Application**: Casos de uso e lógica de aplicação
- **Infrastructure**: Acesso a dados (Entity Framework + MySQL)
- **Presentation**: API ASP.NET Core (REST)
- **UI**: Interface de usuário com WinForms

---

## 🛠️ Tecnologias Utilizadas

### Backend

- **C# .NET**
- **ASP.NET Core Web API**
- **Entity Framework Core** – ORM para acesso a dados
- **MySQL** – Banco de dados relacional
- **FluentValidation** – Validações de entrada e regras de negócio
- **FluentAssertions** – Framework para testes unitários mais legíveis
- **AutoMapper** – Mapeamento entre DTOs e entidades

### Frontend

- **WinForms (.NET)** – Interface desktop para interação com o sistema

---

## ✅ Funcionalidades Principais

- Cadastro, edição e exclusão de produtos, clientes e vendas
- Registro de vendas com cálculo automático de totais
- Validações robustas com FluentValidation
- Testes unitários com FluentAssertions
- Interface amigável em WinForms

---

## 🚀 Como Executar o Projeto

### Requisitos

- .NET SDK 6.0 ou superior
- MySQL Server
- Visual Studio 2022 ou superior


 **Clone o repositório**
   ```bash
   git clone https://github.com/Matheussilva07/AppGestaoDeVendas.git
