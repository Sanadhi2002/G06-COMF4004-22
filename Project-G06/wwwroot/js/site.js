// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let btnSearch = document.getElementById("searchbtn");
let con = document.getElementById("container");

btnSearch.addEventListener("click", Search);

function Search() {
    con.style.visibility = "visible";
}

