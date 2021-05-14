using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragSwipe : MonoBehaviour
{
    Vector3 startPosition;
    Vector3 endPosition;
    Vector3 direction;
    bool isDragging;
    
    // Start is called before the first frame update
    void Start(){
        isDragging = false;       
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
        isDragging = true;
        StartCoroutine(DragObject());
    }

    IEnumerator DragObject(){
        while(isDragging){
            yield return new WaitForSeconds(.2f);
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            RaycastHit hit;
            if(Physics.Raycast(castPoint, out hit, Mathf.Infinity)){
                endPosition = hit.point;
            };
            Debug.Log("bump");
            direction = endPosition - startPosition;
            direction.Normalize();
            gameObject.GetComponent<Rigidbody>().AddForce(direction * 5, ForceMode.Impulse);
            gameObject.GetComponent<Rigidbody>().AddTorque(direction, ForceMode.Impulse);
        }
    }

    void OnMouseUp() {
        isDragging = false;
    }
}
