using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	static int score = 0;

	public GUISkin theSkin;
	// Update is called once per frame
	static public void Score (string wallname) {

		if (wallname == "leftWall")
		{
			score += -100;
		}
		else
		{
			score += 1;
		}
	
	}

	void OnGUI()
	{
		GUI.skin = theSkin;
		GUI.Label (new Rect (Screen.width / 2 - 200, 20, 300, 100), "Score: " + score); 
	}
}
