using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryController : MonoBehaviour
{
    public GameObject[] slides;

    IEnumerator Start() {
        int i =0;
        foreach (var item in slides)
        {
            DectivateAll();
            item.SetActive(true);
            yield return new WaitForSeconds(3f);
            i++;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void DectivateAll(){
        foreach (var item in slides)
        {
            item.SetActive(false);
        }
    }
}
