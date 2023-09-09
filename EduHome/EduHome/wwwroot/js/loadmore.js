
$(document).on("click", "#loadMore", function () {
    $.ajax({
        url: "/Courses/LoadMore/",
        type:"get",
        success: function (res) {
            console.log(res)
        }
    });
});