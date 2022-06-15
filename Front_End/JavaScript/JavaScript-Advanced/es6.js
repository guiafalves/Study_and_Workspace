//ARROW FUNCTIONS

//var sum = function(a, b){
//    return a + b;
//};
//console.log(sum(5, 5));

//Arow Functions
//var sum = (a, b) => a + b;
//
// console.log(sum(5, 15));

//var sum = (a, b) => {
//    var x = 10;
//
//    if(a>b) {
    // }
    // return a + b;
//}
//console.log(sum(5, 20));

//var obj = {
  //  showContext: function showContext() {
        //this = obj

    //    setTimeout(() => {
      //      this.log('after 1000ms');
        //    }, 1000);
    //},
    //log: function log(value) {
      //  console.log(value)
    //}
//};
//obj.showContext();

//DEFAULT FUNCTION ARGUMENTS
//function multiply (a, b) {
  //  return a * b;
//}
//console.log(multiply(5, 5));

//lazy evaluation
//function randomNumber() {
  //  return Math.random() * 10;
//}
//function multiply(a, b = randomNumber()) {
  //  return a * b;
    //}
    //console.log(multiply(5))

//Enhanced Object Literals
//var obj = {
  //  prop1: "Digital Inovation One"
//};
//var prop1 = "Digital Inovation One"

//Rest (...) and Spread Operator

function sum(a, b) {
    return a + b;
}
console.log(sum(5, 5, 5, 2, 3));

function sum (...args) { 
    console.log (args);
}
console.log(sum(5, 5, 5, 2, 3))

function sum(...args) { 
    console.log(args);
}
console.log(sum(5, 5, 5, 2, 3));