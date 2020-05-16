$(document).ready(function () {
    function animateProgressBar(percentageCompleted)
    {
        const WIDTH_BACKGROUND = 500

        ('#progressbar-inner').animate({
            'width': (WIDTH_BACKGROUND * percentageCompleted) / 100
        }, 3000);

        $({ counter: 1 }).animate({ counter: percentageCompleted }, {
            duration: 3000,
            step: function () {
                $('#progressbar-inner').text(Math.ceil(this.counter) + ' %')
            }
        })
    }   
})