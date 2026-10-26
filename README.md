Catálogo de Cursos - SESI (Teste Técnico)
Aplicação Full-Stack (Angular + .NET) desenvolvida para o teste técnico do SESI. O sistema permite visualizar, pesquisar e filtrar cursos de Card Games (Pokémon TCG, Yu-Gi-Oh!, Magic, etc.), simulando um catálogo educacional.

🌐 Links do Projeto (Produção)
Front-end (Azure Static Web Apps): https://salmon-sand-09269c10f3.azurestaticapps.net

Back-end / API (Render): https://catalago-sesi.onrender.com/api/cursos

(Nota: O Back-end está hospedado no plano gratuito do Render. Caso o servidor esteja "dormindo", a primeira requisição pode demorar cerca de 50 segundos para responder).

🚀 Tecnologias Utilizadas
Front-end: Angular 17+ (Standalone Components, Signals, Router, HttpClient)

Back-end: .NET 8 (C#), ASP.NET Core Web API

Estilização: CSS puro (fiel ao protótipo do Figma)

Deploy: Front-end (Azure Static Web Apps) / Back-end (Render)

📂 Estrutura do Projeto
text
CATALAGO_SESI/
 ┣ Backend/       # API REST em .NET 8
 ┗ Frontend/      # Aplicação Angular
🛠️ Como rodar o projeto localmente
1. Back-end (.NET)
Abra o terminal na pasta Backend.

Execute o comando:

bash
dotnet run
A API estará rodando em http://localhost:5170.

2. Front-end (Angular)
Abra um novo terminal na pasta Frontend.

Instale as dependências:

bash
npm install
Inicie o servidor:

bash
ng serve
Acesse http://localhost:4200 no navegador.

📡 Documentação da API
A API fornece os dados dos cursos e permite filtragem diretamente no back-end.

URL Base Local: http://localhost:5170/api/cursos

URL Base Produção: https://catalago-sesi.onrender.com/api/cursos

Endpoint Principal
1. Listar todos os cursos (com filtros opcionais)
Método: GET

Rota: /api/cursos

Parâmetros de Query (opcionais):

nome: Busca por parte do nome do curso (ex: magic, pokemon).

categoria: Filtra pela categoria exata (ex: ESTRATÉGIA, MERCADO).

modalidade: Filtra pela modalidade (ex: Online, Presencial).

status: Filtra pelo status (ex: Inscrições Abertas, Em Breve, Encerrado).

Exemplos de chamadas:

Listar todos os cursos:

http
GET /api/cursos
Buscar cursos de Pokémon:

http
GET /api/cursos?nome=pokemon
Filtrar cursos online que estão com inscrições abertas:

http
GET /api/cursos?modalidade=online&status=Inscrições Abertas
Combinar busca e filtro (Cursos de Estratégia presenciais):

http
GET /api/cursos?categoria=ESTRATÉGIA&modalidade=Presencial
Exemplo de Resposta (JSON):

json
[
  {
    "id": 1,
    "nomeCompleto": "Estratégias Avançadas para o Metagame de Pokémon TCG",
    "nomeBreve": "Estratégias em Pokémon TCG",
    "descricao": "Aprenda a montar decks competitivos...",
    "categoria": "ESTRATÉGIA",
    "modalidade": "Online",
    "cargaHoraria": 40,
    "publicoAlvo": "Jogadores intermediários",
    "status": "Inscrições Abertas",
    "imagemUrl": "/assets/pokemon.jpg",
    "dataDisponibilizacao": "2024-01-15"
  }
]
🧠 Uso de Inteligência Artificial
O desenvolvimento do Front-end contou com o auxílio de IA para otimização de tempo. Os detalhes sobre as ferramentas, prompts e correções podem ser consultados no arquivo USO_DE_IA.md na raiz do projeto.

✨ Funcionalidades Implementadas
☑ Listagem de cursos via API.
☑ Pesquisa por nome (via API).
☑ Filtros por categoria, modalidade e status (via API).
☑ Combinação de pesquisa e filtros.
☑ Contador de resultados dinâmico.
☑ Botão para limpar filtros.
☑ Navegação para tela de detalhes do curso.
☑ Estado de carregamento (Loading).
☑ Mensagem de erro e mensagem de "Nenhum curso encontrado".
☑ Layout responsivo e fiel ao Figma.
