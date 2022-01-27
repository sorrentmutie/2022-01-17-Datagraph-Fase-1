// var f = undefined;

var x = function (a,b,c) {
    console.log(this);
    return a + b + c;
}

var y = x(1,2,3);
console.log(y);

var somma = function(a,b) {
    return a + b;
}

var moltiplicazione = function(a,b) {
    return a * b;
}

var z = function(n1,n2, funzione) {
    return funzione(n1,n2);
}

var z1 = z("1","2",somma);
// var z1 = z(1,2,moltiplicazione);
console.log(z1);

function miaFunzione(a,b) {
    console.log(this);
    return a+ b;
}

var oggetto = {
    a: 1,
    b: 2,
    c: function(){
        console.log('ciao');
        console.log(this);
    }
}


//console.log(x(1,4, 4));
oggetto.c();