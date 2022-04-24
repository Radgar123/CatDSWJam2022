using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class FootstepFade : MonoBehaviour
{
    WaitForSeconds delay;
    // Start is called before the first frame update
    void OnEnable() {
       StartCoroutine(Fade());
    }

    IEnumerator Fade(){
         Image image = GetComponent<Image>();
        Color color = image.color;
        delay = new WaitForSeconds(0.03f);
        for(float i = 1f; i >=0f;i=i-0.01f)
        {
            color.a = i;
            image.color = color;
            yield return delay;
        }
    }
}
