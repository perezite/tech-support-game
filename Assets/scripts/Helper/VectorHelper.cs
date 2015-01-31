using UnityEngine;
using System.Collections;

public static class VectorHelper  {

	// map x->x, y->z, leave Y untouched
	public static Vector3 Vector2ToVector3(Vector2 vector2, Vector3 vector3)
	{
		return new Vector3(vector2.x, vector3.y, vector2.y);
	}
	
	// map x->x, z->y
	public static Vector2 Vector3ToVector2(Vector3 vector3)
	{
		return new Vector2(vector3.x, vector3.z);
	}	

}
