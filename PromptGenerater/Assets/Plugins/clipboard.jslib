// Assets/Plugins/clipboard.js
mergeInto(LibraryManager.library, {
    CopyTextToClipboard: function (textPtr) {
        var text = UTF8ToString(textPtr);
        var dummy = document.createElement("textarea");
        document.body.appendChild(dummy);
        dummy.value = text;
        dummy.select();
        document.execCommand("copy");
        document.body.removeChild(dummy);
    }
});
