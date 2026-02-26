# Telemetry API

API desenvolvida em ASP.NET Core para coleta, armazenamento e consulta de dados de telemetria.

## Sobre o projeto
Este projeto tem como objetivo construir a base de um sistema de telemetria, permitindo que aplicações externas enviem dados para armazenamento e posterior análise.

A proposta futura é evoluir o sistema para simular um cenário de **telemetria automotiva**, onde sensores de um carro de corrida enviam informações em tempo real.

## Arquitetura
O projeto segue uma arquitetura em camadas:

- **Domain** – Entidades e regras de negócio  
- **Application** – Serviços e casos de uso  
- **Infrastructure** – Acesso a dados (Entity Framework Core e PostgreSQL)  
- **API** – Controllers e endpoints  

Essa estrutura permite evoluir o domínio sem impactar a infraestrutura do sistema.

## Tecnologias utilizadas
- .NET Web API
- Entity Framework Core
- PostgreSQL
- Swagger (documentação interativa)

## Funcionalidades atuais
- Registro de eventos de telemetria
- Consulta dos dados mais recentes
- Persistência em banco PostgreSQL
- Documentação da API via Swagger

## Endpoints

### Enviar dados de telemetria
**POST** `/api/telemetry`

Exemplo:
```json
{
  "application": "Simulator",
  "message": "Evento de telemetria",
  "level": 1
}
```

### Consultar dados recentes
**GET** `/api/telemetry`

## Como executar o projeto

1. Configurar a string de conexão com o PostgreSQL no arquivo `appsettings.json`

2. Aplicar as migrations:
```
dotnet ef database update --project Telemetry.Infrastructure --startup-project Telemetry.Api
```

3. Executar a aplicação:
```
dotnet run --project Telemetry.Api
```

4. Acessar o Swagger:
```
https://localhost:7265/swagger
```

## Próximos passos (roadmap)
- Modelagem de telemetria automotiva (velocidade, RPM, temperatura, etc.)
- Simulador de envio de dados de sensores
- Armazenamento otimizado para alto volume de eventos
- Visualização de dados

## Objetivo
Projeto desenvolvido para estudo de:
- Arquitetura em camadas
- Boas práticas em desenvolvimento backend com .NET
- Integração com banco de dados
- Construção de sistemas de telemetria
