using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonInventario : MonoBehaviour
{

    public int index;

    public void Select()
    {
        GameObject.Find("Invent").GetComponent<Inventory>().itemIndex = index;
        GameObject.Find("Invent").GetComponent<Inventory>().Change();
        GameObject.Find("ImageInv").GetComponent<Image>().sprite = GameObject.Find("Invent").GetComponent<Inventory>().sprites[index];
    }
}
