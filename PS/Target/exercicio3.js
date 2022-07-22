
let Json =  require("./dados3.json")

const maiorFaturamento = Json.reduce(function(prev, current){
	return (prev.valor > current.valor) ? prev : current
 })


 const menorFaturamento = Json.reduce(function(prev, current){
	return (prev.valor < current.valor) ? prev : current
 })

 function mediaMensal(){
	var media = 20865.37
	let quantidade = 0
	for(let i = 0; i < Json[29].dia ; i++){
		if(Json[i].valor > media){
			quantidade++}}return quantidade}

console.log("O menor faturamento ocorreu em",menorFaturamento)
console.log("O maior faturamento ocorreu em",maiorFaturamento)
console.log("O faturamento diário foi maior que a média mensal em:",mediaMensal(),"dias")