function Persona() {
    Persona.prototype.nome = "Salvatore";
    Persona.prototype.cognome = "Salvatore";
    Persona.prototype.amici = ["Mario", "Luigi"];
}

var persona1 = new Persona();
var persona2 = new Persona();

persona2.nome = 'Giuseppe';
persona2.cognome = 'Verdi';
persona2.amici.push("Luisa");

console.log(persona1.amici);