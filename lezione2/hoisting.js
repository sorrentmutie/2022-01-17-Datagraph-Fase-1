// var a = 5;
console.log(x);
//console.log(y);
var x = 1;

// var x = undefined;
// ..
// x = 1;

y = 1;

let read, write;
{
   var data = {};
   write = function(chiave, valore) {
       data[chiave] = valore;
   }
   read = function(chiave) {
       return data[chiave];
   }
}

write('javascript', 'ciao');
console.log(read('javascript'));
console.log(data);