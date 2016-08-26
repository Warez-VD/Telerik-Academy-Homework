function CreateElementsInsideList(selector, count) {
    var element = selector,
        liElementsCount = count,
	   $list = $("<ul />")
                .addClass("items-list")
                .prependTo("body"),
	   $element = $(element),
  	   i;

    if ($element.length === 0) {
        return;
    }

    if(liElementsCount === undefined ||
        typeof liElementsCount === 'object' ||
        liElementsCount < 1) {
        throw new Error("Count is invalid");
    } else if(typeof liElementsCount === 'string') {
        liElementsCount = +count;
        if (isNaN(liElementsCount)) {
            throw new Error("Count is invalid");
        }
    }

    for (i = 0; i < count; i += 1) {
        $("<li />")
        .addClass("list-item")
        .html("List item #" + i)
        .appendTo($list);
    }
}

CreateElementsInsideList(".items-list", 1);