using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadingInfo : MonoBehaviour
{
    public Text txtLoading;

    public void BtnClick()
    {
        StartCoroutine(LoadGameProg());
    }

    IEnumerator LoadGameProg()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(1);

        while(!async.isDone)
        {
            txtLoading.enabled = true;
            yield return null;
        }
    }
   
}
