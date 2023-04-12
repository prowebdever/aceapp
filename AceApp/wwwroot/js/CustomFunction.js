function onBegin() {
    $("#preloader").removeClass('loaded');
    $("#preloader").addClass('loaderActive');
}

function onComplete() {
    $("#preloader").removeClass('loaderActive');
    $("#preloader").addClass('loaded');
}

function onFailed() {
    $("#preloader").removeClass('loaderActive');
    $("#preloader").addClass('loaded');
}

function onLoginSuccess(response) {
    $("#response").html(response);
    if (response.indexOf("alert-success") > -1) {
        var url = $("#ReturnUrl").val();
        if (url === '') {
            url = "/";
        }
        setTimeout(function () { window.location.href = url; }, 3000);
    }
    $("#preloader").removeClass('loaderActive');
    $("#preloader").addClass('loaded');
}

function onMemberRegisterSuccess(response) {
    $("#response").html(response);
    if (response.indexOf("alert-success") > -1) {
        setTimeout(function () { window.location.href = "/"; }, 3000);
    }
    $("#preloader").removeClass('loaderActive');
    $("#preloader").addClass('loaded');
}

function onClaimSaveSuccess(response) {
    $("#response").html(response);
    $("#preloader").removeClass('loaderActive');
    $("#preloader").addClass('loaded');
    $("#ui-to-top").click();
}

function onContactUsSuccess(response) {
    $("#response_contact_us").html(response);
    $("#preloader").removeClass('loaderActive');
    $("#preloader").addClass('loaded');
    $("#ui-to-top").click();
}


function onContactUsFailed(response) {
    $("#response_contact_us").html(response);
    $("#preloader").removeClass('loaderActive');
    $("#preloader").addClass('loaded');
    $("#ui-to-top").click();
}


function ActiveLink() {
    $(".rd-nav-item").each(function () { $(this).removeClass('active'); });
    var pathname = window.location.pathname.split("/")[1];
    if (pathname.toLowerCase() === "page") {
        pathname = window.location.pathname.split("/")[2];
    }
    switch (pathname.toLowerCase()) {
        case "":
        case "conteststandings":
            $(".home").addClass("active");
            break;
        case "about-us":
            $(".about_us").addClass("active");
            break;
        
    }
}