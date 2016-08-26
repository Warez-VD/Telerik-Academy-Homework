function HideOrShowContent(selector) {
    var $element;

    if (typeof selector !== 'string' &&
        	!(selector instanceof $)) {
        throw new Error("Invalid ID");
    }

    $element = $(selector);

    $element.children(".button")
            .html("hide")
            .on("click", function () {
                var $currentElement = $(this);

                if ($currentElement.next().hasClass("button")) {
                    return;
                }
                    
                while ($currentElement) {
                    if($currentElement.next().hasClass("content") &&
                        $currentElement.next().css("display") === 'none') {
                        $currentElement.next().css("display", "");
                        $currentElement.prev(".button").html("hide");
                        return;
                    } else if ($currentElement.next().hasClass("content")) {
                        $currentElement.next().css("display", "none");
                        $currentElement.prev(".button").html("show");
                        return;
                    }

                    $currentElement = $currentElement.next();
                }
    });
}

HideOrShowContent("#root");
