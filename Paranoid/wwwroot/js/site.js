$(document).ready(function () {

    $(".tdMacAddress").each((i, item) => {
        let alias = localStorage.getItem("Alias" + item.textContent)
        let macAddress = item.textContent;

        if (alias != null) {
            $('#' + item.textContent + "alias").text(macAddress);

            $("#" + macAddress + "alias").text(alias);
            $("#" + macAddress + "alias").removeClass("d-none");
            $("#" + macAddress + "alias").addClass("d-inline");
            $("#aliasInput" + macAddress).addClass("d-none");
        }
    });
});

function setAlias() {

}

var lastCopied = ""

function copyToClipBoard(value) {

    navigator.clipboard.writeText(value);
    
    $("#" + value ).removeClass("bi-clipboard-check");
    $("#" + value).addClass("bi-clipboard-check-fill");

    if (lastCopied != "") {
        $("#" + lastCopied).removeClass("bi-clipboard-check-fill");
        $("#" + lastCopied).addClass("bi-clipboard-check");
    }

    alertTimeout()

    lastCopied = value;
}

function alertTimeout() {
    $("#alertCopy").removeClass("d-none");
    $("#alertCopy").addClass("d-inline");
    setTimeout(() => {
        $("#alertCopy").removeClass("d-inline");
        $("#alertCopy").addClass("d-none");
    }, 3000);

}

function changeInputVisibility() {
    $('#inputAlias').removeClass('d-none')
    $('#inputAlias').addClass('d-inline')

    $('#btnConfirmar').removeClass('d-none')
    $('#btnConfirmar').addClass('d-inline')

    $('#btnEdit').addClass('d-none')
}

const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))