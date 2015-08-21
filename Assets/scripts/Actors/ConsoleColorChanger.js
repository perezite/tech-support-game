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

	this.GetComponent.<Renderer>().material = yellowMatL;
	rndVal = Random.value;
	
	tagString = this.transform.parent.tag;
	//print(tagString);
	
	
	if(tagString == "Yellow" && rndVal >= 0.5){
		this.GetComponent.<Renderer>().material = yellowMatL;
	}
	if(tagString == "Yellow" && rndVal < 0.5){
		this.GetComponent.<Renderer>().material = yellowMatR;
	}
	if(tagString == "Green" && rndVal >= 0.5){
		this.GetComponent.<Renderer>().material = greenMatL;
	}
	if(tagString == "Green" && rndVal < 0.5){
	this.GetComponent.<Renderer>().material = greenMatR;
	}
	if(tagString == "Violet" && rndVal >= 0.5){
		this.GetComponent.<Renderer>().material = violetMatL;
	}
	if(tagString == "Violet" && rndVal < 0.5){
	this.GetComponent.<Renderer>().material = violetMatR;
	}
	if(tagString == "Red" && rndVal >= 0.5){
	this.GetComponent.<Renderer>().material = redMatL;
	}
	if(tagString == "Red" && rndVal < 0.5){
		this.GetComponent.<Renderer>().material = redMatR;
	}
	if(tagString == "Blue" && rndVal >= 0.5){
		this.GetComponent.<Renderer>().material = blueMatL;
	}
	if(tagString == "Blue" && rndVal < 0.5){
		this.GetComponent.<Renderer>().material = blueMatR;
	}

}

function Update () {

}