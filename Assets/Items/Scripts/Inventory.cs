using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	public List<Item> items = new List<Item>();

	public void AddItem(Item item) {
		items.Add(item);
	}

	public bool RemoveItem(ItemType itemType)
	{
		return items.Remove( items.FindLast(x => x.itemType == itemType) );
	}
}
