$(document).ready(function () {
    $('select').formSelect();

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

    $('.button-delete-insumo').on('click', function () {
        removeInsumo(this);
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
    $('insumos-cargados-container').children().remove();
}

function addInsumo() {

    //TODO: Validar que no esten vacios los campos

    let insumoTemplate = $('.insumo-container').get(0);
    let newInsumo = $(insumoTemplate).clone();

    let nombreInsumoAgregar = $('.nombre-insumo-agregar').val();
    let cantidadInsumoAgregar = $('.cantidad-insumo-agregar').val();

    $(newInsumo).find('.nombre-insumo-cargado').val(nombreInsumoAgregar);
    $(newInsumo).find('.cantidad-insumo-cargado').val(cantidadInsumoAgregar);

    $(newInsumo).show();

    $('#insumos-cargados-container').append(newInsumo);
}

function removeInsumo(campoInsumo) {
    $(campoInsumo).parents('.insumo-container').remove();
}