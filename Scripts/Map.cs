using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    static int taille = 52;
    Case[,] map = new Case[taille, taille];
    Structure stru = new Structure();

    // Use this for initialization
    void Start()
    {
        Random.InitState(2555);
        int offset = 1000000000;
        


        for (int i = 0; i < taille; i++)
        {
            for (int j = 0; j < taille; j++)
            {
                if (map[i, j] == null)
                {
                    int structureChoisie = (int)(Random.Range(1, 9));
                    while (stru.listStruct[structureChoisie].GetLength(0) + j > taille || stru.listStruct[structureChoisie].GetLength(0) + i > taille)
                        structureChoisie = (int)(Random.Range(1, 9));
                    // Debug.Log("Structure numero : "+structureChoisie);
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
                            }
                            else
                            {
                                map[i + k, j + l] = new Case();
                            }

                            // Debug.Log("seed " + seed);

                        }
                    }
                    
                    int detailScale = 20;
                    int heightScale = 25;
                    int y = (int)(Mathf.PerlinNoise((i + offset) / detailScale, (j + offset) / detailScale) * heightScale);
                    // Debug.Log("hauteur " + Mathf.PerlinNoise((i + offset) / detailScale, (j + offset) / detailScale));
                    Debug.Log("hauteur " + Mathf.PerlinNoise(9000000000000000000, 10000)*100);
                    Debug.Log("hauteur " + Mathf.PerlinNoise(10000000000000, 1));

                    map[i, j].setY(y);
                }
            }
        }

        for (int i = 0; i < taille; i++)
        {
            for (int j = 0; j < taille; j++)
            {
                if (map[i, j].isVoid()) { }

            }
            // Debug.Log("\n");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
