using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
	public ItemType itemType;

	private Item item;

	void Start() {
		item = new Item(itemType);
	}

	void OnTriggerEnter2D(Collider2D other) {



		if (other.gameObject.tag == "Player") {

			System.Console.WriteLine("Object was picked up!");

			other.GetComponent<Inventory>().AddItem(item);
			Destroy(gameObject);
		}
	}
}
