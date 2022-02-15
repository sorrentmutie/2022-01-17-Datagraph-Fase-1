function hello() {
    console.log('sono in hello');
    return "Ciao";
}

async function hello2() {
    const number = Math.random();
    console.log(number);
    return number;
}


async function fetchRandomUsers(numberofUsers){
    const url = "https://randomuser.me/api?results=" + numberofUsers;
    const response = await fetch(url);
    const json = await response.json();
    console.log(json);
    return json.results; 


// chiamata ad api geolocation
// chiamata a google maps
// chiamata a open weather

}


let hello3 = async () => 'Hello';