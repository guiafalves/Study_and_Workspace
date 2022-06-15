# JavaScript 

ECMAScript - Especificação de linguagem de programação

TC39

 Fluxo de propostas :

- Stage 0 - strawman - Submeter um formulário para evoluir o ECMAScript
- Stage 1 - Proposal - Proposta formal da alteração
- Stage 2 - Draft - Primeira versão da proposta
- Stage 3 - candidate - Feedback de implementação e revisões, duas implementações compatíveis
- Stage 4 - finish - Tem que estar passando pela switch de teste



## Conceitos

JavaScript é uma linguagem interpretada - o código é executado de cima pra baixo e o resultado é imediatamente retornado.

Tipagem fraca e dinâmica - é possível usar um operador sem que haja um erro.

TYPESCRIPT - 

www.typescriptlang.org

FLOW -

http:\\flow.org



Função de Primeira classe - ela pode ser atribuída a uma variável e pode ser passada para argumentos ou retornadas para outras funções.

Closure - escopo léxico.

Sempre que possível trabalhar com funções puras, assim fica mais fácil saber de onde vem a variável.

Currying - técnica de transformar uma função, para não ter que ficar repetindo variável.

Hoisting - 

Imutabilidade - Os dados são imutáveis, a variável não vai mudar, você vai criar uma nova, pega todo  item e concatena um novo, o objeto não é atualizado, você primeiro cópia ele e depois altera.

## Tipos e variáveis

VAR  - só aceita escopo de função ou global

LET

CONST

LET e CONST  respeitam o escopo de bloco.

- string - representar os textos
- number - números
- boolean - true or false
- null - null
- undefined - variavel existe mas não foi atribuida um valor ainda
- symbol - cria valores unicos
- object - 
- function - também é um obejto mas permite que o objeto seja chamado
- array - também é um objeto mas tem relação com os itens dele\
- array.of 

### Orientação aos Objetos

Herança - Baseada em prototipos - __proto_  -> Constructor

f Animal. constructor -> f function -> Function.prototype.constructor -> f object() {} -> object.prototype = null;

prototype -> contem a definição do meu objeto

Classes - CLASS

DESIGN PATTERN - são solucoes generalistas para problemas recorrentes durante o desenvolvimento de um software.

- Criaçao - sao aqueles que ajudam a tornar um sistema independente - ex. prototype
- estruturais - são compostos para criar estruturar maiores - ex. adptader
- Comportamentais - alogoritmos e atribuicoes de classes ex. command, interpreter

Mais utilizados:

- FACTORY
- SINGLETON - jquery.com
- DECORATOR - GITHUB.COM/TC39/PROPOSAL-DECORATORS
- OBSERVER - A instância subscriber mantém uma coleção de objetos observer e notifica todos eles quando ocorrem mudanças no estado. -> Observer tem que manter uma lista e observer, ter uma lista subscribe, ter uma lista, ter nosubscribe e notify.
- MODULE - Organize melhor nosso codigo
- 

