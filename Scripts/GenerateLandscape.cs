using UnityEngine;
using System.Collections;

public class Block
{
    public int type;
    public bool visible;

    public Block(int t, bool v)
    {
        type = t;
        visible = v;
    }
}

public class GenerateLandscape : MonoBehaviour
{

    public static int width = 128;
    public static int depth = 128;
    public static int height = 128;
    public int heightScale = 20;
    public float detailScale = 25.0f;

    public GameObject grassBlock;
    public GameObject sandBlock;
    public GameObject snowBlock;

    private Transform parent;

    Block[,,] worldBlocks = new Block[width, height, depth];

    // Use this for initialization
    void Start()
    {
        parent = GetComponent<Transform>();

        int offset = (int)Network.time * 10;

        for (int z = 0; z < depth; z++)
        {
            for (int x = 0; x < width; x++)
            {
                int y = (int)(Mathf.PerlinNoise((x + offset) / detailScale, (z + offset) / detailScale) * heightScale);
                Debug.Log(y);
                Vector3 blockPos = new Vector3(x, y, z);

                CreateBlock(y, blockPos, true);
                while (y > 0)
                {
                    y--;
                    blockPos = new Vector3(x, y, z);
                    CreateBlock(y, blockPos, false);
                }

            }
        }

        parent.Rotate(0, 45, 0);
    }

    void CreateBlock(int y, Vector3 blockPos, bool create)
    {
        if (blockPos.x < 0 || blockPos.x >= width || blockPos.y < 0 || blockPos.y >= height || blockPos.z < 0 || blockPos.x >= depth) return;

        if (y > 15)
        {
            if (create)
                Instantiate(snowBlock, blockPos, Quaternion.identity, parent);

            worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z] = new Block(1, create);
        }
        else if (y > 5)
        {
            if (create)
                Instantiate(grassBlock, blockPos, Quaternion.identity, parent);

            worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z] = new Block(2, create);
        }
        else
        {
            if (create)
                Instantiate(sandBlock, blockPos, Quaternion.identity, parent);

            worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z] = new Block(3, create);
        }

    }


    void DrawBlock(Vector3 blockPos)
    {
        if (blockPos.x < 0 || blockPos.x >= width || blockPos.y < 0 || blockPos.y >= height || blockPos.z < 0 || blockPos.x >= depth) return;

        if (worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z] == null) return;

        if (!worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z].visible)
        {

            worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z].visible = true;
            if (worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z].type == 1)
                Instantiate(snowBlock, blockPos, Quaternion.identity, parent);

            else if (worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z].type == 2)
                Instantiate(grassBlock, blockPos, Quaternion.identity, parent);

            else if (worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z].type == 3)
                Instantiate(sandBlock, blockPos, Quaternion.identity, parent);

            else
                worldBlocks[(int)blockPos.x, (int)blockPos.y, (int)blockPos.z].visible = false;
        }

    }

    void Update()
    {

    }
}