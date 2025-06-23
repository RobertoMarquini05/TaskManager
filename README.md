# Task Manager - Sistema de Gerenciamento de Tarefas em C# com Windows Forms

Bem-vindo ao **Task Manager**, um aplicativo de gerenciamento de tarefas desenvolvido em C# com uma interface gráfica em Windows Forms. Este projeto permite criar, visualizar, editar, excluir e organizar tarefas com prioridades e categorias, demonstrando habilidades em:

- Programação orientada a objetos  
- Persistência de dados em JSON  
- Desenvolvimento de interfaces gráficas

## 📌 Sobre o Projeto

O Task Manager é um projeto intermediário em C# projetado para gerenciar tarefas de forma eficiente com uma interface gráfica intuitiva. Ele combina uma UI amigável, construída com Windows Forms, com uma arquitetura modular, ideal para destacar competências técnicas em .NET no GitHub e LinkedIn.

> ⚠️ Este projeto é um **MVP (Produto Mínimo Viável)**.  
> Pretendo futuramente implementar um **frontend web responsivo** que se integre à lógica do backend.

## ✅ Funcionalidades

- **Criação de Tarefas**: Adicione tarefas com título, descrição, data de vencimento, prioridade (Baixa, Média, Alta) e categoria (ex.: Trabalho, Pessoal, Estudos).
- **Listagem de Tarefas**: Exiba tarefas em uma tabela (DataGridView) com filtros por status (Concluída ou Pendente), categoria ou prioridade, e ordene por data de vencimento ou prioridade.
- **Edição de Tarefas**: Atualize os detalhes de uma tarefa existente.
- **Exclusão de Tarefas**: Remova tarefas selecionadas com confirmação via MessageBox.
- **Marcação de Status**: Marque tarefas como concluídas ou reabra com um clique.
- **Busca de Tarefas**: Pesquise tarefas por palavras-chave no título ou descrição.
- **Persistência de Dados**: Salve e carregue tarefas em um arquivo JSON.
- **Estatísticas (Opcional)**: Exiba resumos como total de tarefas e percentual de concluídas.
- **Notificações (Opcional)**: Exiba alertas visuais para tarefas próximas do vencimento.

## 🛠 Tecnologias Utilizadas

- **Linguagem**: C# (.NET Framework 4.8)
- **Interface Gráfica**: Windows Forms
- **Bibliotecas**:
  - `System.Text.Json` ou `Newtonsoft.Json` para manipulação de JSON
- **Ferramentas**:
  - Visual Studio
  - Git

## 📁 Estrutura do Projeto

- **Models**: Classe `Tarefa` com propriedades como ID, título, descrição, prioridade, categoria etc.
- **Services**: Classe `TarefaService` para gerenciar operações (adicionar, editar, excluir, listar).
- **Data**: Classe `TarefaService` para leitura e escrita de dados em JSON.
- **UI**: Formulários Windows Forms (`Principal`, `Criacao Tarefas`, `EditarTarefasSelecionadas` e `ListagemTarefas`) para interação com o usuário.

## ▶️ Como Executar

### Pré-requisitos

- .NET Framework 4.8 instalado  
- Visual Studio (recomendado)

### Instalação

```bash
git clone https://github.com/RobertoMarquini05/TaskManager
cd task-manager
```

### Execução

1. Abra o arquivo `.sln` no Visual Studio  
2. Compile e execute com `F5`

Ou via terminal:

```bash
dotnet build
dotnet run
```

## 🧑‍💻 Uso

- Utilize a interface gráfica para criar, editar, excluir e gerenciar tarefas.
- Aplique filtros e buscas diretamente na tabela para facilitar a organização.


## 🙌 Contribuições

Contribuições são bem-vindas!  
Sinta-se livre para abrir **issues** ou **pull requests** com melhorias, correções ou novas funcionalidades.


## 👨‍💻 Autor

Desenvolvido com 💻 e ☕ por **Roberto Marquini**  
[LinkedIn](https://www.linkedin.com/in/roberto-marquini/) | marquinir@gmail.com

---

© 2025 Roberto Marquini — Todos os direitos reservados.
