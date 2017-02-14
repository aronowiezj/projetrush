using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case
{
    int y;

    Terrain typeTerrain;
    bool voidCase = false;
    bool init = false;

    public bool isInit()
    {
        return init;
    }

    public void setVoidCase(bool voidCase)
    {
        this.voidCase = voidCase;
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