$(document).ready(function () {
    $('select').formSelect();
    $('.datepicker').datepicker();

    $('#select-tipo-donacion').on('change', function () {
        switch ($(this).val()) {
            case "Monetaria":
                enableFieldsMonetaria();
                break;
            case "Insumos":
                enableFieldsInsumos();
                break;
            default:
                break;
        }
    });

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

    let insumoTemplate = $('.insumo-container-template').get(0);
    let newInsumo = $(insumoTemplate).clone();

    $(newInsumo).removeClass('insumo-container-template');
    $(newInsumo).addClass('insumo-container');

    $(newInsumo).find('.nombre-insumo-cargado').val(nombreInsumoAgregar);
    $(newInsumo).find('.cantidad-insumo-cargado').val(cantidadInsumoAgregar);

    $(newInsumo).show();

    $(newInsumo).find('.button-delete-insumo').on('click', function () {
        removeInsumo(this);
    });

    $('#insumos-cargados-container').append(newInsumo);


    $('.nombre-insumo-agregar').val("");
    $('.cantidad-insumo-agregar').val("");
}

function removeInsumo(campoInsumo) {
    $(campoInsumo).parents('.insumo-container').remove();
}