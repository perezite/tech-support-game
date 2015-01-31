using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

	// The time
	public float Timer;

	// Initial countdown time
	public float InitialTime;

	// Use this for initialization
	void Start () {
		Timer = InitialTime;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (LevelManager.GetInstance().CurrentState == LevelManager.LevelState.Running)
		{
			Timer -= UnityEngine.Time.deltaTime;
			if (Timer < 0f)
			{
				Timer = 0f;
				LevelManager.GetInstance().CurrentState = LevelManager.LevelState.Fail;
				
				// paralize the dude (otherwise, he can still beat the game)
				DudeController dudeController = GameObject.FindGameObjectWithTag("Player").GetComponent<DudeController>();
				dudeController.Paralize();
			}
		}	
	}
}
