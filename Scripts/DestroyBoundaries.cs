using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoundaries : MonoBehaviour
{
    void Start(){
        
    }

    void Update(){
        if(transform.position.z < -10){
            Destroy(gameObject);
        }
    }
}
