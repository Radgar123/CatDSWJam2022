using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterfallEffect : MonoBehaviour
{
    public GameObject[] uiElements;
    private void OnEnable() {
        StartCoroutine(Animation());
    }

    IEnumerator Animation(){

        foreach (var item in uiElements)
        {
            item.SetActive(false);
        }

        foreach (var item in uiElements)
        {
            item.SetActive(true);
            yield return new WaitForSeconds(1f);
        }
    }

}
