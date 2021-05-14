using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tourchAbility;
    GameObject tourch;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
    }

    public void UseAbility(){
        var heading = FindClosestBox().transform.position - transform.position;
        heading.Normalize();
        Quaternion boxDirection = Quaternion.Euler(heading);
        tourch = Instantiate(tourchAbility, transform.position, boxDirection);
        tourch.GetComponent<Rigidbody>().AddForce(heading * 7f, ForceMode.Impulse);
    }

    GameObject FindClosestBox(){
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Box");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos){
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance){
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
