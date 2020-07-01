$(document).ready(function () {

    $('.modal').modal();

});

function VerComentarios(url) {

    $.get(url, function (data) {
        $("#modalComentarios").html(data);
        $("#modalComentarios").css('height','43%')
        $("#modalComentarios").show();
    });   

}

function VerDetalle(url) {

    $.get(url, function (data) {
        $("#modalDetalle").html(data);
        $("#modalDetalle").css('height', '46%');
        $("#modalDetalle").show();
    });

}