using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DudeController : MonoBehaviour {

	// speed of the dude
	public float speed = 0.1f;

	private MoveState moveState;

	// move state enumeration
	enum MoveState {Moving, Idle, Paralized};

	// end point of movement
	private Vector2 targetPosition = new Vector2(); 

	// Use this for initialization
	void Start () {
		moveState = MoveState.Idle;	
		targetPosition = VectorHelper.Vector3ToVector2(transform.position);
	}
		
	// Paralize the dude (not allowed to accept input anymore)
	public void Paralize()
	{
		moveState = MoveState.Paralized;
	}		

	// Update is called once per frame
	void Update () {
		if (moveState == MoveState.Idle)
			HandleInput();	
	}
	
	void FixedUpdate() {
		Move ();
	}
		
	// Handle the input
	void HandleInput() 
	{
		Vector2 previousTargetPosition  = targetPosition;
	
		// set endpoint
		if (InputHelper.IsPointing("Left")) {
			moveState = MoveState.Moving;
			targetPosition = new Vector2((int)targetPosition.x - 1, targetPosition.y);
		}
		else if (InputHelper.IsPointing("Right")) {
			moveState = MoveState.Moving;
			targetPosition = new Vector2((int)targetPosition.x + 1, targetPosition.y);
		}
		else if (InputHelper.IsPointing("Up")) {
			moveState = MoveState.Moving;
			targetPosition = new Vector2(targetPosition.x, (int)targetPosition.y + 1);
		}
		else if (InputHelper.IsPointing("Down")) {
			moveState = MoveState.Moving;
			targetPosition = new Vector2(targetPosition.x, (int)targetPosition.y - 1);
		}	
		
		// if chosen target point is within wall, discard and stay idle
		if (IsOccupiedByWall(targetPosition)) {
			moveState = MoveState.Idle;
			targetPosition = previousTargetPosition;
		}
	}
	
	// Move the dude
	void Move()
	{	
		// move towards target
		Vector2 currentPosition = VectorHelper.Vector3ToVector2(transform.position);
		Vector2 newPosition = Vector2.MoveTowards(currentPosition, targetPosition, Time.deltaTime*speed);
		transform.position = VectorHelper.Vector2ToVector3(newPosition, transform.position);
		
		// set to idle, if we are near enough the target and not paralized
		if (moveState != MoveState.Paralized)
		{
			float threshold = 0.01f;
			if (Vector2.Distance(newPosition, targetPosition) < threshold)
				moveState = MoveState.Idle;
		}	
	} 
	
	// check if a point is occluded by a wall
	bool IsOccupiedByWall(Vector2 point)
	{
		// collect all collidable objects
		Vector3 point3D = new Vector3(point.x, 0.1f, point.y);
		GameObject [] walls = GameObject.FindGameObjectsWithTag("Wall");
		GameObject [] doors = GameObject.FindGameObjectsWithTag("Door");
		
		// add collidable objects to list
		List<GameObject> collidableObjects = new List<GameObject>();
		collidableObjects.AddRange(walls);
		collidableObjects.AddRange(doors);
		
		foreach (GameObject collidableObject in collidableObjects)
		{
			if (collidableObject.GetComponent<Collider>().bounds.Contains(point3D))
			{
				return true;
			}
		}
		
		return false;
	} 
	
}
