/**
 * @param {string} urlAction - Ruta de URL.
 * urlAction = "/Home/Ingresar";
 * @param {string} method - Metodo GET o POST.
 * method = "GET";
 * @param {string} selector - Cadena del selector.
 * selector = "#action";
 */

function AjaxAction (urlAction, method, selector) {

    $.ajax({
        url: urlAction,
        contentType: 'application/html',
        type: method,
        dataType: 'html',

        success: function (result) {
            $(selector).html(result);
            console.log("success: " + result);
        },

        error: function (xhr, status) {
            console.log("success: " + status);
        }
    });

}