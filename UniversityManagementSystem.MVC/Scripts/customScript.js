
$("#DId").change(function () {
    //var dId = $("#DId").val();
    var dId = $(this).val();

    var params = { departmentId: dId }

    $("#TId").empty();
    $("#TId").append('<option> ---Select Teacher--- </option>');

    $.ajax({
        url: '/Course/GetTeacherByDepartmentId',
        //url: "Course/GetTeacherByDepartmentId",
        type: "POST",
        contentType: "application/json; charset = utf-8",
        data: JSON.stringify(params),
        success: function (response) {
            if (response != undefined && response != null && response != "") {
                $.each(response, function (k, v) {
                    //alert(v.Name);
                    $("#TId").append("<option value = '" + v.Id + "'>" + v.Name + "</option>");
                });
            }
        }

    });

    $("#CId").empty();
    $("#CId").append('<option> ---Select Course Code--- </option>');

    $.ajax({
        url: '/Course/GetCourseByDepartmentId',
        type: "POST",
        contentType: "application/Json; charset = utf-8",
        data: JSON.stringify(params),
        success: function (responseData) {
            if (responseData != undefined && responseData != null && responseData != "") {
                $.each(responseData, function (key, value) {
                    $("#CId").append("<option value = '" + value.Id + "'> " + value.Code + " </option>");
                });
            }
        }
    });

    $("#CraditToBeTaken").val("");
    $("#RemainingCradit").val("");

    $("#CourseName").val("");
    $("#CourseCradit").val("");

});

$("#TId").change(function () {
    var teacherId = $(this).val();
    var params = { teacherId: teacherId }

    $("#CraditToBeTaken").val("");
    $("#RemainingCradit").val("");

    $.ajax({
        url: '/Course/GetTeacherById',
        //url: "Course/GetTeacherByDepartmentId",
        type: "POST",
        contentType: "application/json; charset = utf-8",
        data: JSON.stringify(params),
        success: function (response) {
            if (response != undefined && response != null && response != "") {
                $("#CraditToBeTaken").val(response);
                $("#RemainingCradit").val(response - 10);
            }
        }

    });
});

$("#CId").change(function () {
    var courseId = $(this).val();
    var params = { courseId: courseId }

    $("#CourseName").val("");
    $("#CourseCradit").val("");

    $.ajax({
        url: "/Course/GetCourseById",
        type: "POST",
        contentType: "application/json; charset = utf-8",
        data: JSON.stringify(params),
        success: function (response) {
            if (response != undefined && response != null && response != "") {
                $("#CourseName").val(response.Name);
                $("#CourseCradit").val(response.Credit);
            }
        }
    });
});

$("#DepartmentId").change(function () {
    debugger
    var departmentId = $(this).val();
    
    var params = { departmentId: departmentId }
    $("#CATList").empty();
    $.ajax({
        url: "/Course/GetCourseByDepartment",
        type: "POST",
        contentType: "application/json; charset = utf-8",
        data: JSON.stringify(params),
       
        success: function (resultData) {
            $.each(resultData, function (ka, va) {
                console.log(va.Name);
            });
            
            //if (response != undefined && response != null && response != "") {

            //    //$("#CATList").append("@foreach(var course in response.)");

            //    $.each(response, function (key, value) {
            //        $("#CATList").append("<td>  " + value.Code + " </td>");
            //        $("#CATList").append("<td>  " + value.Name + " </td>");
                    
            //    });
            //}
        }
    });
});
