let lines = gets().split("\n");

let line = lines.shift().split(" ");
let A = parseInt(line[0]);
let B = parseInt(line[1]);

if (B%A == 0 || A%B == 0) {
  console.log("Sao Multiplos")
} 
else{
  console.log("Nao sao Multiplos")
}