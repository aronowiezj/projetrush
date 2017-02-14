using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point  {

    int x;
    int y;

    // Use this for initialization
    void Start() {

    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int getX()
    {
        return x;
    }

    public int getY()
    {
        return y;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
