using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformController : MonoBehaviour {
	
	public List<GameObject> affectedColors = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "Projectile")
		{
			// switch all affected colors
			foreach (GameObject affectedColor in affectedColors)
			{
				if (affectedColor != null)
				{
					ColorSwitcher colorSwitch = affectedColor.GetComponent<ColorSwitcher>();
					colorSwitch.isActive = !colorSwitch.isActive;
				}
				
			} 
		}
		
		// delete the projectile after first contact with platform
		if (other.gameObject.tag == "Projectile")
		{
			Destroy(other.gameObject);
		}
	}
}
