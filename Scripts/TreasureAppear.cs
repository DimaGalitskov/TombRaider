using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureAppear : MonoBehaviour
{
    Renderer objectRender;
    public ParticleSystem hintParticle;

    // Start is called before the first frame update
    void Start() {
        objectRender = GetComponent<Renderer>();
        StartCoroutine(TreasureHint());
    //    StartCoroutine(TreasureVisible());
    }

    // Update is called once per frame
    void Update(){
        
    }
    
    IEnumerator TreasureVisible(){
        float waitTime = Random.Range(1, 5);
        yield return new WaitForSeconds(waitTime);
        objectRender.enabled = true;
        yield return new WaitForSeconds(1);
        objectRender.enabled = false;
    }

    IEnumerator TreasureHint(){
        float waitTime = Random.Range(1, 5);
        yield return new WaitForSeconds(waitTime);
        Instantiate(hintParticle, transform.position, transform.rotation);
    }
}
