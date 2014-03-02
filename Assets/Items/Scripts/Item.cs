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
																							{ItemType.Key1, false},
																							{ItemType.Key2, false},
																							{ItemType.Key3, false},
																							{ItemType.Key4, false},
																							{ItemType.Key5, false},
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
	Key1,
	Key2,
	Key3,
	Key4,
	Key5,
};