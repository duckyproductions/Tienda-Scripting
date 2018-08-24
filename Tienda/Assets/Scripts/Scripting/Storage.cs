using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour{

	private void Main()
	{
        Store.storeItems[0] = new NonConsumable(10);
		Store.storeItems[1] = new NonConsumable(9);
		Store.storeItems[2] = new NonConsumable(3);
		Store.storeItems[3] = new NonConsumable(5);
		Store.storeItems[4] = new NonConsumable(17);
		Store.storeItems[5] = new NonConsumable(3);
		Store.storeItems[6] = new NonConsumable(25);
		Store.storeItems[7] = new NonConsumable(12);
		Store.storeItems[8] = new NonConsumable(17);
		Store.storeItems[9] = new Consumable(14);
		Store.storeItems[10] = new Consumable(5);
	}
	
}
