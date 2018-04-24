$(document).ready(function () {
    $("formdata").submit(function (e) {
        var $this = $(this);
        var frmValues = $this.serialize();
        $.ajax({
            type: $this.attr('method'),
            url: $this.attr('action'),
            data: frmValues,
            success: function (data) {
                $("#changeddata").html(data);
            }
        })
        .done(function (data) {
            $("#changeddata").html(data);
        })
        .fail(function () {
            $("#changeddata").text("An error occured");
        });
        e.preventDefault();
    });
});