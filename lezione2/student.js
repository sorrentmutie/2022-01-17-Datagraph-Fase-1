var persona = {
    nome: 'Mario',
    cognome: 'Rossi'
};

var studente = {
    matricola: 'A0001'
};

Object.setPrototypeOf(studente, persona);

console.log(Object.keys(studente));

for (var property in studente) {
    var value = studente[property];
    console.log(property, value);
}

var human = new Object();
console.log(human);


function Persona(nome, cognome) {
    this.nome = nome;
    this.cognome = cognome;
    this.nomeCompleto = function(){
        console.log(this);
        return this.nome + ' ' + this.cognome;
    }
}

var mario = new Persona("Mario", "Rossi");
console.log(mario.nomeCompleto());

var maria = Persona("Maria", "Rossi");
// console.log(maria.nomeCompleto());
//console.log(maria);


var mario = new Persona("Mario", "Rossi");
mario.nomeCompleto();