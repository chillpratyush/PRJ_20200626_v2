$(document).ready(function () {
    var ulTasks1 = $('#ulTasks1');

    $('#btn1').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/TBL_TRN_TASKS',
            dataType: 'json',
            success: function (data) {
                ulTasks1.empty();
                $.each(data, function (index, val) {
                    var myTask = val.TASK_NAME + ' ' + val.TASK_DESCRIPTION
                    ulTasks1.append('<li>' + myTask + '</li>')
                });
            }

        });
    });
    $('#btnClear1').click(function () {
        ulTasks1.empty();
    });

});