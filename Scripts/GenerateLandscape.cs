using UnityEngine;
using System.Collections;

public class GenerateLandscape : MonoBehaviour
{
    public int seed;
    
    public int width = 128;
    public int depth = 128;
    public int height = 128;
    public int heightScale = 20;
    public float detailScale = 25.0f;
    
    public GameObject block;

    private Transform parent;

    Case[,] worldBlocks;

    // Use this for initialization
    void Start()
    {
        Map map = new Map(seed, width, depth, heightScale, detailScale);
        worldBlocks = map.getGrid();
        parent = GetComponent<Transform>();

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < depth; z++)
            {
                Vector3 blockPos = new Vector3(x * block.transform.localScale.x, worldBlocks[x, z].getY() * block.transform.localScale.y, z * block.transform.localScale.z);

                CreateBlock(blockPos, worldBlocks[x, z].isVoid());

            }
        }

        parent.Rotate(0, 45, 0);
    }

    void CreateBlock(Vector3 blockPos, bool create)
    {
        if (create)
            Instantiate(block, blockPos, Quaternion.identity, parent);
    }
}