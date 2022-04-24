using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseAnim : MonoBehaviour
{
    public AnimationCurve ease;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject,Vector2.one * 1.2f,1.5f).setEase(ease).setLoopPingPong();
    }
}
