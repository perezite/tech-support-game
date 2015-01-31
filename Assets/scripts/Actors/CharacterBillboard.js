#pragma strict

var player : GameObject;
var playerxPos : float;
var playerzPos : float;

var spTexN : Material;
var spTexS : Material;
var spTexO : Material;
var spTexW : Material;

var matChanged : boolean;
var timer : float;
var changeMat : boolean;



function Start () {

player = GameObject.FindGameObjectWithTag("Figurine");
//print(player);
playerxPos = transform.position.x;
playerzPos = transform.position.z;
timer = 0.1;

}

function Update()
{
    transform.rotation = Camera.main.transform.rotation;
    if(playerxPos - transform.position.x < -0.01){
    	MovingNorth();   	
    }
    if(playerxPos - transform.position.x > 0.01){
    	MovingSouth();
    	
    }
    if(playerzPos - transform.position.z < -0.01){
    	MovingWest();
    }
    if(playerzPos - transform.position.z > 0.01){
    	MovingEast();
    }
    if(playerzPos != transform.position.z || playerxPos != transform.position.x){
    	changeMat = true;
    } else {
    	changeMat = false;
    }
    //print(transform.position.x);
    playerxPos = transform.position.x;
    playerzPos = transform.position.z;
    
    
}

function MovingNorth(){
	//print("N");
	if(matChanged == false && changeMat == true){
		player.renderer.material = spTexN;
		matChanged = true;
		yield WaitForSeconds(timer);
		matChanged = false;
	}
}
function MovingSouth(){
	//print("S");
	if(matChanged == false && changeMat == true){
		player.renderer.material = spTexS;
		matChanged = true;
		yield WaitForSeconds(timer);
		matChanged = false;
	}
}
function MovingWest(){
	//print("W");
	if(matChanged == false && changeMat == true){
		player.renderer.material = spTexW;
		matChanged = true;
		yield WaitForSeconds(timer);
		matChanged = false;
	}
}
function MovingEast(){
	//print("E");
	if(matChanged == false && changeMat == true){
		player.renderer.material = spTexO;
		matChanged = true;
		yield WaitForSeconds(timer);
		matChanged = false;
	}
}
