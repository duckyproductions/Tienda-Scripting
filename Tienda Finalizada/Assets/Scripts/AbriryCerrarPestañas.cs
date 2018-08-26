using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbriryCerrarPestañas : MonoBehaviour {

	public GameObject abrir;
	public GameObject cerrar;

	public void Cambiar()
	{
		cerrar.SetActive(false);
		abrir.SetActive(true);
	}
    public void CrearObjetos()
    {
        GameObject.Find("Invent").GetComponent<Inventory>().createItems();

    }
}
