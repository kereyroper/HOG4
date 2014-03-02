using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	public Queue<Item> items = new Queue<Item>();
	//public List<Item> items = new List<Item>();
	public AudioSource PickUpSounds;

	public void AddItem(Item item)
	{
		items.Enqueue(item);
		PickUpSounds.Play();
	}

	public Item RemoveItem()
	{
		return items.Dequeue();
	}
	//public bool RemoveItem(ItemType itemType)
	//{
	//	return items.Remove( items.FindLast(x => x.itemType == itemType) );
	//}
}
