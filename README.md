# 🚗 Sistema de Estacionamento em C#

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Status](https://img.shields.io/badge/STATUS-CONCLU%C3%8DO-success?style=for-the-badge)
![License](https://img.shields.io/badge/LICENSE-MIT-blue?style=for-the-badge)

---

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte de um **desafio da Digital Innovation One (DIO)**.  
O objetivo é criar um **sistema de estacionamento em C#** utilizando conceitos de **programação orientada a objetos (POO)** e **.NET**, permitindo gerenciar veículos estacionados e calcular o valor total com base no tempo de permanência.

---

## 🧠 Conceitos Aplicados

- 🧩 Classes e Objetos  
- 🔒 Encapsulamento  
- 🗂️ Listas genéricas (`List<T>`)  
- ⏱️ Manipulação de datas (`DateTime`)  
- 💰 Cálculos com `decimal`  
- 🧾 Boas práticas de código e separação por camadas (`Models`)

---

## ⚙️ Funcionalidades

✅ Adicionar um veículo  
✅ Remover veículo e calcular valor total  
✅ Listar todos os veículos estacionados  
✅ Validação de placas duplicadas  
✅ Interface simples via Console  

---

## 🏗️ Estrutura do Projeto

```bash
📦 Estacionamento
├── 📁 Models
│   ├── Estacionamento.cs
│   └── Veiculo.cs
└── Program.cs
```



---

## 💻 Tecnologias Utilizadas

| Tecnologia | Descrição |
|-------------|------------|
| 🧠 **C#** | Linguagem principal do projeto |
| ⚙️ **.NET 8.0** | Framework para execução e compilação |
| 🖥️ **Console Application** | Interface simples e prática |
| 🧮 **List<T> e DateTime** | Controle de veículos e tempo de permanência |

---

## 🚀 Como Executar o Projeto

1. **Clone o repositório**
   ```bash
   git clone https://github.com/Diofbjr/Estacionamento.git
   cd Estacionamento

2. Restaure (opcional)

dotnet restore


3. Execute

dotnet run

🧩 Exemplo de Uso
🏁 Menu principal:
=== SISTEMA DE ESTACIONAMENTO ===
1 - Adicionar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar

➕ Ao adicionar um veículo:
Digite a placa do veículo: ABC1234
Veiculo ABC1234 adicionado com sucesso às 14:32!

➖ Ao remover um veículo:
Digite a placa do veículo a remover: ABC1234
Veiculo ABC1234 removido com sucesso!
Entrada: 14:32
Saída: 16:45
Tempo total: 2 hora(s)
Valor total a pagar: R$ 9,00

👨‍💻 Autor

Desenvolvido por Diogo de França

📚 Projeto do Bootcamp da Digital Innovation One (DIO)

🏅 Licença

Este projeto está sob a licença MIT — sinta-se livre para usar e modificar.

MIT License © 2025 Diogo de França

