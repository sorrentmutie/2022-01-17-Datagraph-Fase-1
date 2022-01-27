var myList = [];
var myList2 = ['cani','gatti','pappagalli', 42,  {a: 1}];

myList2[myList2.length] = "mucche";
myList2.pop();
console.log(myList2);

var n = [1, 23, 8, 35, 12, 4];
// console.log(n.sort());

// var x = n.sort(function(a,b){
//     return a-b
// });

// console.log(x);
delete n[2];
n.splice(2, 1);
console.log(n);
// Array.isArray( array)


var a = ["1", "2", "3"] + ["4" + "5" + "6"];
var b = [1, 2, 3] + [4 + 5 + 6];
console.log(b);