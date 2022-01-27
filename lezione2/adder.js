function makeAdder(x) {
    return function(y) {
        return x + y;
    }
}

var somma5 = makeAdder(5);
var somma10 = makeAdder(10);

console.log(somma5(2));
console.log(somma10(1));