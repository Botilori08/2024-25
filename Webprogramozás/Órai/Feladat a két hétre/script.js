
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

function ido(){
    var ido=new Date();
    const strIdo = ido.toLocaleTimeString()
    document.getElementById("ido").innerHTML= "Pontos idő: " + strIdo 
}

function Otszam()
{
    var szamlalo = 0
    var szamLista = []
    while(szamlalo != 5)
    {
        var szam = prompt("Kérek egy számot! ")
        szamlalo += 1
        szamLista.push(Number(szam))
    }

    szamLista.sort((function(a, b){return a-b}))

    const legkisebb = szamLista[0]
    console.log(legkisebb)
    document.getElementById("szam").innerHTML = "A legkisebb szám: "+legkisebb;
}

var darabszam = 0

function hattalOszthato(){

    var bekert = prompt("Kérek egy számot!")
    if (bekert %6 == 0)
    {
        darabszam+=1
    }
    document.getElementById("bekeres").innerHTML= "A hattal osztható számok száma: "+darabszam

}

var randomLista = []
var parosak = []
while (randomLista.length != 15)
{
    var szam = Math.floor(Math.random()*100)
    randomLista.push(szam)
    if (szam %2 ==0)
    {
        parosak.push(szam)
    }
}

function Bekeres(){
    var bekertSzamok = []
    var bekeresekSzama = 0
    var bekertSzam = 1
    while (bekertSzam > 0)
    {
        bekertSzam = prompt("Kérek egy számot! ")
        bekeresekSzama += 1
        bekertSzamok.push(bekertSzam)
        if (bekertSzam == 0)
        {
            break
        }
    }
    
    bekertSzamok.splice(-1)
    bekertSzamok.sort((function(a, b){return a-b}))
    console.log(bekertSzamok)

    document.getElementById("bekeresekSzama").innerHTML += bekeresekSzama
    document.getElementById("legkisebb").innerHTML += bekertSzamok[0]
    document.getElementById("legnagyobb").innerHTML += bekertSzamok[bekertSzamok.length -1]

}



document.addEventListener("DOMContentLoaded", function() {
    document.getElementById("randomLista").innerHTML += randomLista
    document.getElementById("parosak").innerHTML += parosak
})
