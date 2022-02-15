function faQualcosaDiBloccante(secondi){
    var start = Date.now();
    var now = start;
    while(now - start < (secondi * 1000)){
        now = Date.now();
    }
}

function main(){
    console.log('A');
    setTimeout( function() { console.log('B')}, 0);
   // faQualcosaDiBloccante(3);
    console.log('C');
}

main();