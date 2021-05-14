using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerTrail : MonoBehaviour
{
    public LayerMask hitLayers;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers)){
             transform.position = hit.point;
        }
    }
}
