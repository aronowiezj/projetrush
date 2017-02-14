using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    Structure stru = new Structure();
    Case[,] map;

    public Map(int seed, int width, int depth, int heightScale, float detailScale)
    {
        Random.InitState(seed);
        int offset = Random.Range(0, 1000);

        map = new Case[width, depth];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < depth; j++)
            {
                if (map[i, j] == null)
                {
                    int structureChoisie = (int)(Random.Range(1, 9));
                    while (stru.listStruct[structureChoisie].GetLength(0) + j > depth || stru.listStruct[structureChoisie].GetLength(0) + i > width)
                        structureChoisie = (int)(Random.Range(1, 9));

                    int[,] structActuelle;
                    stru.listStruct.TryGetValue(structureChoisie, out structActuelle);
                    structActuelle = stru.listStruct[structureChoisie];

                    int[,] structOrientee = new int[structActuelle.GetLength(1), structActuelle.GetLength(0)];

                    for (int nombrerotations = 0; nombrerotations < Random.Range(0, 4); nombrerotations++)
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
                int y = (int)(Mathf.PerlinNoise((i + offset) / detailScale, (j + offset) / detailScale) * heightScale);
                map[i, j].setY(y);
            }
        }
    }

    public Case[,] getGrid()
    {
        return map;
    }
}