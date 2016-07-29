function solve(args) {
    "use strict";

    let text = args[0];
    let textCopy = (args + '').replace(/ /g, '&nbsp;');
    text = text.replace(/\s/g, "&nbsp;");
    console.log(text);
}
