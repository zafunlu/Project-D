using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridspawnScript : MonoBehaviour
{
    public List<List<Object>> gridTiles;
    public GameObject TileObject;
    public int size;
    public float tileSize;
    //public GameObject obj2;
    public Transform centerPos;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(obj2, centerPos.position, centerPos.rotation);
        centerPos.position -= Vector3.right * (size / 2) * tileSize;
        centerPos.position -= Vector3.forward * (size / 2) * tileSize;
        gridTiles = new List<List<Object>>();
        int count = 0;
        for (int xx = 0;xx< size; xx++)
        {
            var xlist = new List<Object>();
            for(int zz = 0;zz< size; zz++)
            {
                //gridTiles[xx][zz] = 
                centerPos.position += Vector3.right * tileSize;
                var tile = Instantiate(TileObject, centerPos.position,centerPos.rotation);
                tile.name = TileObject.name + count;
                tile.tag = "Spawned";
                xlist.Add(tile);
                
                count++;
            }
            gridTiles.Add(xlist);
            centerPos.position -= Vector3.right * size * tileSize;
            centerPos.position += Vector3.forward * tileSize;
        }
        
        /* Start trying to load objects into the scene */
        App.Instance.LoadObjectsToARScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
