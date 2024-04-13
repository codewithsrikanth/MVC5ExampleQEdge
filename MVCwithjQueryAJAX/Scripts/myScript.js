/// <reference path="jquery-3.7.1.js" />
function F1() {
    var dname = $("#dname").val();
    $.ajax({
        url: "/Home/EmpCount/" + dname,
        type: "get",
        data: "",
        contentType: "application/json",
        success: function (res) {
            $("#sp1").text(res);
        }
    });
}