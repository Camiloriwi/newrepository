
//1. url base del localhost

// http://localhost:3000/jobs
const urlBase ="http://localhost:3000";

//2. selectores html 

const Name = document.querySelector("#title-job");
const location1 = document.querySelector("#link-proyecto");
const description = document.querySelector("#description");
const userId = document.querySelector("#idJobUpdate");
const form = document.querySelector("#formJobs");
const tbody = document.querySelector(".tbodyContent");

// 2. addEventListener para cargar la funcion apenas se inicie el navegador  y que no quede con valores precargados


document.addEventListener("DOMContentLoaded", () => {
    Name.value = "";
    userId.value = "";
    location1.value = "";
    description.value = "";

  NewProyect();
});

// 3.funcion  para reconocer el evento click de los botones elimiar y editar 

document.body.addEventListener("click", (event) => {
  
  const id = event.target.getAttribute("userId");
  if (event.target.classList.contains("btn-delete")) {
   
    deleteProyect(id);
  }
  if (event.target.classList.contains("btn-editar")) {
    editProyect(id);
  }
});

//4.  funtion editJobs para editar los new jobs

async function  editProyect(id) {
  
  const job = await getById(id);
  userId.value = job.id;
  Name.value = job.company;
  description.value = job.description;

}

// funtion get para traer la informacion de la base de datos

async function get() {
  const response = await fetch(`${urlBase}/repositorios`);
  const data = response.json();

  return data;
}

// funtion para reconocer la informacion de la base de datos por id

async function getById(id) {
  const response = await fetch(`${urlBase}/repositorios/${id}`);
  const data = response.json();

  return data;
}

// funtion aplicando el method post

async function createProyect(repositorios) {
  await fetch(`${urlBase}/repositorios`, {
    method: "POST",
    Headers: {
      "content-Type": "application/JSON",
    },
    body: JSON.stringify(repositorios),
  });
}


// funcion  aplicando el metodo delete para eliminar un job ya existente

async function deleteProyect(id) {
  await fetch(`${urlBase}/repositorios/${id}`, {
    method: "DELETE",
  });
}

// funtion aplicando el metodo put

async function updateProyect(id, repositorios) {
  await fetch(`${urlBase}/repositorios/${id}`, {
    method: "PUT",
    Headers: {
      "content-Type": "application/JSON",
    },
    body: JSON.stringify(repositorios),
  });
}

// funtion aplicando el renderisado e inyectando el tr con un foreach para cargar los nuevos jobs en la pagina mediante innerthtml


async function NewProyect() {
  const repositorios = await get();
  tbody.innerHTML ='';
  repositorios.forEach((repositorio) => {
    tbody.innerHTML += `
    
        <tr>
            
            <td style="background-color: rgba(128, 128, 128, 0.362);"><img src="/${repositorio.imagen}" width="60px" height="60px"></td>
            <td style="background-color: rgba(128, 128, 128, 0.362);">${repositorio.company}</td>
            <td  style="background-color: rgba(128, 128, 128, 0.362);width: 10rem;"><a href="/${repositorio.location}">${repositorio.location}</a></td>

            <td style="background-color: rgba(128, 128, 128, 0.362);"> 

                <button class="btn btn-outline-dark btn-editar"  data-bs-toggle="modal" data-bs-target="#staticBackdrop"userId="${repositorio.id}">editar</button></button>
                <button class="btn btn-outline-warning btn-delete"  userId="${repositorio.id}">eliminar</button>
            
            </td>
        </tr>
    `;
  });
}

// funcion  que obtiene los valores ingresados por el usuario
//  y los aplica dinamicamente ala base de datos
async function createNewProyect() {
  
  const repositorio ={
    id: userId.repositorio,
    imagen: "images/images1.jpeg",
    company: Name.value,
    location: location1.value,
    description: description.value,


  }


  if (userId.value ) {
    await updateProyect(userId.value, repositorio);
  }else{
    await createProyect(repositorio);
  }

}

// aplicando un addEventListener al formulario para que reconosca  cuando se envio el formulario con metodo submit

form.addEventListener('submit', (event) =>{

  event.preventDefault();
  createNewProyect();
  NewProyect();
});
