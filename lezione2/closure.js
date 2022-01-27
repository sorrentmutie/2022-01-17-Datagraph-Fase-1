function init() {
    var nome = "Salvatore";
    function displayNome() {
        console.log(nome);
    }
    displayNome();
}

function init2() {
    var nome = "Salvatore";
    function displayNome() {
        console.log(nome);
    }
    return displayNome;
}

var myFunc = init2();
myFunc();


// init();