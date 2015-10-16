﻿using UnityEngine;
using System.Collections;
using System;

public class ChunkController : MonoBehaviour {
    LevelGrid grid;
    GameObject player;

	// Use this for initialization
	void Start () {
        try
        {
            this.grid = new LevelGrid(GameObject.Find("Terrain").GetComponent<Terrain>());
            this.player = GameObject.Find(Constants.NamePlayer);
        } catch (Exception e)
        {
            Debug.Log("Fatal error occured: " + e.Message + "/nGo to hell.");
        }
        Debug.Log("Trying to init grid");
        initGrid(GameObject.Find(Constants.NameStaticGameObjectsContainer));
	}
    
    private void initGrid(GameObject actObj)
    {
        //Nö
        //Mesh tempMesh = actObj.GetComponent<Mesh>();

        ////Ebenfalls nö
        //MeshFilter tempFilt = actObj.GetComponent<MeshFilter>();

        //Mesh tempMesh2 = actObj.GetComponentInChildren<Mesh>();

        MeshFilter tempFilt2 = actObj.GetComponentInChildren<MeshFilter>();


        if (actObj.GetComponent<MeshFilter>() != null)
        {
            int x = Math.floatToGridColumn(actObj.transform.position.x, grid.widthRect);
            int y = Math.floatToGridRow(actObj.transform.position.y, grid.heightRect);

            this.grid.add(x, y, actObj);
        }

        actObj.SetActive(false);

        foreach (Transform trans in actObj.transform)
        {
            initGrid(trans.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
	    //update Meshs
	}
}
