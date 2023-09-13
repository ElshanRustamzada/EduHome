let count = 6;
let coursesCount = $("#loadMore").next().val()

$(document).on("click", "#loadMore", function () {
    $.ajax({
        url: "/Courses/LoadMore/",
        type: "get",
        data: {
            skip:count
        },
        success: function (res) {
            $("#myCourses").append(res);
            count += 6;
            if (coursesCount <= count) {
                $("#loadMore").remove()
            }
        }
       
    });
});