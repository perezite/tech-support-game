using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool isLocked = false;
		
		// determine, if door is still locked
		foreach (Transform childTransform in transform.transform)
		{
			ColorSwitcher colorSwitch = childTransform.gameObject.GetComponent<ColorSwitcher>();
			if (colorSwitch != null) 
			{
				if (colorSwitch.isActive == true)	// door is locked, if there is a least a single active color 
				{ 
					isLocked = true;
					break;
				}
			}
		}
		
		// remove the door, if it is unlocked
		if (isLocked == false) {
			DestroyImmediate(gameObject);
		}
	}
}
