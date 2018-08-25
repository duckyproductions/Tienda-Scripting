using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

    public Text texto;
    public float fade =0;
    // Update is called once per frame
    void Update () {
        if (fade > -1)
        {
            fade -= 0.01f;
            texto.color = new Vector4(1, 1, 0, fade);
        }
	}
}
