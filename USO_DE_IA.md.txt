Relatório de Uso de Inteligência Artificial
1. Ferramenta utilizada
DeepSeek.

2. Objetivo do uso
A IA foi usada como assistente para acelerar a criação do Front-end em Angular. Os principais objetivos foram: estruturar os componentes visuais (cards, header, hero), criar o CSS fiel ao Figma, resolver problemas de integração com a API (.NET) e implementar a lógica de filtros e navegação.

3. Prompts relevantes: O que foi aproveitado ou descartado

Prompt: "Como estruturar um projeto Angular com base em um protótipo do Figma?"

Aproveitado: A criação de componentes separados (Header, Hero, CardCurso) e a criação de uma Interface (Model) para tipar os dados do Curso.

Prompt: "Como buscar dados de uma API .NET e evitar que a tela quebre durante o carregamento?"

Aproveitado: O uso do HttpClient e a implementação de Angular Signals para atualizar a tela assim que a API respondesse.

Prompt: "Código HTML e CSS para uma barra de filtros e busca."

Aproveitado: A estrutura visual dos inputs e selects e a ligação com o TypeScript usando [(ngModel)].

Descartado: A IA sugeriu filtrar os dados no próprio navegador (front-end), mas a ideia foi descartada em favor de enviar os filtros para a API (back-end), tornando a aplicação mais profissional.

4. Como o conteúdo foi validado

Visual: Comparação direta da tela do navegador com o protótipo do Figma (cores e espaçamentos).

Funcional: Testes de cliques nos filtros e navegação entre páginas, usando o Console do navegador (F12) para verificar se os dados da API chegavam sem erros de CORS.

Código: Verificação constante do terminal do VS Code para garantir que o Angular compilava sem erros de TypeScript.

5. Um exemplo de erro ou inadequação identificado
Os dados da API chegavam corretamente (visível no Console), mas os cards não apareciam na tela ao recarregar a página (F5). A abordagem clássica sugerida inicialmente (this.listaCursos = dados) não estava disparando a atualização da tela na versão do Angular utilizada.

6. Correção realizada
O componente foi refatorado para usar a abordagem moderna de Signals do Angular.
A variável foi alterada para listaCursos = signal<Curso[]>([]) e a atualização passou a ser feita com .set(dados). No HTML, a leitura passou a usar parênteses listaCursos(). Com isso, a tela passou a reagir instantaneamente à chegada dos dados.