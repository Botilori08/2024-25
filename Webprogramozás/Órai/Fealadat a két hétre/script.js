function datum(){
    var ido=new Date();
    const strIdo = ido.toLocaleTimeString()
    document.getElementById("datum").innerHTML= "Pontos idő: " + strIdo 
}




//document.write("<h1>"+"Szorzások"+"</h1>")

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
    document.getElementById("negyzete").innerHTML = "A megadott számok négyzetei: "+negyzetek
}


function Atvalto(){
    var centimeter = prompt("Kérek egy centiméter értéket! ")
    var meter = centimeter/100

    document.getElementById("centimeterV").innerHTML = "A megadott érték: "+centimeter+" cm"
    document.getElementById("atvaltas").innerHTML = "Átváltás: "+meter+" m"

}

function Masodfoku(){
    var a = prompt("Mennyi legyen 'a' értéke?")
    var b = prompt("Mennyi legyen 'b' értéke?")
    var c = prompt("Mennyi legyen 'c' értéke?")

    var szamlalox1 = b*-1 + Math.sqrt(((b*-1)**2)-(4*a*c))
    var szamlalox2 = b*-1 - Math.sqrt(((b*-1)**2)-(4*a*c))

    var nevezo = a*2

    var x1 = szamlalox1/nevezo
    var x2 = szamlalox2/nevezo

    document.getElementById("szamok").innerHTML = "a= "+a+"; "+"b= "+b+"; "+"c= "+c+" "

    console.log(x1)
    console.log(x2)

    document.getElementById("megoldas1").innerHTML = "x1= "+ x1
    document.getElementById("megoldas2").innerHTML = "x2= "+ x2

}



