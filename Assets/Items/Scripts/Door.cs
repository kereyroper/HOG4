using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	public Direction direction;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			LevelCamera.MoveCamera(direction);
		}
	}
}
