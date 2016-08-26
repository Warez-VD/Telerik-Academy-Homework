function solve() {
            
    function validateParams(parameter) {
        if (parameter === undefined || parameter == null) {
            throw 'InvalidArgumentError';
        }
    }

    function getElement(element) {
        if (typeof element === 'string') {
            element = document.getElementById(element);
        }

        if (!(element instanceof HTMLElement)) {
                throw 'No element that has such an ID';
        }

        return element;
    }
    
    function validateContents(contents) {
        var length,
            i;

        if (!(Array.isArray(contents))) {
            throw 'InvalidArgumentError';
        }

        for (i = 0, length = contents.length; i < length; i += 1) {
            validateContent(contents[i]);
        }

        function validateContent(content) {
            if (typeof content !== 'string' && typeof content !== 'number') {
                throw 'InvalidArgumentError';
            }
        }
    }

    
    function appendContent(element, contents) {
        var fragment,
            div,
            divAdded,
            i,
            length;

        element.innerHTML = '';
        div = document.createElement('div');
        fragment = document.createDocumentFragment();

        for (i = 0, length = contents.length; i < length; i += 1) {
            divAdded = div.cloneNode(true);
            divAdded.innerHTML = contents[i];
            fragment.appendChild(divAdded);
        }

        element.appendChild(fragment);
    }

    return function (element, contents) {
        validateParams(element);
        validateParams(contents);
        validateContents(contents);
        element = getElement(element);
        appendContent(element, contents);
    }
}