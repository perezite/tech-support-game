using UnityEngine;
using System.Collections;

public class GUIRenderer : MonoBehaviour {

	// Stopwatch icon
	public Texture2D StopwatchIcon;

	// Countdown
	public GameObject CountDownObject;

	// Background Texture for GUI Boxes
	public Texture2D BackgroundTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// render the gui
	void OnGUI()
	{
		// container box	
		float leftBox = 1f - 0.25f;
		float topBox = 0.05f;
		float widthBox = 0.2f;
		float heightBox = 0.125f; 
		GUI.skin.box.normal.background = BackgroundTexture;
		GUI.Box (RectHelper.ScreenRelativeToAbsolute(leftBox, topBox, widthBox, heightBox), "");
		
		// stopwatch symbol
		float marginStopwatch = 0.025f;
		float leftStopwatch = leftBox + marginStopwatch;
		float topStopwatch = topBox + marginStopwatch;
		float heightStopwatch = 0.075f;
		float widthStopwatch = 0.075f;
		GUI.Box (RectHelper.ScreenRelativeToAbsolute(leftStopwatch, topStopwatch, widthStopwatch, heightStopwatch), 
					StopwatchIcon, GUIStyle.none);
		
		// get countdown data
		Countdown countdown = CountDownObject.GetComponent<Countdown>();
		float theTime = countdown.Timer;
		string theTimeString = string.Format("{0:0}", theTime);
		// show countdown time
		float leftCountdown = leftBox + marginStopwatch + widthStopwatch;
		float topCountdown = topBox + marginStopwatch;
		float heightCountdown = 0.075f;
		float widthCountdown = 0.075f;
		float fontHeightCountdown = 0.075f;
		GUI.skin.label.alignment = TextAnchor.MiddleLeft;
		GUI.skin.label.fontSize = (int)(Screen.height * fontHeightCountdown);
		GUI.contentColor = Color.black;
		GUI.Label(RectHelper.ScreenRelativeToAbsolute(leftCountdown, topCountdown, widthCountdown, heightCountdown), 
					theTimeString);
		//GUI.Box(RectHelper.ScreenRelativeToAbsolute(leftCountdown, topCountdown, widthCountdown, heightCountdown), "WWWWWWWWWWWWWWWWW"); 	// for positioning		
	
		// Show Reset hint, if we are in failed level state
		if (LevelManager.GetInstance().CurrentState == LevelManager.LevelState.Fail)
		{
			float margin = 0.25f;
			float leftFail = margin;
			float topFail = margin;
			float widthFail = 0.5f;
			float heightFail = 0.5f;
			float fontHeightFail = 0.1f;
			string failText = string.Format("Tech support failed!!\nPress Fire1 to restart!");
			GUI.skin.label.alignment = TextAnchor.MiddleCenter;
			GUI.skin.label.fontSize = (int)(Screen.height * fontHeightFail);
			GUI.contentColor = Color.red;
			GUI.Label (RectHelper.ScreenRelativeToAbsolute(leftFail, topFail, widthFail, heightFail), failText);
		}
	
	}
}
