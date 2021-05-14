using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTorch: MonoBehaviour
{
    void Start(){
        StartCoroutine(DestroyObject());
    }
    
    void Update(){
    }

    IEnumerator DestroyObject(){
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
