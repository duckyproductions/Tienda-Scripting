using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item {


	public int cant=1;

	public Consumable(string name, int index, int price) : base(name,index,price)
	{
	}

}
