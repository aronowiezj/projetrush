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
        int offset = Random.Range(0,1000);
        


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

                    int[,] structOrientee = new int[structActuelle.GetLength(1), structActuelle.GetLength(0)];

                    for (int nombrerotations=0; nombrerotations<Random.Range(0,4); nombrerotations++)
                    {
                       
                        int m = 0, n = 0;
                        for (int k = structActuelle.GetLength(0) - 1; k >= 0; k--)
                        {
                            for (int l = 0; l < structActuelle.GetLength(1) - 1; l++)
                            {
                                structOrientee[n, m] = structActuelle[k, l];
                                n++;
                            }
                            n = 0;
                            m++;
                        }
                    }

                    for (int k = 0; k < structOrientee.GetLength(0); k++)
                    {
                        for (int l = 0; l < structOrientee.GetLength(1); l++)
                        {
                            if (structOrientee[k, l] == 0)
                            {
                                map[i + k, j + l] = new Case();
                                map[i + k, j + l].setVoidCase(true);
                            }
                            else
                            {
                                map[i + k, j + l] = new Case();
                            }
                        }
                    }


                }
                float detailScale = 20.0f;
                int heightScale = 25;
                int y = (int)(Mathf.PerlinNoise((i + offset) / detailScale, (j + offset) / detailScale) * heightScale);
                map[i, j].setY(y);
            }
        }

        for (int i = 0; i < taille; i++)
        {
            for (int j = 0; j < taille; j++)
            {
                
                Debug.Log("hauteur en "+i+","+j +" : "+ map[i, j].getY());

    }
           
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
