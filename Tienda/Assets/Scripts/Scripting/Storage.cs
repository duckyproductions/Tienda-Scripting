using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour{

	private void Main()
	{
        Store.storeItems[0] = new NonConsumable("Altura edificio",0,10);
		Store.storeItems[1] = new NonConsumable("Piernas mas fuertes",1,9);
		Store.storeItems[2] = new NonConsumable("Multiplicador de sangre",2,3);
		Store.storeItems[3] = new NonConsumable("Aumento de gravedad",3,5);
		Store.storeItems[4] = new NonConsumable("Palomas",4,17);
		Store.storeItems[5] = new NonConsumable("Chef",5,3);
		Store.storeItems[6] = new NonConsumable("Meteoros",6,25);
		Store.storeItems[7] = new NonConsumable("Portal",7,12);
		Store.storeItems[8] = new NonConsumable("Aumento swipe",8,17);
		Store.storeItems[9] = new Consumable("JetPack",9,14);
		Store.storeItems[10] = new Consumable("Ala delta",10,5);
	}
	
}
