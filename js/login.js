
//Selectores
const formLogin = document.getElementById("formLogin");
const userEmail = document.getElementById("inputEmail");
const userPassword = document.getElementById("inputPassword");
const userID = document.getElementById("userID");
// const userName = document.getElementById("inputName");

const URL ="http://localhost:3000/atministradores";
document.addEventListener("DOMContentLoaded",(e)=>{
  e.preventDefault();
  userEmail=" "; 
  userPassword=" ";
  formLogin=" ";
})

formLogin.addEventListener("submit", (event) => {
  event.preventDefault();

  login();
});

async function login() {
  const response = await fetch(`${URL}?email=${userEmail.value}`);
  const data = await response.json();

  if (!data.length) {
    alert("Email no registrado");
    console.log(userEmail.value);
    return;
  }

  if (data[0].password === userPassword.value) {
    //Autenticar
    localStorage.setItem("isAuthenticated", "true");
    window.location.href = "../html/atministrador.html";
  } else {
    alert("Contraseña incorrecta.");
  }
}
