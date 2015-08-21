using UnityEngine;
using System.Collections;

public class ColorSwitcher : MonoBehaviour {

	// is this color currently active
	public bool isActive = true; 
	
	// Active Material
	private Material activeMaterial;
	
	// Inactive Material
	private Material inactiveMaterial;

	// Use this for initialization
	void Start () {
		inactiveMaterial = (Material)Resources.Load("textures/DarkGrey", typeof(Material));
		activeMaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {	
		if (isActive)
			GetComponent<Renderer>().material = activeMaterial;
		else
			GetComponent<Renderer>().material = inactiveMaterial;
	}
}
