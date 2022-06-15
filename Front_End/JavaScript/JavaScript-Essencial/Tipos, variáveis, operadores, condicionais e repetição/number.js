const myNumber = 12.4032;

//Transformar numero para  String
const numberAsString = myNumber.toString();
console.log('Numero transformar em string', typeof numberAsString);

//Retorna numero com um numero de casa decimais
const fixedTwoDecimais = myNumber.toFixed(2); //numero de casas decimais que ele retorna
console.log('\nNumero om duas casas decimais:',  fixedTwoDecimais);

//Transformar uma string em float
console.log('\nString parseada para float:',typeof parseFloat('13.22'));
//float permite casas decimais

//Transformar uma strin em int
console.log('\nString parseada para int:', typeof parseInt('13.20'));
//numeros inteiros
