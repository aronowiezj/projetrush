using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Map :MonoBehaviour {

    static int taille=52;
    Case[,] map=new Case[taille,taille];
    Structure stru = new Structure();

    // Use this for initialization
    void Start()
    {
        System.Random rdm = new System.Random();

        for (int i = 0; i < taille; i++)
        {
            for (int j = 0; j < taille; j++)
            {
                if (map[i, j] == null)
                {
                    int structureChoisie = rdm.Next(1, 9);
                    while(stru.listStruct[structureChoisie].GetLength(0) + j > taille || stru.listStruct[structureChoisie].GetLength(0) + i > taille)
                        structureChoisie = rdm.Next(1, 9);
                    Debug.Log("Structure numero : "+structureChoisie);
                    int[,] structActuelle;
                    stru.listStruct.TryGetValue(structureChoisie, out structActuelle);
                    structActuelle = stru.listStruct[structureChoisie];
                    for (int k = 0; k < structActuelle.GetLength(0); k++)
                    {
                        for (int l = 0; l < structActuelle.GetLength(1); l++)
                        {
                            if (structActuelle[k, l] == 0)
                            {
                                map[i + k, j + l] = new Case();
                                map[i + k, j + l].setVoidCase(true);
                            }else
                            {
                                map[i + k, j + l] = new Case();
                            }

                        }
                    }

                }
            }
        }

        for (int i = 0; i < taille; i++)
        {
            for (int j = 0; j < taille; j++)
            {
                if (map[i, j].isVoid())
                    Debug.Log("0");
                else
                    Debug.Log("1");
            }
            Debug.Log("\n");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
