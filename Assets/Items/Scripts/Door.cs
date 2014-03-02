using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	public Direction direction;

	void OnTriggerEnter(Collider other) { //TODO: maybe Collider2D?
		// TODO: Check if player
		LevelCamera.MoveCamera(direction);
	}
}
