# notas-agenda

## 📚 Sobre o Projeto

Este é um projeto de **prática para estudar C#**, desenvolvido para aprender conceitos fundamentais da linguagem e programação orientada a objetos.

## 🎯 Objetivo

Criar um sistema de **agenda e notas** no terminal, onde é possível:

- Agendar eventos (aulas/compromissos)
- Adicionar notas aos eventos
- Visualizar a semana completa com todos os eventos e suas notas

## 🛠️ Como Funciona o Algoritmo

O sistema é composto por **3 classes principais**:

### 1. **Nota**

- Representa uma anotação com título e descrição
- Propriedades: `Titulo`, `Descricao (Desc)`

### 2. **Evento**

- Representa um compromisso/aula em uma data específica
- Propriedades: `Titulo`, `Data`, `NotasAssociadas` (lista de notas)
- Métodos: `AdicionarNota()` - adiciona uma nota ao evento

### 3. **Agenda**

- Gerencia todos os eventos
- Métodos principais:
  - `AgendarEvento()` - adiciona um novo evento
  - `AdicionarNota()` - encontra um evento e adiciona uma nota a ele
  - `ListarEventosDia()` - retorna eventos de um dia específico
  - `ListarEventosSemana()` - exibe todos os eventos e notas da semana

## 📅 Formato de Exibição

```
23/11 - Saturday -> Cálculo I | Programação

 Cálculo I: <- Titulo do Evento
- Derivadas: <- Titulo da nota
-- Estudar capítulo 3 <- Descrição da Nota
- Exercícios:
-- Fazer lista 5

 Programação:
- C#:
-- Revisar implementações
```

## 🚀 Como Executar

```bash
cd src
dotnet run
```
