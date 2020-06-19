// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var apiBaseUrl = "https://localhost:44308/api";
var dataTable;
$(document).ready(function () {
    dataTable = $('.dataTable').DataTable({
        "paging": true,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        "responsive": true,
    });

    $("a").on('click', function (e) {
        var link = $(this).attr("href");
        
        if (!IsAbsoluteLink(link)) {
            link = (window.location.protocol + "//" + window.location.host + link).toLowerCase();
        } 

        var winlocation = window.location.href.toLowerCase();
        var indexOfHash = winlocation.indexOf("#");
        if (indexOfHash > -1) {
            winlocation = winlocation.substr(0, indexOfHash)
        }

        var indexOfQues = winlocation.indexOf("?");
        if (indexOfQues > -1) {
            winlocation = winlocation.substr(0, indexOfQues)
        }
        
        if (link === winlocation)
            return false;
    });
});

function IsAbsoluteLink(link) {
    var r = new RegExp('^(?:[a-z]+:)?//', 'i');
    if (r.test(link) ) {
        return true;
    }
    return false;
}