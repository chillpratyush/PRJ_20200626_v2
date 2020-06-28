$(document).ready(function () {
    var ulTasks = $('#ulTasks');

    $('#btn').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/TBL_TRN_TASKS',
            dataType: 'json',
            success: function (data) {
                ulTasks.empty();
                $.each(data, function (index, val) {
                    var myTask = val.TASK_NAME + ' ' + val.TASK_DESCRIPTION
                    ulTasks.append('<li>' + myTask + '</li>')
                });
            }

        });
    });
    $('#btnClear').click(function () {
        ulTasks.empty();
    });

    var ulUser = $('#ulUser');
    $('#btnUser').click(function () {
        $.ajax({
            type: 'GET',
            url: 'api/TBL_TRN_USER',
            dataType: 'json',
            success: function (data) {
                ulUser.empty();
                $.each(data, function (index, val) {
                    var myUserDetails = val.USER_NAME + ' ' + val.USER_ADDRESS
                    ulUser.append('<li>' + myUserDetails + '</li>')
                });
            }

        });
    });
    $('#btnClearUser').click(function () {
        ulUser.empty();
    });

});