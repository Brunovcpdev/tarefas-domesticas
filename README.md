# 🏠 Tarefas Domésticas

Aplicação web para cadastro e gerenciamento de tarefas domésticas com controle de prioridades, responsáveis e datas.

---

## 📋 Funcionalidades

- Cadastro de tarefas domésticas
- Edição de tarefas existentes
- Exclusão de tarefas
- Listagem de todas as tarefas
- Controle de prioridade (Baixa, Média, Alta)
- Definição de responsável por cada tarefa
- Definição de data para cada tarefa

---

## 🛠️ Tecnologias Utilizadas

- **Frontend:** HTML, JavaScript, Bootstrap 4
- **Backend:** C# com ASP.NET Core Web API (.NET)
- **Banco de Dados:** SQL Server
- **ORM:** Entity Framework Core

---

## 🗂️ Estrutura do Projeto

```
CadastroTarefas/
├── Controllers/
│   └── TarefasController.cs   # Endpoints da API REST
├── Models/
│   ├── Tarefas.cs             # Model da entidade Tarefa
│   └── ApplicationDbContext.cs # Contexto do banco + repositório
├── BancoDados/                # Scripts SQL
└── CadastroTarefas.html       # Frontend da aplicação
```

---

## 🔌 Endpoints da API

| Método | Rota | Descrição |
|--------|------|-----------|
| GET | `/api/Tarefas/Listar` | Lista todas as tarefas |
| POST | `/api/Tarefas/Salvar` | Cadastra uma nova tarefa |
| PUT | `/api/Tarefas/Alterar` | Edita uma tarefa existente |
| DELETE | `/api/Tarefas/Excluir?IdTarefas={id}` | Exclui uma tarefa |

---

## 🗃️ Model Tarefa

| Campo | Tipo | Descrição |
|-------|------|-----------|
| IdTarefa | int | Identificador único |
| NomeTarefa | string | Nome da tarefa |
| Descricao | string | Descrição detalhada |
| DataTarefa | DateTime | Data de execução |
| Prioridade | int | 1 = Baixa, 2 = Média, 3 = Alta |
| Responsavel | string | Nome do responsável |

---

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server)
- Navegador web

### Passo a passo

1. Clone o repositório:
```bash
git clone https://github.com/Brunovcpdev/tarefas-domesticas.git
```

2. Configure a string de conexão com o banco de dados no `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=TarefasDomesticas;Trusted_Connection=True;"
}
```

3. Execute as migrations ou o script SQL da pasta `BancoDados`

4. Rode a API:
```bash
dotnet run
```

5. Abra o arquivo `CadastroTarefas.html` no navegador

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
