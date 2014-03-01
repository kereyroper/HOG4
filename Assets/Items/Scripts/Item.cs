using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
	public ItemType itemType;
}

public enum ItemType
{
	Bread,
	Key,
};