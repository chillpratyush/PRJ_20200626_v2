
    $(document).ready(function () {
        //var ulTasks = $('#ulTasks');

        $('#btnRegister').click(function () {
            $.ajax({
                url: 'api/TBL_TRN_USER',
                type: 'POST',
                dataType: 'json',
                data: {
                    USER_NAME: $('#txtUserName').val(),
                    USER_ADDRESS: $('#txtUserAddress').val(),
                    USER_PINCODE: $('#txtUserPincode').val()
                },
                success: alert($('#txtUserName').val())


            });


        });
            });
