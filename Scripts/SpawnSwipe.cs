using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSwipe : MonoBehaviour
{
    public GameObject spawnPrefab;
    GameObject spawnObject;
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
        Invoke("SpawnObject",0.2f);
    }

    void SpawnObject(){
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if(Physics.Raycast(castPoint, out hit, Mathf.Infinity)){
            endPosition = hit.point;
        };
        direction = endPosition - startPosition;
        direction.Normalize();
        spawnObject = Instantiate(spawnPrefab, transform.position + Vector3.up, transform.rotation);
        spawnObject.GetComponent<Rigidbody>().AddForce(direction * 20, ForceMode.Impulse);
    }
}
