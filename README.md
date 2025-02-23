# Projeto .NET 8 Web API - product Crus

Este projeto é uma aplicação ASP.NET Core 8 com SQLite embutido, oferecendo uma API que pode ser facilmente testada através do Swagger. 
A base de dados está armazenada localmente no diretório Db/, utilizando o SQLite como banco de dados embutido.

## 📂 Estrutura do Projeto

A estrutura do projeto é a seguinte:

```
.
├── document/             # Diretório com o documento que contém as respostas teóricas do teste
├── Product.Api/          # Projeto principal com as recursos de crud da aplicação
├── Product.Test/         # Projeto de Testes unitários da solução
├── ProductSolution.sln   # Arquivo de solução do Visual Studio
```

---

## 🚀 Como Executar o Projeto

### Funcionalidades

Banco de Dados Embutido: A base de dados SQLite está embutida no projeto e armazenada dentro da pasta Db/.
API Documentada com Swagger: A API expõe endpoints documentados, que podem ser testados diretamente através da interface do Swagger.
Testes Unitários: O projeto inclui testes unitários que podem ser executados para verificar o funcionamento da aplicação.

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

---

### 1. Executando o projeto

1. **Clonar o repositorio**:
   Clone o repositório para sua maquina local:

   ```bash
   git clone https://github.com/roberth-silva/ProductSolution.git
   cd seu-repositorio
   ```

2. **Restaurar as dependencias**:
   Restaure as dependencias do projeto:

   ```bash
   dotnet restore
   ```

3. **Banco de dados e migrations**:
   A base de dados está localizada dentro do diretorio Db do projeto Product.Api
   A base de dados SQLite já está inclusao ao projeo, no entanto, pode ser criada novamente ao executar manualmente a migração com os seguintes comandos dentro da raiz do projeto Product.Api:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
      
4. **Executar o projeto**:
   Para executar a aplicação, use o comando:   

   ```bash
   dotnet run
   ```
   A API estará disponível em `http://localhost:5000` ou `https://localhost:5001`.


---

### 2. Como usar o Swagger

1. **Visualizando o Swagger**:
   Após rodar o projeto, abra o navegador e acesse a URL:

   ```bash
   http://localhost:5000/swagger
   ```


2. **Acessar a API**:
   A interface do Swagger estará disponível e você poderá interagir com a API, testar os endpoints e visualizar a documentação.

3. **Comandos do Controller no Swagger**:
   Aqui estão alguns exemplos de comandos que podem estar disponíveis no Swagger:

* GET /api/product: Recupera todos os produtos.
* GET /api/product/{id}: Recupera um produto específico pelo ID.
* POST /api/product: Cria um novo produto.
* PUT /api/product/{id}: Atualiza um produto existente.
* DELETE /api/product/{id}: Deleta um produto.

![Image](https://github.com/user-attachments/assets/6263d69d-e2a7-40c8-b6e3-cf4a641d1326)
![Image](https://github.com/user-attachments/assets/8030e4de-1cdf-4e76-a487-4b4818c6de9e)
![Image](https://github.com/user-attachments/assets/a39f7254-e6ee-44a5-8cc0-1e13b1eff1fa)

---


## 🧪 Testes

A solução inclui testes unitários no diretório Product.Test. Para executar os testes:

1. Navegue até o projeto de testes:

   ```bash
      cd Product.Test      
   ```

2. Execute os testes:

   ```bash
   dotnet test
   ```

---

## 🐛 Depuração

### Visual Studio

1. Abra o arquivo `ProductSolution.sln` no Visual Studio.
2. Selecione o perfil de execução desejado no menu de depuração
3. Escolha o projeto principal para execução, Product.Api
4. Pressione `F5` para iniciar a depuração.


---

## 📧 Contato

Para dúvidas ou sugestões, entre em contato:

- **Dev**: Roberth Silva
- **Email**: [roberth410@gmail.com]
- **GitHub**: [roberth-silva](https://github.com/roberth-silva)

---
