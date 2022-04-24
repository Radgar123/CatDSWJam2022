using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayRandomFoosteps : MonoBehaviour
{
    [SerializeField] GameObject[] footsteps;
    public Color[] colors;
    private IEnumerator Start() {
        int i = 0;
        foreach(GameObject footstepPreset in footsteps)
        {
            footstepPreset.SetActive(true);
            foreach (Transform item in footstepPreset.transform)
                {
                    item.GetComponent<Image>().color = colors[i%colors.Length];
                    item.gameObject.SetActive(false);
                }
            i++;
            footstepPreset.SetActive(false);
        }

        int currentPreset = 0;
        while(true)
        {

            StartCoroutine(Footsteps(currentPreset));
            currentPreset = (currentPreset + 1) % footsteps.Length;
            yield return new WaitForSeconds(3.5f);
        }
        
    }

    private IEnumerator Footsteps(int currentID){
        GameObject footstepPreset = footsteps[currentID];
            footstepPreset.SetActive(true);
            foreach (Transform item in footstepPreset.transform)
                {
                    item.gameObject.SetActive(true);
                    yield return new WaitForSeconds(.3f);
                }
                
                foreach (Transform item in footstepPreset.transform)
                {
                    item.gameObject.SetActive(false);
                    yield return new WaitForSeconds(.3f);
                }

            footstepPreset.SetActive(false);
        
    }
}
