using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public GameObject burntToast;
	public GameObject goodToast;

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(20,40,140,150), "Toaster Settings");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(50,70,80,20), "Start Game")) {
			goodToast.SetActive(true);
			Invoke("StartGame", 3f);
		}
		
		// Make the credits button.
		if(GUI.Button(new Rect(50,100,80,20), "Credits")) {
			Application.LoadLevel("Credits");
		}
	
		// Make the quit button.
		if(GUI.Button(new Rect(50,130,80,20), "Quit")) {
			Application.Quit();
		}

		// Extra Dark
		if(GUI.Button(new Rect(50,160,80,20), "Extra Dark")) {
			burntToast.SetActive(true);
		}
	}

	void StartGame() {
		Application.LoadLevel("toaster game");
	}
}
