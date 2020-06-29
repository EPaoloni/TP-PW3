$(document).ready(function () {
    $('select').formSelect();
    $('.datepicker').datepicker();

    $('#select-tipo-donacion').on('change', function () {
        debugger;
        switch ($(this).val()) {
            case "1":
                enableFieldsMonetaria();
                break;
            case "2":
                enableFieldsInsumos();
                break;
            default:
                break;
        }
    });

    // Desactivo los inputs template
    $('.insumo-container-template').find('input').attr('disabled', true);
    $('.insumo-container-template').find('input').addClass("form-control col s11"); 

    $('#button-agregar-insumo').on('click', function () {
        addInsumo();
    });
});

function enableFieldsInsumos() {
    $('#campos-monetaria-container').hide();
    $('#campos-insumos-container').show();

    // Limpio los campos para monetaria
    $('#campos-monetaria-container').find('input').each(function () {
        $(this).val("")
    });
}

function enableFieldsMonetaria() {
    $('#campos-insumos-container').hide();
    $('#campos-monetaria-container').show();

    // Limpio los campos para insumos
    $('#campos-insumos-container').find('input').each(function () {
        $(this).val("")
    });

    // Limpio los insumos cargados
    $('.insumo-container').remove();
}

function addInsumo() {

    let nombreInsumoAgregar = $('.nombre-insumo-agregar').val();
    let cantidadInsumoAgregar = $('.cantidad-insumo-agregar').val();

    // Valido que los campos no esten vacios
    if (nombreInsumoAgregar.trim() == "" || cantidadInsumoAgregar.trim() == "") {
        return false;
    }

    let cantInsumos = $('#insumos-cargados-container').children().length;

    let insumoTemplate = $('.insumo-container-template').get(0);
    let newInsumo = $(insumoTemplate).clone();

    $(newInsumo).removeClass('insumo-container-template');
    $(newInsumo).addClass('insumo-container');

    $(newInsumo).find('.nombre-insumo-cargado').find("input").val(nombreInsumoAgregar);
    $(newInsumo).find('.cantidad-insumo-cargado').find("input").val(cantidadInsumoAgregar);

    $(newInsumo).show();

    $(newInsumo).find('.button-delete-insumo').on('click', function () {
        removeInsumo(this);
    });

    let insumosList = $(newInsumo).find("input")

    for (var i = 0; i < insumosList.length; i++) {
        let idNewInsumo = $(insumosList[i]).prop('id');
        let nameNewInsumo = $(insumosList[i]).prop('name');

        let newId = idNewInsumo.replace('0', (cantInsumos - 1).toString());
        let newName = nameNewInsumo.replace('0', (cantInsumos - 1).toString());

        $(insumosList[i]).prop('id', newId);
        $(insumosList[i]).prop('name', newName);

        $(insumosList[i]).removeAttr('disabled');
        $(insumosList[i]).attr('readonly', true);
    }


    $('#insumos-cargados-container').append(newInsumo);


    $('.nombre-insumo-agregar').val("");
    $('.cantidad-insumo-agregar').val("");
}

function removeInsumo(campoInsumo) {
    $(campoInsumo).parents('.insumo-container').remove();
}