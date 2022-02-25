function getDescendants(node, accum = null) {
    accum = accum || [];
    for (let child of node.childNodes) {
        accum.push(child)
        getDescendants(child, accum);
    }
    return accum;
}

var callback = function (e) {
    for (let node of getDescendants(e.srcElement)) {
        if (node.className == "language-json") {
            const content = node.textContent;
            try {
                const json = JSON.parse(content);
                node.innerHTML = "";
                var jsonViewer = new JSONViewer();
                node.appendChild(jsonViewer.getContainer());
                jsonViewer.showJSON(json, -1, -1);
            }
            catch (_) { }
        }
    }
};
document.addEventListener("DOMNodeInserted", callback);