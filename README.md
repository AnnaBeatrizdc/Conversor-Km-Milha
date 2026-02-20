# Conversor Km-Milha

![License](https://img.shields.io/badge/license-MIT-blue.svg)

## 📝 Descrição

Aplicação desktop desenvolvida em C# Windows Forms para conversão de unidades de distância entre quilômetros (Km) e milhas (Mi). O programa oferece uma interface gráfica intuitiva que permite realizar conversões bidirecionais de forma rápida e precisa.

## ✨ Funcionalidades

- ✅ Conversão de Quilômetros para Milhas
- ✅ Conversão de Milhas para Quilômetros
- ✅ Interface gráfica amigável com Windows Forms
- ✅ Validação de dados de entrada
- ✅ Opções de conversão via RadioButton e ComboBox
- ✅ Botão para limpar campos e realizar novas conversões
- ✅ Mensagens de erro informativas

## 🖥️ Requisitos do Sistema

- Windows 7 ou superior
- .NET Framework 4.7.2 ou superior
- Visual Studio 2015 ou superior (para desenvolvimento)

## 🚀 Como Usar

1. **Executar a aplicação**: Abra o arquivo executável ou execute o projeto através do Visual Studio
2. **Escolher o tipo de conversão**:
   - Use os RadioButtons ou o ComboBox para selecionar entre "Km para Milha" ou "Milha para Km"
3. **Inserir o valor**: Digite o valor numérico que deseja converter
4. **Calcular**: Clique no botão "Calcular" para obter o resultado
5. **Limpar**: Use o botão "Limpar" para resetar os campos e fazer uma nova conversão

## 📊 Fórmulas de Conversão

- **Quilômetros para Milhas**: `milhas = quilômetros ÷ 1.609344`
- **Milhas para Quilômetros**: `quilômetros = milhas × 1.609344`

## 📁 Estrutura do Projeto

```
Conversor-Km-Milha/
│
├── Conversor-KM-Milhas/
│   ├── ConverteKM.cs              # Classe para conversão de Km para Milhas
│   ├── ConverteMilha.cs           # Classe para conversão de Milhas para Km
│   ├── ConverterKMBLL.cs          # Lógica de negócio para conversão Km
│   ├── ConverterMilhaBLL.cs       # Lógica de negócio para conversão Milhas
│   ├── Erro.cs                    # Classe para gerenciamento de erros
│   ├── Form1.cs                   # Formulário principal da aplicação
│   ├── Form1.Designer.cs          # Designer do formulário
│   ├── Program.cs                 # Ponto de entrada da aplicação
│   └── Conversor-KM-Milhas.csproj # Arquivo do projeto
│
├── LICENSE                         # Licença MIT
└── README.md                       # Este arquivo
```

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET Framework 4.7.2
- **Interface**: Windows Forms
- **IDE**: Visual Studio

## 💻 Compilação e Desenvolvimento

### Requisitos para Desenvolvimento

- Visual Studio 2015 ou superior
- .NET Framework 4.7.2 SDK

### Passos para Compilar

1. Clone o repositório:
   ```bash
   git clone https://github.com/AnnaBeatrizdc/Conversor-Km-Milha.git
   ```

2. Abra a solução no Visual Studio:
   ```
   Conversor-KM-Milhas.sln
   ```

3. Compile o projeto:
   - Pressione `F5` para compilar e executar
   - Ou use `Build > Build Solution` no menu

## 📄 Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👤 Autor

**Anna Beatriz Dantas**
