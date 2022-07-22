let sp = 67836.43
let rj = 36678.66
let mg = 29229.88
let es = 27165.48
let outros = 19849.53

let faturamentoTotal = sp + rj + mg + es + outros

function porcentualDeRepresentacao(a, faturamentoTotal) {
    return Math.round((a / faturamentoTotal) * 100);
}

console.log("O estado de SP representa " + porcentualDeRepresentacao(sp, faturamentoTotal) + `% do total de vendas`)
console.log("O estado do RJ representa " + porcentualDeRepresentacao(rj, faturamentoTotal) + `% do total de vendas`)
console.log("O estado de MG representa " + porcentualDeRepresentacao(mg, faturamentoTotal) + `% do total de vendas`)
console.log("O estado do ES representa " + porcentualDeRepresentacao(es, faturamentoTotal) + `% do total de vendas`)
console.log("Os outros estados representam " + porcentualDeRepresentacao(outros, faturamentoTotal) + `% do total de vendas`)