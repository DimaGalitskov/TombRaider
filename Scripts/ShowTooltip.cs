using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTooltip : MonoBehaviour
{
    public int score;
    TMP_Text tooltipText;
    // Start is called before the first frame update
    void Start(){
        transform.rotation = Camera.main.transform.rotation;
        tooltipText = GetComponent<TMP_Text>();
        tooltipText.SetText("+" + score.ToString());
        StartCoroutine(DestroyAfter());
    }

    // Update is called once per frame
    void Update(){
        
    }

    IEnumerator DestroyAfter(){
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
