using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMainScreen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMainScreen(){
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("SampleScene");
    }
}
