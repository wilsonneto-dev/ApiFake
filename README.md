<img src="https://storage.googleapis.com/golden-wind/experts-club/capa-github.svg" />

# Deploy de uma aplicação .Net 5 em um Azure Web App for Containers utilizando Github Actions e Azure Container Registry

Ao final teremos uma aplicação .Net 5 conteinerizada publicada na Azure com Web Apps, de maneira profissional, utilizando Github Actions para esteira de deploy, Azure Container Registry para repositório de imagens e utilizando blue/green deployment. Apresentado por [Wilson Neto][1].

## Executar a aplicação

1. Basta baixar usando <br />`git clone https://github.com/rocketseat-experts-club/azure-publishing-dotnet-api-containirized-2021-11-08`
2. Para rodar o projeto: com o Visual Studio 2019 instalado, basta abrir a solution do projeto e apertar F5

## Sobre a Aula

Nesta aula vou te mostrar o passso a passo sobre como públicar aplicações .net conteinerizadas na Azure de maneira profissional usando a opção PaaS da Azure, o Azure Web App, aliada ao Container Registry da Azure.

## Link e informações de apoio

- Comando para criação do principal/RBAC:

```
az ad sp create-for-rbac --name "<name>" --role contributor --scopes /subscriptions/<subscription>/resourceGroups/<group> --sdk-auth
```

- Link Código do Pipeline:<br />
https://github.com/rocketseat-experts-club/azure-publishing-dotnet-api-containirized-2021-11-08/blob/main/.github/workflows/deployment.yml

- Link Azure:<br />
https://portal.azure.com/

## Expert

| [<img src="https://github.com/wilsonneto-dev.png" width="75px;"/>][1] |
| :-: |
|[Creator][1]|


[1]: https://www.twitch.tv/wilsonnetodev
