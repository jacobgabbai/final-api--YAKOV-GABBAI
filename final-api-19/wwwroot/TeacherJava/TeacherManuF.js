
localStorage.setItem("opent", 1)
window.addEventListener("load", function () { load() })
window.addEventListener("beforeunload", () => { localStorage.removeItem("opent") })
const maindiv = document.getElementById("maindiv")
function load() { 
//const name = localStorage.getItem("TeacherName")
//const hh1 = document.createElement("h1")
//hh1.textContent = `Welcome ${name} Select From Manu `
//    hh1.style.fontSize = "40px"
//    hh1.style.marginTop = "10px" 
//    hh1.style.marginLeft="35%"
//    maindiv.appendChild(hh1)

    for (let i = 0; i < 4; i++) {

        const div = document.createElement("div")

        div.id = `id${i}`
        if (i == 0) {
            const p=document.createElement("p")
            p.textContent = "Search For A Test"
            p.style.marginTop="35px"
            div.appendChild(p)
            div.addEventListener("click", function () {looktest() })
        }
        if (i == 1) {

            const p = document.createElement("p")
            p.textContent = "Add Test"
            p.style.marginTop = "35px"
            div.appendChild(p)
            div.addEventListener("click", function () { AddTest() })


        }

        if (i == 2) {

            const p = document.createElement("p")
            p.textContent = "UpDateTest"
            p.style.marginTop = "35px"
            div.appendChild(p)
            div.addEventListener("click", function () { mmmmm() })

        }

        if (i == 3) {

            const p = document.createElement("p")
            p.textContent = "Watch Statistic"
            p.style.marginTop = "35px"
            div.appendChild(p)
            div.addEventListener("click", function () { Statistic() })

        }

        div.style.backgroundColor = "aquamarine"
        div.style.height = "100px"
        div.style.width="300px"
        div.style.marginTop = "20px"
        div.style.marginLeft = "40%"
        div.style.border = "dotted"
        div.style.fontSize = "25px"
        div.style.fontWeight = "bold"
        div.style.textAlign = "center"
        div.style.cursor = "pointer"
        
        maindiv.appendChild(div)

    }

}




function mmmmm() {



    const open = localStorage.getItem("open")
    if (open == 1) { alert("window is open please close other windows") }
    else {
        window.open("https://localhost:7115/TeacherHtml/updatetest.html")
    }
}
function AddTest() {

    //window.open("https://localhost:7115/TeacherHtml/add-test-3.html")
    const open = localStorage.getItem("open")

    if (open == 1) { alert("window is open please close other windows") }
    else {
        window.open("https://localhost:7115/TeacherHtml/Add-Test.html")
    }

}



function looktest() {
    const open = localStorage.getItem("open")

    if (open == 1) { alert("window is open please close other windows") }
    else {
        window.open("https://localhost:7115/TeacherHtml/Test-Search.html")
    }

}
function Statistic() {

    const open = localStorage.getItem("open")

    if (open == 1) { alert("window is open please close other windows") }
    else {

        window.open("https://localhost:7115/TeacherHtml/TeacherStatistic.html")
    }


}