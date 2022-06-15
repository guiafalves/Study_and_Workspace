var CurrentNumberWrapper = document.getElementById("CurrentNumber")
var CurrentNumber = 0;

function increment() {
    CurrentNumber = CurrentNumber + 1;
    CurrentNumberWrapper.innerHTML = CurrentNumber;
}

function decrement() {
    CurrentNumber = CurrentNumber - 1;
    CurrentNumberWrapper.innerHTML = CurrentNumber;
}