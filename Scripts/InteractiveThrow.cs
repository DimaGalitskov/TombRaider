using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveThrow : MonoBehaviour
{
    public GameObject treasure;
    public int treasureCount;
    public bool isTreasure;
    Vector3 startPosition;
    Vector3 endPosition;
    Vector3 heading;
    // Start is called before the first frame update
    void Start(){
    }

    void Update(){
    }

    void OnMouseDown() {
        startPosition = transform.position;
    }

    void OnMouseUp() {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if(Physics.Raycast(castPoint, out hit, Mathf.Infinity)){
            endPosition = hit.point;
        }
        heading = endPosition - startPosition;
        heading.Normalize();
        ThrowObject();
    }

    void ThrowObject(){
        gameObject.GetComponent<Rigidbody>().AddForce(heading * 7f, ForceMode.Impulse);
        gameObject.GetComponent<Rigidbody>().AddTorque(heading, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Wall" && isTreasure == true){
            Destroy(gameObject);
            for (int i = 0; i < treasureCount; i++){
                Vector3 randomPosition = new Vector3(
                    transform.position.x + Random.Range(-.3f, .3f), 
                    transform.position.y, 
                    transform.position.z + Random.Range(-.3f, .3f)
                );
                Instantiate(treasure, randomPosition, treasure.transform.rotation);
            }
        }
    }
}
