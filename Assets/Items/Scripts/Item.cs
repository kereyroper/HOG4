using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Item
{
	public ItemType itemType;

	private Dictionary<ItemType, bool> projectileTypes = new Dictionary<ItemType, bool> {
		                                                                                    {ItemType.Bread, true},
																							{ItemType.Bagel, true},
																							{ItemType.Waffle, true},
																							{ItemType.Key, false},
	                                                                                    };

	public Item(ItemType itemType) {
		this.itemType = itemType;
	}

	public bool IsProjectile() {
		return projectileTypes[itemType];
	}
}

public enum ItemType
{
	// Important! Make sure you add new items to projectileTypes as well
	Bread,
	Bagel,
	Waffle,
	Key,
};