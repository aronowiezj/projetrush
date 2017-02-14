using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    int[,] tab;
    [SerializeField]
    //int cubeSize = 10;

    // Use this for initialization
    void Start () {
        tab = new int[10, 10];
        for (int i = 0; i < tab.GetLength(0); ++i)
            for (int j = 0; j < tab.GetLength(1); ++j)
                tab[i,j] = 5;

        Generate(tab);
    }

    bool Generate(int[,] tab)
    {
        for (int i = 0; i < tab.GetLength(0); ++i)
            for (int j = 0; j < tab.GetLength(1); ++j)
                Debug.Log(tab[i, j]);

        return true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}