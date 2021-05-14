using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public float tileSize;
    SpawnController spawnController;
    bool isFirst;
    
    // Start is called before the first frame update
    void Start(){
        isFirst = true;
        spawnController = FindObjectOfType<SpawnController>();
        spawnController.tileSize = tileSize;
        StartCoroutine(SpawnTile());
    }

    // Update is called once per frame
    void Update(){
    }

    IEnumerator SpawnTile(){
        yield return new WaitForSeconds(tileSize / 2);
        spawnController.SpawnTile();
    }
}
