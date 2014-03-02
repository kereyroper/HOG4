using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	public Queue<Item> projectiles = new Queue<Item>();
	public List<Item> otherItems = new List<Item>();

	public AudioSource PickUpSounds;

	public void AddItem(Item item)
	{
		if (item.IsProjectile()) {
			projectiles.Enqueue(item);
		} else {
			otherItems.Add(item);
		}
		PickUpSounds.Play();
	}

	public Item RemoveItem()
	{
		return projectiles.Dequeue();
	}
	//public bool RemoveItem(ItemType itemType)
	//{
	//	return items.Remove( items.FindLast(x => x.itemType == itemType) );
	//}
}
