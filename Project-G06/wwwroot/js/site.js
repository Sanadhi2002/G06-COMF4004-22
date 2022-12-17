// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

 
let btnSearch = document.getElementById("searchbtn");
let con = document.getElementById("container");

let addDegree1 = document.getElementById("DegreeButton");
addDegree1.addEventListener("click", addnewDegree);

btnSearch.addEventListener("click", Search);
function Search() {
    con.style.visibility ="visible";
 
}

let showPass = document.getElementById("showPass");
showPass.addEventListener("click", showPassword);





//UNIV DASH PAGE

function addnewDegree() {
    console.log("hi1")
    var Row = document.createElement('div')
    Row.classList.add('DegreeName')
    var cdegree = document.getElementsByClassName('DegreeName')[0]

    var DegreeAdd = `
            <h2>Degree</h2>
    <label for="Dname"> Degree Name:</label>
    <input type="text" id="Dname" name="Dname" value=""><br>
    <label for="DType"> Degree Type:</label>
    <input type="text" id="DType" name="DType" value=""><br>
    <label for="DAdRe"> Admission Requirenments:</label>
    <input type="text" id="DAdRe" name="DAdRe" value=""><br>
    <label for="DCC"> Course Content:</label>
    <input type="text" id="DCC" name="DCC" value=""><br>
    <label for="DNSem"> Number of semesters:</label>
    <input type="number" id="DNSem" name="DNSem" value=""><br>
    
    <label for="DCOp"> Career Opportunities:</label><br>
    <textarea name="textarea" rows="3" cols="100">Write something here</textarea><br>
    <label for="DCFe"> Course Fee:</label>
    <input type="text" id="DCC" name="DCC" value=""><br>
    <label for="DUGC"> UGC Approval:</label>
    <input type="text" id="DUGC" name="DUGC" value=""><br>
    <label for="DAUni"> Affiliated Campus Offering the degree:</label>
    <input type="text" id="DAUni" name="DAUni" value="">
    <input type="number" id="DAUni" name="DAUni" value=""><br>
    <label for="DAProg">Academic Progression:</label><br>
    <textarea name="textarea" rows="2" cols="100">Write something here</textarea><br>
    <input type="submit" value="Submit">
            `
    Row.innerHTML = DegreeAdd
    cdegree.append(Row)
}



