#Sintaxe Básica JS

##Boolean - Verdadeiro ou falso
##null - nulo
## undefined - indefinido
## Number - numeros
## String - 
##Array -
## Object -
## Function

Tipagem -> funciona como uma regra de uso de dados

#DECLARANDO VARIAVEIS
- var - pode ter escopo global ou local, variavel generica, pode ter seu valor alterado e se não tiver um valor inicial sera declarado como nula.

ex.: var variavel = 'Gui'
variavel = 'Alves'
console.log(variavel);

- let - escopo local de bloco e pode ter seu valor alterado, se não tiver um valor inicial sera tratada como nula.

let variavel2 = 'diana'

é usada em escopo local por convenção

- const - ela Ñ pode ser alterada, somente leitura, não tem valor de bloco, ela precisa ter um valor inicial

#ESCOPO - defini limitacao e visibilidade de um bloco de código
Escopo global - quando a variavel é declarada fora de qualquer bloco, sua visibilidade fica disponivel em todo codigo.
Escopo local - quando a variavel é declarada dentro de um bloco, sua visibilidade pode ficar disponível ou não.

var escopoGlobal = 'global';
console.log(escopoGlobal);
function escopoLocal() { 
    let escopoLocalInterno = 'local'
    console.log(escopoLocalInterno);
}
escopoLocal();

#REGRAS DE USO DE VARIAVEIS

var nome || var _nome

Não usar espaços (use camelCase ou _); 

var nomeCompleto || var nome_completo

não usar palavras reservadas para variáveis

Declarar variáveis no topo do bloco

# Atribuição
 usa o "="
 # Comparação
 usa o "=="
 # Comparação Identica - compara valor e tipo
 usa "==="

# Operadores Aritméticos
Adição ex: 1 + 1
Subtracao ex: 2 - 1
Multip ex: 2 * 3
Div ex: 6 / 2
Div Inteira 5 % 2 - exibe o resto da divisão - usado para comparar se é par ou não
Potenciacao **

# Operadores Relacionais
> maior que
< menor que
>=
<=

# Operadores lógicos
&& - "e"- considera que todos os valores sejam verdadeiros
|| - "ou"- considera que qualquer valor seja verdadeiro
! - "não" - inverte o valor de true para false e vice e versa.

# Vetores ou Arrays

Array é um tipo de lista, ou matriz de variáveis, onde cada variável possui um índice. Os valores podem ser de vários tipos.
 - O array pode ser declarado entre colchetes e podem guardar qualquer valor dentro dele, inclusive outros arrays.

 ## Manipulando Array
 - Ao ser declarado, o array traz consigo um série de métodos para manipulá-lo.
 forEach() - itera um array;
 push() - add item ao final do array;
 pop() - remove item no final do array;
 shift() - remove item no inicio do array;
 unshift () - add item no inicio do array;
 indexOf() - retorna o índice de um valor;
 splice() - remove ou substitui um item pelo índice;
 slice() - retorna uma parte de um array existente;

 usa como array.push ou array.slice

# Objeto
Dados que possuem propriedade e valors. ele devem ser declarados entre chaves.
ex.: xicara
var xicara = { cor: 'azul, tamanho: 'p'; funcao: tomarCafe()}
var cor = xicara.cor
var tamanho = xicara.tamanho
var funcao = tomarCafe()
}

# if (se)

# else ( se não)

# else if ( se não para amis de uma condição)

var time1 = 0;
var time2 = 0;
var placar;

if () { 
    console.log
} else if () {
    console.log
} else {
}

# ninho de if

# switch/case

switch (placar) = time1 > time 2:
console.log ('jogador 1 ganhou');
break;
switch (placar) = time1 <  time 2:
console.log ('jogador 1 ganhou');
break;
default
console.log ('Ninguem Ganhou');

# Laços de Repetição

# for

Funciona como repetição de instrução at[e que a condição seja falsa:

for ([ espressaoInicial]; [ condicao]; [incremento]) { 
    declaracao
}
ex.:
var array = [ 'valor1', 'valor2', 'valor3'; 'valor4']
for (let i = 0; i < array.length; i++) { 
    console.log(i)
}
 
 # for in
 # for of

 # while 
 executa um instrucao enquanto ela for verdadeira, a verificacao é feita antes da execucão;
 ex.: var a= 0;
  while (a< 10) { 
     a++;
     console.log(a);
 }
 
# do while 
executa uma funcao ate que a condicao seja falsa, mas verifica depois da execucao.

# funcoes

sao blocos de comandos e instrucoes para execucao de determinadas tarefas:

ex. function nomeDaFuncao(){
    ${instrucao}
}
nomeDaFuncao();



