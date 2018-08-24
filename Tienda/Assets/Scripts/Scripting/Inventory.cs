using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour {

	static public int money = 1000;
	static public List<Item> items = new List<Item>();

	//private void Update()
	//{
	//	for (int i = 0; i < items.Count; i++)
	//	{

	//	}
	//}


	void Use(Consumable item)
	{
		if(items.Contains(item))
		{
			items.Remove(item);
		}
	}
}
