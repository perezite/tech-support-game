using UnityEngine;
using System.Collections;

public static class InputHelper {

	// check for pointing along axis 
	public static bool IsPointing(string direction) 
	{
		if (direction == "Left")
		{
			if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") < 0)
				return true;
		}
		if (direction == "Right")
		{
			if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetAxis("Horizontal") > 0)
				return true;	
		}	
		if (direction == "Up")
		{
			if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Vertical") > 0)
				return true;	
		}
		if (direction == "Down")
		{
			if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Vertical") < 0)
				return true;	
		}	
		
		return false;		
		
	}

}
