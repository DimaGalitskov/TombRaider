using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpSwipe : MonoBehaviour
{
    Vector3 startPosition;
    Vector3 endPosition;
    Vector3 direction;
    
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnMouseEnter() {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if(Physics.Raycast(castPoint, out hit, Mathf.Infinity)){
            startPosition = hit.point;
        };
        Invoke("BumpObject",0.2f);
        Debug.Log("touch");
    }

    void BumpObject(){
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if(Physics.Raycast(castPoint, out hit, Mathf.Infinity)){
            endPosition = hit.point;
        };
        Debug.Log("bump");
        direction = endPosition - startPosition + Vector3.up;
        direction.Normalize();
        gameObject.GetComponent<Rigidbody>().AddForce(direction * 10, ForceMode.Impulse);
        gameObject.GetComponent<Rigidbody>().AddTorque(direction, ForceMode.Impulse);
    }
}
