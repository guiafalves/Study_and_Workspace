// var y = 0;
// var x = 1;

//ax + b = 0

function returnEvenValues(array) {\
    let evenNums = [];
    for(let i = 0; i < array.length; i++) {
    if(array[i] % 2 === 0) {
        evenNums.push(array[i]);
    }
    }    
}
console.log(evenNums);
 let array = [1, 2, 3, 4, 5, 6, 7, 8, 9] 

 returnEvenValues(array);