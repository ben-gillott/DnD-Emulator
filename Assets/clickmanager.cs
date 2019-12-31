using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
// using  UnityEngine.Tilemaps.TileBase;

public class clickmanager : MonoBehaviour
{
    // public NormalTile normalTile;
    // public Player selectedUnit;

    private void OnMouseDown()
    {
        // left click - get info from selected tile
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello WOrld start");   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            // Debug.Log("Hello WOrld");
            // get mouse click's position in 2d plane
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pz.z = 0;
            Debug.Log("Mouse coords: " + pz);

            // // convert mouse click's position to Grid position
            GridLayout gridLayout = transform.parent.GetComponentInParent<GridLayout>();
            Vector3 halfOff = new Vector3((float).5,(float).5,(float).5);
            Vector3 cellPosition = gridLayout.WorldToCell(pz) + halfOff;
        
            GameObject.Find("PlayerCharacter").transform.position = cellPosition;
            
            GameObject grid = GameObject.FindWithTag("Ground");

            // Debug.Log("Found grid: " + grid.Tilemap.GetTile(cellPosition));

            // Grid grid = GameObject.Find("Grid");
            
            // Debug.Log("Tile value: " + grid.GetTile(cellPosition));
            // // set selectedUnit to clicked location on grid
            Debug.Log("Cell coords: " + cellPosition);
        }
    }
}
