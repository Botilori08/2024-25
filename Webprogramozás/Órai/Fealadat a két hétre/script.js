function datun(){
    var ido=new Date();
    
}


document.write("<h1>"+"Szorzások"+"</h1>")

function negyzetreEmel(){
    var szamlalo = 0
    var szamok = []
    while (szamlalo!=5)
    {
        var szam = prompt("Kérek egy egész számot! ")
        szamok.push(szam)
        szamlalo += 1
    }
    document.getElementById("megadott").innerHTML = "A megadott számok: "+szamok
    
    let negyzetek = []
    console.log(szamok)
    for (let egySzam in szamok)
    {
        console.log(szamok[egySzam]*szamok[egySzam])
        negyzetek.push(szamok[egySzam]*szamok[egySzam])
    }
    document.getElementById("negyzete").innerHTML = "A megadott számok: "+negyzetek
}
