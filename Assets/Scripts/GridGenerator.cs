using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int rows = 5; // number of rows in the grid
    public int cols = 5; // number of columns in the grid
    public float cellSize = 1.0f; // size of each cell

    public GameObject cellPrefab; // prefab to use for each cell

    void Start()
    {
        GenerateGrid();
    }

     void GenerateGrid()
    {
        // loop through each row and column to create a cell
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // create a new cell game object and position it based on its row and column
                GameObject cell = Instantiate(cellPrefab);
                cell.transform.parent = transform; // make the grid parent the cell object
                cell.transform.localPosition = new Vector3(col * cellSize, -row * cellSize, 0);

                // give the cell a unique name based on its row and column
                cell.name = "Cell " + row + ", " + col;

                // set the sprite for the cell based on its row and column
                SpriteRenderer renderer = cell.GetComponent<SpriteRenderer>();
                //renderer.sprite = GetSpriteForRowAndColumn(row, col);

                 if (row == 3 && col == 3)
                {
                    renderer.enabled = false;
                }
            }
        }
    }

    /*Sprite GetSpriteForRowAndColumn(int row, int col)
    {
        // determine which sprite to use based on the row and column
        // you can implement your own logic here based on your specific needs
            return null;
    }*/
}

