function CambiarActivas() {

   let cb = document.querySelector('#cbActivas');

    if (cb.checked == true) {

        document.querySelector('#visualizarActivos').style.display = 'block'; 
        document.querySelector('#visualizarTodos').style.display = 'none'; 
        
    } else {

        document.querySelector('#visualizarTodos').style.display = 'block'; 
        document.querySelector('#visualizarActivos').style.display = 'none';
    }

}

function VerDetalle(url) {

    $.get(url, function (data) {
        $("#modalDetalle").html(data);
        $("#modalDetalle").css('height', '46%');
        $("#modalDetalle").show();
    });

}