using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject currentCell;
    //public float moveSpeed = 5f;
    public GridSystem gridData;
   

    // Start is called before the first frame update
    void Start()
    {
        //currentCell = gridData.cells[gridData.gridSizeX / 2, gridData.gridSizeY / 2];
        transform.position = currentCell.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player in the direction of the input
    
        if (Input.GetKeyDown(KeyCode.W))
        {
            MovePlayer(new Vector2Int(1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            MovePlayer(new Vector2Int(-1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            MovePlayer(new Vector2Int(0, -1));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MovePlayer(new Vector2Int(0, 1));
        }
    }

    void MovePlayer(Vector2Int direction)
    {
        Vector2Int newGridCoord = gridData.GetGridCoordinates(currentCell) + direction;

        if(newGridCoord.x >= 0 && newGridCoord.x < gridData.gridSizeX && newGridCoord.y >= 0 && newGridCoord.y < gridData.gridSizeY)
        {
            GameObject newCell = gridData.cells[newGridCoord.x, newGridCoord.y];

            // Move the player to the new cell
            currentCell = newCell;
            transform.position = currentCell.transform.position;
        }
    }
}
