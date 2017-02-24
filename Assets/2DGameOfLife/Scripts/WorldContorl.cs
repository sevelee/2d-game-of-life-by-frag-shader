using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldContorl : MonoBehaviour {

    //material with the CA shader
    public Material material;
    public RenderTexture renderTexture;
    public Texture originalTexture;

    public float updateTimeStep = 1.0f;

    RenderTexture tempRenderTexture;
    float timeSinceLastUpdate = 0;

    void Init()
    {
        //copy the texture to render texture
        Graphics.Blit(originalTexture, renderTexture);
        tempRenderTexture = new RenderTexture(renderTexture.width, renderTexture.height, renderTexture.depth);
    }

	// Use this for initialization
	void Start () {
        Init();
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastUpdate += Time.deltaTime;
		if (timeSinceLastUpdate > updateTimeStep)
        {
            timeSinceLastUpdate -= updateTimeStep;
            updateCells();
        }
	}

    private void updateCells()
    {
        Graphics.Blit(renderTexture, tempRenderTexture, material);
        Graphics.Blit(tempRenderTexture, renderTexture);
    }
}
