
const kepek = ["tumblr_1620f8cef4cb674cf57f45cafe935655_677b4024_400.jpg","1-5922.jpg","98f6549d-ae59-4403-bbeb-553e848050ea-1700075563416.jpg","5206039271_163b21e2b2_b.jpg","bodocs.jpg.jpg","Brian-740x478.jpg","dicap.jpg","e9aedfee5cb726c2fc10356721ca042d4aa20430-1804x1080.jpg","ems_chjklwvtcy1hc3nldhmvbw92aw.jpg","fjisf51m458d1.jpeg","holygrail-arthur-3knights.jpg","Image-Via-NBC.jpg","Képernyőkép 2025-01-22 093116.png","ki-nyert-a-fidesz-38093-1.jpg","matmatikus_on_fit_1200x10000.jpg","metnet_upload.jfif","montypythonandtheholygrail_tall.jpg","oc1usxewbi741.jpg","promotional-still-The-Office-Steve-Carell.jpg","The_Rabbit_of_Caerbannog.jpg"];


const kepDarab = 4;
let pakli = [];

let felforditva = [];

function init()
{
	let seged = 0;

    for (let i = 0; i < kepDarab; i++)
    {
        let temp = document.createElement("div");
        temp.classList.add("kartya");
        //temp.style.backgroundImage = `url(${kepek[i]})`;
		//temp.style.backgroundImage = "url(" + kepek[seged] + ")";
		temp.dataset.kep = "url(" + kepek[seged] + ")";
		//temp.style.backgroundImage = "url(" + kepek[Math.floor(i/2)] + ")";

		temp.onclick = function()
		{
			if(felforditva.length < 2)
			{
				if(!(felforditva.length === 1 && felforditva[0] === this))
				{
					this.style.backgroundImage = this.dataset.kep;
					felforditva.push(this);
					console.log(felforditva);
				}
				
			}

			if(felforditva.length >= 2)
			{
				egyenloE();
			}
			
		}

        pakli.push(temp);
        //document.getElementById("asztal").appendChild(temp);

		seged++;
		if(seged >= kepDarab / 2)
		{
			seged = 0;
		}
    }

	pakli = shuffleArray(pakli);
	for (let i = 0; i < pakli.length; i++)
	{
		document.getElementById("asztal").appendChild(pakli[i]);
	}
}

function egyenloE()
{
	//console.log(felforditva);
	if(felforditva[0].style.backgroundImage === felforditva[1].style.backgroundImage)
	{
		felforditva[0].onclick = "";
		felforditva[1].onclick = "";
		felforditva = [];
		checkGameOver();
	}

	else
	{
		setTimeout(visszafordit, 1000)
	}
}


function checkGameOver()
{
	let gameover = true;
	for(let i = 0; i < pakli.length && gameover; i++)
	{
		gameover = gameover && pakli[i].style.backgroundImage !== "";
	}

	if(gameover)
	{
		console.log("Game Over!");
		let end = document.createElement("div");
		end.classList.add("gameover");
		end.innerHTML = "Game Over!";
		document.body.appendChild(end);
	}
}


function visszafordit()
{
	for(let i = 0; i < felforditva.length; i++)
	{
		felforditva[i].style.backgroundImage = "";
	}

	felforditva = [];
}

function shuffleArray(array) {
    for (let i = array.length - 1; i >= 1; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }

	return array;
}