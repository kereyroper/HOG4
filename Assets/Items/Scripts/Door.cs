using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	public Direction direction;
	public AudioSource DoorOpen;

	void OnTriggerEnter2D(Collider2D other) {

		DoorOpen.Play ();

		if (other.gameObject.tag == "Player") {
			LevelCamera.MoveCamera(direction);
		}
	}
}
