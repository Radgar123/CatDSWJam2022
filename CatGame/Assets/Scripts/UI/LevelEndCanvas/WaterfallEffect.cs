using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterfallEffect : MonoBehaviour
{
    public GameObject[] uiElements;
    private void OnEnable() {
        GetComponent<Canvas>().worldCamera = Camera.main;
        Animation();
    }

    void Animation(){

        foreach (var item in uiElements)
        {
            item.SetActive(false);
        }

        foreach (var item in uiElements)
        {
            item.SetActive(true);
        }
    }

}
