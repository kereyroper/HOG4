using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Linq;


public class Inventory : MonoBehaviour
{
	public Queue<Item> projectiles = new Queue<Item>();
	public List<Item> otherItems = new List<Item>();

	public AudioSource PickUpSounds;
	public AudioClip keyPickUp;

	public void AddItem(Item item)
	{
		PickUpSounds.Play ();

		if (item.IsProjectile()) {
			projectiles.Enqueue(item);
		} else {
			otherItems.Add(item);
		}

		if (otherItems.Exists(x => x.itemType == ItemType.RobotParts1) && otherItems.Exists(x => x.itemType == ItemType.RobotParts2))
			Application.LoadLevel("win");

	}

	public Item RemoveItem()
	{
		return projectiles.Dequeue();
	}

	public bool HasKey(ItemType keyRequired) {
		return otherItems.Any(item => item.itemType == keyRequired);
	}
	//public bool RemoveItem(ItemType itemType)
	//{
	//	return items.Remove( items.FindLast(x => x.itemType == itemType) );
	//}
}
