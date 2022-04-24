using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFade : MonoBehaviour
{
    public GameObject footstepObj;
    public AnimationCurve ease;

    private void Start() {
        LeanTween.scale(footstepObj,Vector3.zero, 2f).setEase(ease).setOnComplete(() => {Destroy(gameObject);});
    }
}