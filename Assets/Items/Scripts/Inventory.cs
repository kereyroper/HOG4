using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	public List<Item> items = new List<Item>();

	public void AddItem(Item item) {
		items.Add(item);
	}
}
