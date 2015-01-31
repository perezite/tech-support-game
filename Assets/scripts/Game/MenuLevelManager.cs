using UnityEngine;
using System.Collections;

public class MenuLevelManager : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey)
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
