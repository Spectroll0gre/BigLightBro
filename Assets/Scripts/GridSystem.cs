using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public int gridSizeX;
    public int gridSizeY;
    public float gridSpacing;
    public GameObject[,] cells;

    void Start()
    {
        cells = new GameObject[gridSizeX, gridSizeY];

        // Populate the cells array with references to the grid cells
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Vector3 position = new Vector3(x * gridSpacing, y * gridSpacing, 0);
                cells[x, y] = transform.GetChild(x * gridSizeY + y).gameObject;
            }
        }
    }

    public Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x * gridSpacing, y * gridSpacing, 0);
    }

    public Vector2Int GetGridCoordinates(GameObject cell)
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                if (cells[x, y] == cell)
                {
                    return new Vector2Int(x, y);
                }
            }
        }
        return new Vector2Int(-1, -1);
    }
}


