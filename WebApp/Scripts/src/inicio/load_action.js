$(document).ready(function () {
    $("#btnIngresar").click(function (event) {
        event.preventDefault();
        AjaxAction("/Home/Ingresar", "GET", "#action");
    });

    $("#btnRegistrarse").click(function (event) {
        event.preventDefault();
        AjaxAction("/Home/Registrarse", "GET", "#action");
    });
});