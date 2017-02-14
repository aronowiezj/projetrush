using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case {

    [Range(0,5)][SerializeField] int y;

    Terrain typeTerrain;
    bool voidCase=false;
    bool init = false;

	// Use this for initialization
	void Start () {
		
	}
    public bool isInit()
    {
        return init;
    }
	
    public void setVoidCase(bool voidCase)
    {
        this.voidCase = voidCase;
    }
	// Update is called once per frame
	void Update () {
		
	}
    public void setY(int y)
    {
        this.y = y;
    }
    public int getY()
    {
        return y;
    }

    public bool isVoid()
    {
        return voidCase;
    }
}
