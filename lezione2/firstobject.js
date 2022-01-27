var firstObject = {
    name: "Mario",
    surname: "Rossi",
    indice: 12
};

// console.log(firstObject);

// delete firstObject.indice;

// console.log(firstObject);

console.log(Object.keys(firstObject));

// Object.defineProperty(firstObject, "indiceJavascript", {
//     value: 3,  writable: true, enumerable: true, configurable: true
// });

// console.log(firstObject);

// var descrittore = Object.getOwnPropertyDescriptor(firstObject, 'indiceJavascript');
// console.log(descrittore);

// Object.defineProperty(firstObject, "indiceJavascript", {
//    enumerable: false
// });
// var descrittore = Object.getOwnPropertyDescriptor(firstObject, 'indiceJavascript');
// console.log(descrittore);
// console.log(Object.keys(firstObject));

// Object.defineProperty(firstObject, "indiceJavascript", {
//     writable: false
//  });

//  firstObject.indiceJavascript = 13;
// console.log(firstObject.indiceJavascript);

// 

var valoreIniziale = 12;
Object.defineProperty(firstObject, "indiceJavascript", {
    get: function() {
        console.log('siamo nel get');
        return valoreIniziale;
    },
    set: function(value) {
        console.log('siamo nel set');
        valoreIniziale = value;
    }
 });
 console.log(firstObject.indiceJavascript);
 firstObject.indiceJavascript = 36;
 console.log(firstObject.indiceJavascript);
