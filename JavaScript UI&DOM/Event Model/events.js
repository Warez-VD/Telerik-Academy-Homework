function solve() {
    return function (selector) {
        var element,
            i,
            length;

        if (typeof (selector) === 'string') {
            element = document.getElementById(selector);
        } else if (selector !== null || selector !== undefined
            && selector instanceof HTMLElement) {
            element = selector;
        } else {
            throw "Invalid selector";
        }

        length = element.childNodes.length;

        for (i = 0; i < length; i += 1) {
            if (element.childNodes[i].className === 'button') {
                element.childNodes[i].innerHTML = "hide";
            }
        }

        var buttonElements = document.getElementsByClassName('button');

        element.addEventListener('click',
            function (ev) {
                var targetButton = ev.target;
                var nextElement;

                if (targetButton.className !== 'button') {
                    return;
                } else {
                    nextElement = isContentAfterClicked(targetButton);

                    if (nextElement) {
                        if (nextElement.style.display === 'none') {
                            nextElement.style.display = '';
                            targetButton.innerHTML = "hide";
                        } else {
                            nextElement.style.display = 'none';
                            targetButton.innerHTML = "show";
                        }
                    }
                }
            }, false);

        function isContentAfterClicked(clicked) {
            var nextSibl = clicked.nextElementSibling;

            while (nextSibl) {
                if (nextSibl.className === 'button') {
                    return false;
                }

                if (nextSibl.className === 'content') {
                    return nextSibl;
                }

                nextSibl = nextSibl.nextElementSibling;
            }

            return false;
        }
    };
};

solve('root');