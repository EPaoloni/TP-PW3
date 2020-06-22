$(document).ready(function() {

    $(".search-icon").on("click", function () {
        $(this).parents("form").submit();
    })

});