using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NonConsumable : Item {

	public bool wasBought = false;

	public NonConsumable(int price) : base(price)
	{

	}
}