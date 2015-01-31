using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			LevelManager.GetInstance().CurrentState = LevelManager.LevelState.PrepareWin;
			
			// destroy the dude
			GameObject dude = GameObject.FindGameObjectWithTag("Player");
			Destroy(dude);
			
			// remove the dude's renderer
			GameObject.FindGameObjectWithTag("Level Exit Closer").rigidbody.useGravity = true;
			 
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
}
