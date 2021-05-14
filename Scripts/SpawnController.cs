using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] FloorTiles;
    public GameObject[] SpecialTreasure;
    public GameObject[] InteraciveObjects;
    public float tileSize;
    float treasureCooldown;
    float objectCooldown;
    GameObject floorInstance;
    int tileInstance;
    int treasureId;

    // Start is called before the first frame update
    void Start(){
        SpawnTile();
        StartCoroutine(SpawnTreasure());
    }

    // Update is called once per frame
    void Update(){

    }

    public void SpawnTile(){
        tileInstance = Random.Range(0, FloorTiles.Length);
        floorInstance = Instantiate(FloorTiles[tileInstance], new Vector3(0, 0, 15), transform.rotation);
    }

    IEnumerator SpawnTreasure(){
        while(true){
            treasureCooldown = Random.Range(2,5);
            treasureId = Random.Range(0, SpecialTreasure.Length);
            yield return new WaitForSeconds(treasureCooldown);
            float xPosition = Random.Range(-3, 3);
            while(xPosition >= -.5f && xPosition <= .5f){
                xPosition = Random.Range(-3, 3);
            }
            Vector3 spawnPosition = new Vector3(xPosition, 0.1f, 10); 
            Instantiate(SpecialTreasure[treasureId], spawnPosition, transform.rotation);
        }
}

//            int treasureWeight = Random.Range(1, 100);
//
//            yield return new WaitForSeconds(waitTime);
//            if (treasureWeight > 0 && treasureWeight <= 10) {
//                float xPosition = Random.Range(-2f, 2f);
//                Vector3 spawnPosition = new Vector3(xPosition, 0, 6); 
//                Instantiate(boxTreasure, spawnPosition, idleTreasure.transform.rotation);
//            }
//            if (treasureWeight > 10 && treasureWeight <= 100) {
//                float xPosition = Random.Range(-1.5f, 1.5f);
//                Vector3 spawnPosition = new Vector3(xPosition, 0, 6); 
//                Instantiate(idleTreasure, spawnPosition, idleTreasure.transform.rotation);
//            }

}
