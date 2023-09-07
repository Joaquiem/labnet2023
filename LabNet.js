

let numeroSecreto = Math.floor(Math.random() * 20) + 1;
let intentos = 20;
let puntajeMaximo = 0;



function adivinarNumero() {



    const numeroUsuario = parseInt(document.getElementById('numeroUsuario').value);


    if (isNaN(numeroUsuario)) {
        alert("Por favor, introduce un número válido.");
        return;
    }

    if (numeroUsuario > numeroSecreto) {
        document.getElementById('mensaje').textContent = `El número secreto es menor. Intentos ${intentos}  `;
        intentos--;
    } else if (numeroUsuario < numeroSecreto) {
        document.getElementById('mensaje').textContent = `El número secreto es mayor. Intentos ${intentos}`;
        intentos--;
    } else {
        let mensaje = `Tu puntaje fue de ${intentos}`
        if (puntajeMaximo < intentos) {
            puntajeMaximo = intentos
            mensaje = `Felicidades, nuevo record con ${puntajeMaximo} puntaje`
        }
        document.getElementById('mensaje').textContent = `¡Felicidades! Adivinaste el número .`;
        document.getElementById("puntaje").textContent = mensaje;
    }
}

function reset(){
    document.getElementById("mensaje").textContent = '';
    document.getElementById("puntaje").textContent = '';
    numeroSecreto = Math.floor(Math.random() * 20) + 1;
    intentos = 20
    
}
