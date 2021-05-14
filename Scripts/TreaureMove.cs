using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{

    void Start(){
    }

    void Update(){
        int speed = 2;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
