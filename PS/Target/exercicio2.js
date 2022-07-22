let fibonacciInicial = [0, 1]

function numeroTeste(fibo) {
  for (i = 0; i < fibo; i++) {
    let numeroSequencial = fibonacciInicial[i] + fibonacciInicial[i + 1]
    fibonacciInicial.push(numeroSequencial)
  }

  if (fibonacciInicial.includes(fibo)) {
    console.log(`${fibo} pertence a sequência de Fibonacci`)
  } else {
    console.log(`${fibo} não pertence a sequência de Fibonacci`)
  }

  console.log(fibonacciInicial)
}

numeroTeste(111)
numeroTeste(89)