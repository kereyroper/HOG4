using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	public Direction direction;
	public GameObject RoomToDisable;
	public AudioSource DoorOpen;
	public GameObject RoomToEnable;

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Player") {
			DoorOpen.Play ();
			LevelCamera.MoveCamera(direction);
			RoomToDisable.SetActive(false);
			RoomToEnable.SetActive(true);
		}
	}
}
