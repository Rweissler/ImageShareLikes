using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageShareLikes.Web.wwwroot.js
{

    $(() => {
        setInterval(() => {
            updateLikes();
        }, 1000);

        $("#like-button").on('click', function () {
            const id = $("#image-id").val();
            $.post('/home/likeimage', { id }, function () {
                updateLikes();
                $("#like-button").prop('disabled', true);
            });
        });
        function updateLikes() {
            const id = $("#image-id").val();
            $.get('/home/getlikes', { id }, function (result) {
                $("#likes-count").text(result);
            });
        }
    });
}
