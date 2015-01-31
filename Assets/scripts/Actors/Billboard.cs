using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {	
		transform.rotation = Camera.main.transform.rotation;		
	}
}
