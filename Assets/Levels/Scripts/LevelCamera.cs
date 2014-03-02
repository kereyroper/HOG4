using UnityEngine;
using System.Collections;

public class LevelCamera : MonoBehaviour {

	public static void MoveCamera(Direction direction) {
		var cam = Camera.main;
		switch (direction) {
			case Direction.Up:
				cam.transform.position += new Vector3(0, 10.8f, 0);
				break;
			case Direction.Down:
				cam.transform.position += new Vector3(0, -10.8f, 0);
				break;
			case Direction.Left:
				cam.transform.position += new Vector3(-19.2f, 0, 0);
				break;
			default:
				cam.transform.position += new Vector3(19.2f, 0, 0);
				break;
		}
	}
}

public enum Direction
{
	Up,
	Down,
	Left,
	Right
};