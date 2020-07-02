$(document).ready(function () {

    $('.modal').modal();

});

function VerDetalle(url) {

    $.get(url, function (data) {
        $("#modalDetalle").html(data);
        $("#modalDetalle").css('height', '46%');
        $("#modalDetalle").show();
    });

}