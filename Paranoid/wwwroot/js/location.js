var locationObj;

function getLocationConfig() {
    $.ajax({
        url: "get/locationConfig",
        success: (data) => {
            locationObj = data.locationConfigList;
        }
    })
}

function clickFlag(language) {
    var text = ""
    for (var i = 0; i < locationObj.length; i++) {
        text = language == "en" ? locationObj[i].valueEn : locationObj[i].valuePt
        $("#" + locationObj[i].key).text(text);

        if (locationObj[i].key.includes("Tooltip")) {
            $("." + locationObj[i].key).attr({
                "data-bs-original-title": text,
                "aria-label": text,
            });
        }

        if (locationObj[i].key.includes("placeholder")) {
            $("." + locationObj[i].key).attr({
                "placeholder": text
            })
        }
    }

}