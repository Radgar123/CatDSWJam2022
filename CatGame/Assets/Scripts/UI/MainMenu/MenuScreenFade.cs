using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreenFade : MonoBehaviour
{
    public AnimationCurve ease;
    public float targetScale;
    public Vector2 targetPos;
    public float animTime;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject,Vector3.one * targetScale, animTime).setEase(ease);
        LeanTween.moveLocalY(gameObject,targetPos.y,animTime).setEase(ease);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
