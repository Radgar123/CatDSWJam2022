using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseAnim : MonoBehaviour
{
    public AnimationCurve ease;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject,Vector2.one * 1.1f,1.25f).setEase(ease).setLoopPingPong();
    }
}
