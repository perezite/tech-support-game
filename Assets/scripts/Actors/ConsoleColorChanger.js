#pragma strict

var tagString : String;
var rndVal : float;
var yellowMatL : Material;
var yellowMatR : Material;
var violetMatL : Material;
var violetMatR : Material;
var redMatL : Material;
var redMatR : Material;
var greenMatL : Material;
var greenMatR : Material;
var blueMatL : Material;
var blueMatR : Material;


function Start () {

	this.renderer.material = yellowMatL;
	rndVal = Random.value;
	
	tagString = this.transform.parent.tag;
	//print(tagString);
	
	
	if(tagString == "Yellow" && rndVal >= 0.5){
		this.renderer.material = yellowMatL;
	}
	if(tagString == "Yellow" && rndVal < 0.5){
		this.renderer.material = yellowMatR;
	}
	if(tagString == "Green" && rndVal >= 0.5){
		this.renderer.material = greenMatL;
	}
	if(tagString == "Green" && rndVal < 0.5){
	this.renderer.material = greenMatR;
	}
	if(tagString == "Violet" && rndVal >= 0.5){
		this.renderer.material = violetMatL;
	}
	if(tagString == "Violet" && rndVal < 0.5){
	this.renderer.material = violetMatR;
	}
	if(tagString == "Red" && rndVal >= 0.5){
	this.renderer.material = redMatL;
	}
	if(tagString == "Red" && rndVal < 0.5){
		this.renderer.material = redMatR;
	}
	if(tagString == "Blue" && rndVal >= 0.5){
		this.renderer.material = blueMatL;
	}
	if(tagString == "Blue" && rndVal < 0.5){
		this.renderer.material = blueMatR;
	}

}

function Update () {

}