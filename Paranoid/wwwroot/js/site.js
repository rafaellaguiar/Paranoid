var lastCopied = ""

function copyToClipBoard(value) {

    navigator.clipboard.writeText(value);
    
    $("#" + value ).removeClass("bi-clipboard-check");
    $("#" + value).addClass("bi-clipboard-check-fill");

    if (lastCopied != "") {
        $("#" + lastCopied).removeClass("bi-clipboard-check-fill");
        $("#" + lastCopied).addClass("bi-clipboard-check");
    }

    lastCopied = value;
}