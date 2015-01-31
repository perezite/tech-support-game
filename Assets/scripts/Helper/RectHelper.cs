using UnityEngine;
using System.Collections;

public static class RectHelper {

	// Create and return a rect with absolute screen-coordinates (in pixels) from relative coordinates.
	// Used for GUI rendering.
	public static Rect ScreenRelativeToAbsolute(float left, float top, float width, float height)
	{
		return new Rect(left*Screen.width, top * Screen.height, 
						width*Screen.width, height * Screen.height);
	} 
	
}
