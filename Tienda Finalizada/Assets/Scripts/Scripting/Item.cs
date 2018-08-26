 using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Item {

	public int price;
    public int index;
    public string name;

    protected Item(string Name, int Index, int Price)
	{
        name = Name;
        index = Index;
		price = Price;
	}


}
