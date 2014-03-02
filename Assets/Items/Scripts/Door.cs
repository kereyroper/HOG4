using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	public Direction direction;
	public GameObject RoomToDisable;
	public AudioSource DoorOpen;
	public GameObject RoomToEnable;
	public bool isLocked;
	public ItemType keyNumber;

	private GameObject player;

	void Start() {
		player = GameObject.Find("Player");
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Player" && !isLocked || player.GetComponent<Inventory>().HasKey(keyNumber)) {
			DoorOpen.Play ();
			LevelCamera.MoveCamera(direction);
			RoomToDisable.SetActive(false);
			RoomToEnable.SetActive(true);
		}
	}
}
