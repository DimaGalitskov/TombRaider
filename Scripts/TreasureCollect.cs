using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreasureCollect : MonoBehaviour
{
    public ParticleSystem collectParticle;
    public GameObject gatherTooltip;
    bool isBisy;
    GameObject tooltipObject;
    GameControllerScript gameControllerScript;
    int score;

    // Start is called before the first frame update
    void Start(){
        gameControllerScript = FindObjectOfType<GameControllerScript>();
        isBisy = gameControllerScript.isBisy;
        score = Random.Range(1,5);
    }

    // Update is called once per frame
    void Update(){
    }
            
    private void OnMouseEnter(){
        isBisy = gameControllerScript.isBisy;
        if(isBisy == false){
            Instantiate(collectParticle, transform.position, transform.rotation);
            //Vector3 tooltipPosition = Camera.main.WorldToScreenPoint(transform.position);
            tooltipObject = Instantiate(gatherTooltip, transform.position + Vector3.up*.5f, transform.rotation);
            tooltipObject.GetComponent<ShowTooltip>().score = score;
            gameControllerScript.UpdateScore(score);
            gameControllerScript.PlayerBisy();
            Destroy(gameObject);
        }
    }
}
