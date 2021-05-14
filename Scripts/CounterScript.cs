using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterScript : MonoBehaviour
{
    TextMeshProUGUI counter;

    // Start is called before the first frame update
    void Start(){
        counter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update(){
    }

    public void SetScore(int count){
        counter.SetText(count.ToString());
    }
}
