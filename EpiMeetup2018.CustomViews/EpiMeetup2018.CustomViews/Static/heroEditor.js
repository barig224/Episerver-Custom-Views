let isheroPreviewPage = document.querySelector('.hero-preview');

if (isheroPreviewPage) {
    function updateCoordinates(section, elements) {
        let controls = section.querySelectorAll('.hero-preview-section-input');
        let left = section.querySelector('.left');
        let top = section.querySelector('.top');

        //Set initial coordinates in inputs
        [].forEach.call(elements, function (el) {
            left.value = parseInt(el.style.left, 10);
            top.value = parseInt(el.style.top, 10);
        });

        //Updates positioning for elements
        function updateValues() {
            [].forEach.call(elements, function (el) {
                el.style.left = left.value + '%';
                el.style.top = top.value + '%';
            });
        }

        //Listens for input updates
        [].forEach.call(controls, function (input) {
            input.addEventListener('keyup', function () {
                updateValues();
            });

            input.addEventListener('input', function () {
                updateValues();
            });

            input.addEventListener('change', function () {
                updateValues();
            });
        });
    }

    //Header
    let headerSection = document.getElementById('header');
    let headerEl = document.querySelectorAll('.hero-header');
    updateCoordinates(headerSection, headerEl);
}