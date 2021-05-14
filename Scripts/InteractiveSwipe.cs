using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveSwipe : MonoBehaviour
{
    public GameObject treasure;
    public int treasureCount;
    public ParticleSystem destroyParticle;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    private void OnMouseEnter() {
        Instantiate(destroyParticle, transform.position, transform.rotation);
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
