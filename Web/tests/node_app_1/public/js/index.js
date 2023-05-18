const result_p=document.getElementById('fetch_result')
const request_result= await fetch('api/hello?name=Fer&surname=Colomo')
//el fetch es algo que se caracteriza como una promesa, es decir que se realiza de manera asíncorno
//como se hace una solicitud a un servidor, se debe esperar a que el servidor responda se usa esta "promesa"
//para lograr el comportamiento asíncrono se le pone la palabra "await" la cual detiene de cierta forma el script hasta obtener una respuesta

result_p.innerHTML=await request_result.text() //cadena de texto no json
// también es una "promesa"


//const request_result= await fetch('api/hello') hay que cambiar algo aquí para el query
const params= new URLSearchParams({
    name: 'Fer',
    surname: 'Colomo'
});

const response_parameters = await  fetch('http://127.0.0.1:6500/api/hello?' + params, {method: 'GET'})

if(response_parameters.ok)
    {
        const message = await response_parameters.text()

        console.log(message)
        const resultDiv =document.getElementById('fetch_result')
        resultDiv.innerHTML = message
    }
    else
    console.log(`HTTP Error: ${response_parameters.status}`)

const response_json = await fetch('http://127.0.0.1:6500/api/json_test' , {method: 'GET'})


if(response_json.ok)//fetch recibe json
{
        
        const json = await response_json.json()
        console.log(json)
        const resultDiv =document.getElementById('fetch_result')
        resultDiv.innerHTML = json.name + ' ' + json.surname

}
else
    console.log(`HTTP Error: ${response_json.status}`)