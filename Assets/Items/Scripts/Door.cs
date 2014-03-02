using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	public Direction direction;

	void OnTriggerEnter2D(Collider2D other) {
		// TODO: Check if player
		LevelCamera.MoveCamera(direction);
	}
}
