using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour {

	static public int money = 1000;
	static public List<Item> items = new List<Item>();

	public int cantidad = 0;
	public Text cantText;    

    public int itemIndex;


    Vector3[] buttonsPos=new Vector3[12];
    public Sprite[] sprites;

    public Button itemPrefab;
    public Button bUsar, bDescartar;

    public Text cant;

    Item itemActual;

    List <GameObject> bots= new List<GameObject>();

    public void Change()
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].index == itemIndex)
            {
                itemActual = items[i];
            }
        }


        if (itemActual != null)
        {
            if (itemActual is NonConsumable)
                cant.text = "Cantidad: 1";
            if (itemActual is Consumable)
            {
                cant.text = "Cantidad: " + (itemActual as Consumable).cant;
            }
        }

        if (itemActual is Consumable)
        {
            if ((itemActual as Consumable).cant>0)
            {
            bUsar.interactable = true;
            bDescartar.interactable = true;

            }
        }
        else
        {
            bUsar.interactable = false;
            bDescartar.interactable = false;
        }


    }


    public void createItems()
    {
        for (int i = 0; i < bots.Count; i++)
        {
            Destroy(bots[i]);
        }
        bots.Clear();

        bUsar.interactable = false;
        bDescartar.interactable = false;

        int c = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                buttonsPos[c] = new Vector3((j*90)+120, 250-(i*90), 0);
                c++;
            }
        }
        for (int i = 0; i < items.Count; i++)
        {
            bots.Add(Instantiate(itemPrefab, buttonsPos[i],Quaternion.identity,transform).gameObject);
            bots[i].GetComponent<Image>().sprite = sprites[items[i].index];
            bots[i].GetComponent<BotonInventario>().index = items[i].index;
        }
    }

    public void Usar()
    {
        (itemActual as Consumable).cant--;
        if ((itemActual as Consumable).cant == 0)
        {
            items.Remove(itemActual);
            createItems();
        }
        Change();

        if (itemActual.name=="Ala delta")
        {
            GameObject.Find("mensaje").GetComponent<Text>().text = "Usas Ala delta";
            GameObject.Find("mensaje").GetComponent<Fade>().fade=1;
        }
        if (itemActual.name == "JetPack")
        {
            GameObject.Find("mensaje").GetComponent<Text>().text = "Usas JetPack";
            GameObject.Find("mensaje").GetComponent<Fade>().fade = 1;
        }
    }

    public void Descartar()
    {
		for (int i = 0; i < cantidad; i++)
		{
			if (items.Contains(itemActual))
			{
				(itemActual as Consumable).cant--;
				if ((itemActual as Consumable).cant == 0)
				{
					items.Remove(itemActual);
					createItems();
				}
			}
			else
				break;
		}
        Change();
        
    }


	public void Mas()
	{
		cantidad++;
	}

	public void Menos()
	{
		if(cantidad > 0)
			cantidad--;
	}

	private void Update()
	{
		cantText.text = cantidad.ToString();
	}
}
