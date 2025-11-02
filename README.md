# Sistema de Gestão de Clínica

Sistema completo de gestão para clínicas médicas desenvolvido em **Blazor .NET** com **Entity Framework Core** e **SQLite**.

## 📋 Sobre o Projeto

O Sistema de Gestão de Clínica é uma aplicação web moderna que permite o gerenciamento completo de uma clínica, incluindo agendamentos, procedimentos, pacientes e relatórios. Desenvolvido com as tecnologias mais recentes do ecossistema .NET.

## ✨ Funcionalidades

### 🏠 Dashboard
- **Visão Geral**: Cards com estatísticas principais (total de clientes, agendamentos hoje, agendamentos pendentes nos próximos 7 dias, total de procedimentos)
- **Gráficos Interativos**:
  - Gráfico de pizza: Agendamentos por status (cores personalizadas)
  - Gráfico de barras horizontal: Top 5 procedimentos mais agendados
- **Tabelas de Dados**:
  - Clientes recentes com paginação
  - Próximos agendamentos com badges coloridos por status

### 📅 Agenda
- Visualização em formato de calendário (dia, semana, mês)
- Criação de agendamentos por clique ou arrastar e soltar
- Edição de agendamentos existentes
- Movimentação de agendamentos entre datas/horários
- Cores personalizadas por status:
  - 🔴 **Vermelho**: Cancelado
  - 🟠 **Laranja**: Pendente
  - 🟢 **Verde**: Concluído
  - 🔵 **Azul**: Confirmado

### 👥 Pacientes
- Cadastro completo de pacientes
- Campos: Nome, Email, Telefone, Data de Nascimento, CPF
- Listagem e busca de pacientes
- Histórico de agendamentos por paciente

### 💉 Procedimentos
- Cadastro de procedimentos médicos
- Upload de imagens para cada procedimento
- Visualização em cards com grid responsivo
- Informações: Nome, Preço, Imagem
- Botões de ação:
  - **Agendar**: Criar novo agendamento para o procedimento
  - **Excluir**: Remover procedimento (com confirmação)
- Sistema de busca/filtro por nome

### 📊 Relatórios
- Seleção de cliente via dropdown
- Listagem de consultas por cliente
- Filtro automático de agendamentos cancelados
- Geração de PDF com relatórios
- Envio de relatórios por email:
  - Envio individual de consultas
  - Envio da última consulta válida (agendamentos futuros)
- Notificações de sucesso/erro

### 🔐 Autenticação
- Sistema de login e registro de usuários
- Área de gerenciamento de conta
- Proteção de rotas com autorização

## 🛠️ Tecnologias Utilizadas

- **Framework**: ASP.NET Core Blazor (Server-Side)
- **Linguagem**: C#
- **ORM**: Entity Framework Core
- **Banco de Dados**: SQLite
- **UI Components**: Radzen Blazor Components
- **Geração de PDF**: QuestPDF
- **Ícones**: Bootstrap Icons
- **Email**: EmailService customizado

## 📁 Estrutura do Projeto

```
Clinica/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   ├── NavMenu.razor
│   │   └── NavMenu.razor.css
│   ├── Pages/
│   │   ├── Home.razor                 # Dashboard
│   │   ├── Agenda.razor               # Calendário de agendamentos
│   │   ├── Procedimentos.razor        # Gestão de procedimentos
│   │   ├── RelatoriosPorCliente.razor # Relatórios e emails
│   │   └── Dialog/
│   │       ├── AddAppointment.razor   # Criar agendamento
│   │       └── EditAppointment.razor  # Editar agendamento
│   └── Shared/
├── Data/
│   └── ApplicationDbContextClinica.cs # Contexto do EF Core
├── Models/
│   ├── Agendamento.cs
│   ├── Cliente.cs
│   ├── Procedimento.cs
│   ├── RelatorioConsulta.cs
│   └── Status.cs
├── Services/
│   ├── RelatorioPdfService.cs         # Geração de PDFs
│   └── EmailService.cs                # Envio de emails
└── wwwroot/
    └── images/
        ├── logo.png
        └── procedimentos/             # Imagens dos procedimentos
```

## 🚀 Como Executar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior
- Editor de código (Visual Studio, VS Code, Rider)

### Passos

1. **Clone o repositório**
   ```bash
   git clone <url-do-repositorio>
   cd Clinica
   ```

2. **Restaure as dependências**
   ```bash
   dotnet restore
   ```

3. **Execute as migrações do banco de dados**
   ```bash
   dotnet ef database update
   ```

4. **Execute o projeto**
   ```bash
   dotnet run
   ```

5. **Acesse no navegador**
   ```
   https://localhost:5001
   ou
   http://localhost:5000
   ```

## 📦 Pacotes NuGet Principais

- `Microsoft.AspNetCore.Components.Web`
- `Microsoft.EntityFrameworkCore.Sqlite`
- `Microsoft.EntityFrameworkCore.Tools`
- `Radzen.Blazor` - Componentes UI
- `QuestPDF` - Geração de PDFs

## 🎨 Paleta de Cores

O sistema utiliza um esquema de cores baseado em gradientes azuis:

- **Primário**: `#2a339b` (Azul escuro)
- **Secundário**: `#57abc7` (Azul claro)
- **Gradiente**: Linear gradient de 90deg entre as cores primárias

**Status de Agendamentos**:
- Cancelado: `#dc3545` (Vermelho)
- Pendente: `#fd7e14` (Laranja)
- Concluído: `#28a745` (Verde)
- Confirmado: `#17a2b8` (Azul)

## 📝 Funcionalidades de Agendamento

### Criação de Agendamento
- Seleção de data e horário
- Escolha de cliente (com busca)
- Seleção de procedimento
- Definição de status inicial

### Edição de Agendamento
- Modificação de data/hora
- Alteração de status
- Movimentação via drag-and-drop no calendário

### Status Disponíveis
- Pendente
- Confirmado
- Concluído
- Cancelado

## 📧 Sistema de Emails

O sistema possui funcionalidade de envio de emails para:
- Enviar relatórios individuais de consultas
- Enviar a última consulta agendada (apenas consultas futuras)
- Anexo de PDF com informações formatadas

## 🔒 Segurança

- Autenticação obrigatória em todas as rotas principais
- Proteção contra SQL Injection via Entity Framework
- Validação de dados no cliente e servidor
- Confirmação para operações destrutivas (exclusão)

## 🌐 Navegação

- **Dashboard** - Visão geral e estatísticas
- **Agenda** - Calendário de agendamentos
- **Pacientes** - Gestão de pacientes/clientes
- **Procedimentos** - Catálogo de procedimentos
- **Relatórios** - Geração e envio de relatórios

## 📱 Responsividade

O sistema é totalmente responsivo e se adapta a diferentes tamanhos de tela:
- Desktop (full experience)
- Tablet (layout adaptado)
- Mobile (menu hambúrguer e cards empilhados)

## 🤝 Contribuindo

Contribuições são bem-vindas! Para contribuir:

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/NovaFuncionalidade`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/NovaFuncionalidade`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## 👨‍💻 Autor

Desenvolvido com ❤️ usando Blazor e .NET

---

**Nota**: Este é um sistema de gestão completo para clínicas, desenvolvido como exemplo educacional e pode ser adaptado para necessidades específicas.
