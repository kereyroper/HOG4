using UnityEngine;
using System.Collections;

public class Item
{
	public ItemType itemType;

	public Item(ItemType itemType) {
		this.itemType = itemType;
	}
}

public enum ItemType
{
	Bread,
	Bagel,
	Waffle,
	Key,
};