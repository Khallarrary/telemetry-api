# Telemetry API

API desenvolvida em ASP.NET Core para registro e consulta de eventos de telemetria de aplicações.

## Sobre o projeto
Este projeto foi criado com o objetivo de praticar desenvolvimento backend com .NET, utilizando uma arquitetura organizada e tecnologias utilizadas em sistemas reais.

A API permite que sistemas enviem informações como erros, avisos e mensagens operacionais para armazenamento e consulta.

## Arquitetura
O projeto segue uma arquitetura em camadas:

- **Domain** – Entidades e regras de negócio  
- **Application** – Serviços e casos de uso  
- **Infrastructure** – Acesso a dados (Entity Framework Core e PostgreSQL)  
- **API** – Controllers e endpoints  

## Tecnologias utilizadas
- .NET Web API
- Entity Framework Core
- PostgreSQL
- Swagger (documentação interativa)

## Funcionalidades
- Registro de eventos de telemetria
- Consulta dos eventos mais recentes
- Persistência em banco PostgreSQL
- Documentação da API via Swagger

## Endpoints

### Criar evento
**POST** `/api/telemetry`

Exemplo:
```json
{
  "application": "HotelSystem",
  "message": "Erro ao salvar reserva",
  "level": 2
}
```

### Listar eventos recentes
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

## Objetivo
Projeto desenvolvido como parte dos estudos em desenvolvimento backend com foco em:
- Arquitetura em camadas
- Boas práticas em .NET
- Integração com banco de dados
- Construção de APIs reais