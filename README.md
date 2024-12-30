# CRUD de Produtos com PostgreSQL e C#

Este é um projeto CRUD (Create, Read, Update, Delete) para gerenciar produtos utilizando C# com Windows Forms, PostgreSQL como banco de dados e a biblioteca Npgsql para conexão, instalada via NuGet. O projeto inclui funções de verificação, adição, edição, exclusão e exibição de produtos em um DataGridView.

---

## 🔧 Requisitos

Antes de iniciar o projeto, certifique-se de ter instalado:

- [Visual Studio 2019 ou superior](https://visualstudio.microsoft.com/)
- [.NET Framework 4.7.2 ou superior](https://dotnet.microsoft.com/)
- [PostgreSQL 12 ou superior](https://www.postgresql.org/)
- Biblioteca Npgsql (instalada via NuGet no Visual Studio)

---

## 🗃️ Configuração do Banco de Dados

1. Crie o banco de dados no PostgreSQL:

   ```sql
   CREATE DATABASE loja;
   ```

2. Conecte-se ao banco de dados e crie a tabela `produtos`:

   ```sql
   CREATE TABLE produtos (
       id SERIAL PRIMARY KEY NOT NULL,
       nome VARCHAR(255),
       descricao VARCHAR(255),
       valor DECIMAL,
       estoque INT
   );
   ```

3. Insira alguns dados iniciais para testes:

   ```sql
   INSERT INTO produtos (nome, descricao, valor, estoque)
   VALUES ('Teclado Mecânico', 'Teclado RGB com switches mecânicos', 350, 15);
   ```

---

## 📖 Instalação

1. Clone o repositório do GitHub:

   ```bash
   git clone https://github.com/pequenu/CSharp-WinForm-Crud.git
   ```

2. Abra o projeto no Visual Studio.

3. Configure a string de conexão no código:

   ```csharp
   private string conexao = "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=loja";
   ```

4. Certifique-se de instalar a biblioteca Npgsql pelo NuGet:

   - No Visual Studio, vá até **Ferramentas** > **Gerenciador de Pacotes NuGet** > **Gerenciar Pacotes para Solução**.
   - Pesquise por `Npgsql` e clique em **Instalar**.

5. Compile e execute o projeto.

