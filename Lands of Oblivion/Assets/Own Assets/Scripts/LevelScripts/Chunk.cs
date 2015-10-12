﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


class Chunk
{
    public List<GameObject> list { get { return new List<GameObject>(list); } private set { list = value; } }

    public Chunk(List<GameObject> list)
    {
        this.list = new List<GameObject>();

        foreach (GameObject tempObj in list)
        {
            this.add(tempObj);
        }
    }

    public Chunk(GameObject obj)
    {
        this.list = new List<GameObject>();
        this.add(obj);
    }

    public Chunk()
    {
        this.list = new List<GameObject>();
    }

    public Boolean add(GameObject obj)
    {
<<<<<<< HEAD:Lands of Oblivion/Assets/Own Assets/Scripts/LevelScripts/Chunk.cs
        if (!this.list.Contains(obj) && obj.GetComponent<MeshFilter>().mesh != null)
=======
        /*if (!this.list.Contains(obj) && obj.)
>>>>>>> origin/master:Lands of Oblivion/Assets/Own Assets/Scripts/LevelScripts/GridContainer.cs
        {
            this.list.Add(obj);
            return true;
        }*/
        
	    return false;
    }
}