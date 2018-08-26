using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NonConsumable : Item {

	public bool wasBought = false;

	public NonConsumable(string name, int index, int price) : base(name, index, price)
    {

	}
}