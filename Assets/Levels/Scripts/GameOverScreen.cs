using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {
	
	private float halfWidth = Screen.width / 2 - 40;
	private float halfHeight = Screen.height / 2;

	void OnGUI ()
	{
		if(GUI.Button(new Rect(halfWidth, halfHeight + 70,80,20), "Play Again"))
		{
			Application.LoadLevel("toaster game");
		}
		
		// Make the credits button.
		if(GUI.Button(new Rect(halfWidth,halfHeight + 100,80,20), "Credits"))
		{
			Application.LoadLevel("Credits");
		}
		
		// Make the quit button.
		if(GUI.Button(new Rect(halfWidth, halfHeight + 130,80,20), "Quit")) {
			Application.Quit();
		}
	}
}
