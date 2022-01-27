var myObject = {
    city: 'Naples',
    greet() {
        console.log('Ciao da '  + this.city);
    }
};

myObject.greet();

var prop1 = myObject.hasOwnProperty('city');
console.log(prop1);

var prot1 = Object.getPrototypeOf(myObject);
console.log(prot1);

var myDate = new Date(2021, 1, 21);
console.log(myDate.getYear());
myDate.getYear = function(){
    console.log('ho cambiato getDate');
}
console.log(myDate.getYear());


// var myObject2 = myDate;

// do {
//     myObject2 = Object.getPrototypeOf(myObject2);
//     console.log(myObject2);    
// } while (myObject2)

var myObject3 = Object.create(myObject);
myObject3.city = 'Rome';
myObject3.greet();





