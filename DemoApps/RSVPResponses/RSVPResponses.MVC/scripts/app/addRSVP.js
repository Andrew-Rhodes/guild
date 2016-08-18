$(document)
    .ready(function () {
        // tied to our checkbox
        $('#Guest_Attending')
            .change(function() {
                if ($(this).is(":checked")) {
                    $('#gameChoice').show();
                } else {
                    $('#gameChoice').hide();
                    $('#gameChoice select').val('');
                }
            });

        $('#gameChoice').hide();

        // tied to the drop down list
        $('#Guest_FavoriteGame').hide();
        $('#gameList')
            .change(function() {
                if ($(this).val() == 'Other') {
                    $('#Guest_FavoriteGame').val('');
                    $('#Guest_FavoriteGame').show();
                } else {
                    $('#Guest_FavoriteGame').hide();
                    $('#Guest_FavoriteGame').val($(this).val());
                }
            });

        $('#gameList').append($('<option>', {
            value: 'Other',
            text: '<<Other>>'
        }));

        $('.days')
            .change(function() {
                var dayValue = 0;
                $('.days:checked')
                    .each(function() {
                        dayValue += parseInt($(this).val());
                    });

                $('#Guest_Days').val(dayValue);
            });
    });