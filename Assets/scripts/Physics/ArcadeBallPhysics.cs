using UnityEngine;
using System.Collections;

// physics script for getting an arcade ball physics
// reference: http://forum.unity3d.com/threads/2d-physics-bounciness-issue.211844/
public class ArcadeBallPhysics : MonoBehaviour {
	// Constant speed of the ball
	public float speed = 1f;
	
	// Keep track of the direction in which the ball is moving
	private Vector3 velocity;
	
	// used for velocity calculation
	private Vector3 lastPos;

	// Use this for initialization
	void Start () {
		speed = rigidbody.velocity.magnitude;
	}
		
	void FixedUpdate ()
	{
		// get speed of rigidbody
		speed = rigidbody.velocity.magnitude;
	
		// Get pos of the ball.
		Vector3 pos = transform.position;
		
		// Velocity calculation. Will be used for the bounce
		velocity = pos - lastPos;
		lastPos = pos;
	}
	
	private void OnCollisionEnter(Collision col)
	{
		// Normal
		Vector3 N = col.contacts[0].normal;
		
		//Direction
		Vector3 V = velocity.normalized;
		
		// Reflection
		Vector3 R = Vector3.Reflect(V, N).normalized;
		
		// Assign normalized reflection with the constant speed
		rigidbody.velocity = R * speed;
	}

}
