using UnityEngine;
using System.Collections;

public class CameraTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("w")) {
			LevelCamera.MoveCamera(Direction.Up);
		} else if (Input.GetKeyDown("a")) {
			LevelCamera.MoveCamera(Direction.Left);
		} else if (Input.GetKeyDown("s")) {
			LevelCamera.MoveCamera(Direction.Down);
		} else if (Input.GetKeyDown("d")) {
			LevelCamera.MoveCamera(Direction.Right);
		}
	}

}
