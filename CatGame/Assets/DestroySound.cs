using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySound : MonoBehaviour
{
    [SerializeField] private AudioSource mainSceneAudio;
    [SerializeField] private AudioClip destroyClip;

    private void OnDestroy()
    {
        mainSceneAudio.PlayOneShot(destroyClip);
    }
}
