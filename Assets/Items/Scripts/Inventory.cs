using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	public List<Item> items = new List<Item>();
	public AudioSource PickUpSounds;


	public void AddItem(Item item) {
		PickUpSounds.Play();
		items.Add(item);
	}

	public bool RemoveItem(ItemType itemType)
	{
		return items.Remove( items.FindLast(x => x.itemType == itemType) );
	}
}
