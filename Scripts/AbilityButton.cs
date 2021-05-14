using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButton : MonoBehaviour
{
    public Button buttonUI;

    void Start(){ 
        Button abilityButton = buttonUI.GetComponent<Button>();
        abilityButton.onClick.AddListener(TaskOnClick);
    }

    void Update(){ 
    }

    void TaskOnClick(){
        GameObject.Find("Player").GetComponent<Player>().UseAbility();
    }

    
}
