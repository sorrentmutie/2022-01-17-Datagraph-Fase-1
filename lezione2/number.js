var c = (0.1 + 0.2) - 0.3;
console.log(c);
// (a + b ) + c != a + (b + c)

if (!Number.prototype.miafunzione){
    Number.prototype.miafunzione = function(number){
            return 42;
    }
}

// NaN
// NaN === NaN
var nan = isNaN(NaN);

var a = 15;
var b = "16";
var c = a/ b;
console.log(c);

var x = Number("215");
var y = + "215";
var z = parseInt("215",10);
parseInt("08") // 0
parseInt("08", 10) // 8



