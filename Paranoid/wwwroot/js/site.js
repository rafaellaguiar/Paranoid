$(document).ready(function () {

    $(".tdMacAddress").each((i, item) => {
        let alias = localStorage.getItem("Alias" + item.textContent)
        let macAddress = item.textContent;

        if (alias != null) {
            $("#aliasInput" + macAddress).val(alias);
        }
    });
});

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

function changeAlias(alias, macAddress) {
    if (alias != "") {
        localStorage.setItem('Alias' + macAddress, alias);
    }
}

function alertTimeout() {
    $("#alertCopy").removeClass("hidden-alert");
    $("#alertCopy").addClass("d-inline-fade-in");
    setTimeout(() => {
        $("#alertCopy").removeClass("d-inline-fade-in");
        $("#alertCopy").addClass("d-none-fade-out");
    }, 3000);

}

function changeInputVisibility() {
    $('#inputAlias').removeClass('d-none')
    $('#inputAlias').addClass('d-inline')

    $('#btnConfirmar').removeClass('d-none')
    $('#btnConfirmar').addClass('d-inline')

    $('#btnEdit').addClass('d-none')
}

var detalheDispositivo
var mensagem = ""

function viewDetail(macAddress) {
    var myModal = new bootstrap.Modal(document.getElementById('detalheModal'), {
        keyboard: false
    })
    $.ajax({
        url: "get/detalhe?macAddress=" + macAddress,

        success: (data) => {
            detalheDispositivo = data;
            mensagem = data.mensagemRetorno

        },

        complete: () => {
            $("#company").text(detalheDispositivo.company == null ? "No information" : detalheDispositivo.company)
            $("#country").text(detalheDispositivo.country == null ? "No information" : detalheDispositivo.country)
            $("#companyaddress1").text(detalheDispositivo.addressL1 == null ? "No information" : detalheDispositivo.addressL1)
            $("#companyaddress2").text(detalheDispositivo.addressL2 == null ? "No information" : detalheDispositivo.addressL2)
            $("#companyaddress3").text(detalheDispositivo.addressL3 == null ? "No information" : detalheDispositivo.addressL3)

            myModal.show();
        }
    })
}

const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))