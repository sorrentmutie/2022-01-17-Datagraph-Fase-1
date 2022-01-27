var righello = {mm : 150};

Object.defineProperty(righello, 'inch', {
    enumerable: true,
    get: function(){
        return this.mm / 25.4
    },
    set: function(valore) {
        this.mm = valore * 25.4;
    }
});

righello.inch = 123;
console.log(righello.mm);


var a = 1;
a = "2";
