# CDBCalc

Calculadora de rendimento de CDB (Certificado de Depósito Bancário), construída como exemplo de aplicação full-stack em **ASP.NET Core + Angular**, com padrão de comando/handler via MediatR, validação com FluentValidation e testes unitários.

O usuário informa o valor inicial e o prazo em meses; a API devolve o **valor bruto** e o **valor líquido** após imposto de renda.

## Regra de cálculo

- Rendimento mensal composto: `valor *= 1 + (CDI × TB)`, com CDI = 0,9% ao mês e TB = 108% do CDI.
- Imposto de renda regressivo sobre o rendimento, pela tabela de renda fixa:

| Prazo | Alíquota |
|---|---|
| até 6 meses | 22,5% |
| 7 a 12 meses | 20,0% |
| 13 a 24 meses | 17,5% |
| acima de 24 meses | 15,0% |

- Validações: valor inicial maior que zero e prazo maior que 1 mês.

## Stack

| Camada | Tecnologias |
|---|---|
| Backend | ASP.NET Core 6 Web API, MediatR (command/handler), FluentValidation, Swagger |
| Frontend | Angular 18, Bootstrap 5, proxy de desenvolvimento para a API |
| Testes | MSTest, Moq |
| Infra | Dockerfile para o servidor, SPA proxy integrado ao projeto .NET |

## Estrutura

```
CDBCalc/
├── CDBCalc.sln
├── CBDCalc.App/
│   ├── CBDCalc.App.Server/        # API: Controllers, Commands, Handler, Service, Validations
│   └── cbdcalc.app.client/        # Angular: pages/cdb-calc, services/cdb.service.ts
└── CDBCalc.Test/                  # testes unitários do serviço de cálculo
```

## API

`POST /api/cdb/calcular`

```json
{ "valorInicial": 1000, "prazoMeses": 12 }
```

Resposta:

```json
{ "valorBruto": 1123.08, "valorLiquido": 1098.47 }
```

## Como rodar

Pré-requisitos: .NET 6 SDK e Node.js 18 ou superior.

```bash
cd CDBCalc
dotnet restore
dotnet run --project CBDCalc.App/CBDCalc.App.Server
```

O projeto .NET sobe o Angular automaticamente pelo SPA proxy (`npm start` em `cbdcalc.app.client`). A interface fica em `https://localhost:4200` e o Swagger em `https://localhost:<porta>/swagger`.

Testes:

```bash
dotnet test CDBCalc/CDBCalc.Test
```

## Próximos passos

- Trocar o CDI fixo por consulta a uma fonte de taxas.
- Cobrir o `CdbService` real nos testes, além do mock do contrato.
- Migrar para .NET 8 e Minimal APIs.
