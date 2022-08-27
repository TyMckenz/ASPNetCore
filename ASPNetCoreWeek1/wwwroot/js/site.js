// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function openModel(courseId) {
    let selector = ".CrseStdntModel-" + courseId;

    $(selector).show();
}

function closeModel(courseId) {
    let selector = ".CrseStdntModel-" + courseId;

    $(selector).hide();
}
