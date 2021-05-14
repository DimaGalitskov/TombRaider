using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreaureMove : MonoBehaviour
{
    void Start(){
    }

    void Update(){
        transform.Translate(Vector3.back * Time.deltaTime * 2, Space.World);
    }
}
