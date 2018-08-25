using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class Store : MonoBehaviour {

	static public Item[] storeItems = new Item[11];
	static public int itemIndex;

	//Unity
	Button btn;
	static public Sprite mSprites;
	public string[] mStrings;
	public Image imagen;
	public Text text;
	public Text pocket;
	public Text price;

	private void Start()
	{
		btn = GetComponent<Button>();
	}

	private void Update()
	{
		pocket.text = Inventory.money.ToString();
		price.text = "Costo:  " + storeItems[itemIndex].price.ToString();

		if (Inventory.money < storeItems[itemIndex].price)
			btn.interactable = false;


	}

	public void Buy()
	{
		Inventory.money -= storeItems[itemIndex].price;
			

		if (storeItems[itemIndex] is NonConsumable)
		{
			if ((storeItems[itemIndex] as NonConsumable).wasBought == false)
			{
				(storeItems[itemIndex] as NonConsumable).wasBought = true;
				Inventory.items.Add(storeItems[itemIndex]);
				btn.interactable = false;
			}
		}
        if (storeItems[itemIndex]is Consumable)
        {
            if (Inventory.items.Contains(storeItems[itemIndex])==true)
            {
                for (int i =0 ; i < Inventory.items.Count; i++)
                {
                    if (Inventory.items[i].index == storeItems[itemIndex].index)
                    {
                        (Inventory.items[i] as Consumable).cant++;
                    }
                }
            }
            else
            {
                Inventory.items.Add(storeItems[itemIndex]);
            }

        }
	}

	public void Change()
	{
		if (mSprites != imagen.sprite)
			imagen.sprite = mSprites;

		if (text.text != mStrings[itemIndex])
			text.text = mStrings[itemIndex];


		if (Inventory.money < storeItems[itemIndex].price)
		{
			btn.interactable = false;
		}
		else
		{
			btn.interactable = true;

			if (storeItems[itemIndex] is NonConsumable)
			{
				if ((storeItems[itemIndex] as NonConsumable).wasBought == true)
					btn.interactable = false;
			}
		}
	}

}
