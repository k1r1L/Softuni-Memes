﻿$('.rate').on('click', function () {
    var rankId = $(this).prev().children().last()[0].id;
    var score = $("#" + rankId).val();
    var imageId = rankId.split('-')[1];
    
    $.ajax({
        url: "/Image",
        type: "post",
        data: { rate: score, ImageId: imageId },
        success: function () {
            window.location = "/Image";
        }
    })
});