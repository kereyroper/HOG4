using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {

	private float halfWidth = Screen.width / 2 - 40;
	private float halfHeight = Screen.height / 2;
	void OnGUI () {

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
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
