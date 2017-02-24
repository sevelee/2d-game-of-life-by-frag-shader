using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNewLife : MonoBehaviour {

    public Texture newLife;
    public RenderTexture renderTexture;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
        {
            RenderTexture.active = renderTexture;
            int positionx, positiony;
            positionx = (int)(Random.value * Screen.width);
            positiony = (int)(Random.value * Screen.height);
            Graphics.DrawTexture(new Rect(positionx, positiony, newLife.width, newLife.height), newLife);
            RenderTexture.active = null;
        }
	}
}
