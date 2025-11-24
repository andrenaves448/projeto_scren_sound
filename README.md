[README.md](https://github.com/user-attachments/files/23733207/README.md)
# 🎵 Screen Sound

**Screen Sound** é uma aplicação de console desenvolvida em **C#** para gerenciamento e avaliação de bandas musicais. O objetivo é permitir que o usuário registre bandas, visualize as bandas cadastradas, avalie cada banda e consulte a média das avaliações.

---

## ✅ Funcionalidades

- **Registrar Bandas**  
  Adicione novas bandas ao sistema.

- **Listar Bandas Registradas**  
  Exiba todas as bandas cadastradas.

- **Avaliar Bandas**  
  Atribua notas às bandas registradas.

- **Consultar Média das Avaliações**  
  Veja a média das notas atribuídas a uma banda específica.

- **Menu Interativo**  
  Interface simples via console com opções para navegação.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Framework:** .NET  
- **Estruturas:**  
  - `Dictionary<string, List<int>>` para armazenar bandas e suas avaliações.
  - Métodos para modularidade e organização do código.

---

## ▶️ Como Executar

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/seuusuario/screensound.git
   ```

2. **Acesse a pasta do projeto:**
   ```bash
   cd screensound
   ```

3. **Compile e execute:**
   ```bash
   dotnet run
   ```

---

## 📂 Estrutura do Código

- **ExibirLogo()**: Mostra o logotipo estilizado e mensagem de boas-vindas.
- **ExibirOpcoesDoMenu()**: Exibe o menu principal e captura a opção do usuário.
- **RegistrarBanda()**: Registra uma nova banda.
- **MostrarBandasRegistradas()**: Lista todas as bandas cadastradas.
- **AvaliarUmaBanda()**: Permite avaliar uma banda existente.
- **MediadaBanda()**: Calcula e exibe a média das avaliações de uma banda.

---

## 🖼️ Exemplo de Execução

```
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
Boas vindas ao Screen Sound

Digite 1 para registrar uma banda
Digite 2 para mostrar todas as bandas
Digite 3 para avaliar uma banda
Digite 4 para exibir a média de uma banda
Digite -1 para sair
```

---

## 🚀 Próximos Passos

- Implementar persistência de dados (salvar em arquivo ou banco).
- Adicionar tratamento de erros mais robusto.
- Criar testes unitários.
