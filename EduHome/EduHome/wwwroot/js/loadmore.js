
$(document).on("click", "#LoadMore", function () {
    $.ajax({
        url: "/Courses/Test/",
        type:"get",
        success: function (html) {
            console.log("Salam")
        }
    });
});