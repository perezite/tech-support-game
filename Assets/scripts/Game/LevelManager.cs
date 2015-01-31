using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	// public level state
	public LevelState CurrentState;

	// level state enum
	public enum LevelState { Running, PrepareWin, Win, Fail}

	// Timer for countdown states
	float timer;

	// Get Level Manager instance
	public static LevelManager GetInstance() 
	{
		return GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
	}

	// Use this for initialization
	void Start () {
		CurrentState = LevelState.Running;
	}
	
	// Update is called on per frame
	void Update() 
	{
		if (Input.GetKey (KeyCode.Escape))
		{
			Application.Quit();
		}
	}
	
	// Fixed Update
	void FixedUpdate () {	
		// Level State: PREPARE WIN
		if (CurrentState == LevelState.PrepareWin)
		{
			timer = 3f;
			CurrentState = LevelState.Win;
		}
		
		// Level State: WIN
		if (CurrentState == LevelState.Win)
		{
			timer -= Time.deltaTime;
			if (timer <= 0f)
			{
				if (Application.loadedLevel == Application.levelCount - 1) // last level
				{
					Application.LoadLevel(0);								// start from the beginning
				}
				else 		
				{
					Application.LoadLevel(Application.loadedLevel + 1);
				}
			}
		}
	
		// Level State: FAIL
		if (CurrentState == LevelState.Fail)
		{
			if (Input.GetAxis ("Fire1") > 0)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
