using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject idleTreasure;
    public GameObject pillar;
    public GameObject boxTreasure;
    public bool isBisy;
    GameObject canvas;
    CounterScript counterScript;
    int playerScore;

    void Start(){
        isBisy = false;
        StartCoroutine(IdleSpawn());
//        StartCoroutine(PillarSpawn());
        counterScript = FindObjectOfType<CounterScript>();
    }

    void Update(){
    }

    IEnumerator IdleSpawn(){
        while(true){
            float waitTime = Random.Range(0.5f, 1f);
            float xPosition = Random.Range(-3f, 3f);
            yield return new WaitForSeconds(waitTime);
            Vector3 spawnPosition = new Vector3(xPosition, 0, 15); 
            Instantiate(idleTreasure, spawnPosition, idleTreasure.transform.rotation);
        }
    }

    IEnumerator PillarSpawn(){
        while(true){
            float spawnOffset = 1.5f;
            float waitTime = Random.Range(1, 3);
            Vector3 spawnPositionLeft = new Vector3(-spawnOffset, 0, 10); 
            Vector3 spawnPositionRight = new Vector3(spawnOffset, 0, 10); 

            yield return new WaitForSeconds(waitTime);
            Instantiate(pillar, spawnPositionLeft, idleTreasure.transform.rotation);
            Instantiate(pillar, spawnPositionRight, idleTreasure.transform.rotation);
        }
    }

    public void PlayerBisy(){
        isBisy = true;
        StartCoroutine(BisyTimer());
    }

    public void PlayerNotBisy(){
        isBisy = false;
    } 

    public IEnumerator BisyTimer(){
        yield return new WaitForSeconds(.2f);
        PlayerNotBisy();
    }

    public void UpdateScore(int score){
        playerScore += score;
        counterScript.SetScore(playerScore);
    }
}
