using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelName : MonoBehaviour
{
    public string levelName;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    void Start()
    {

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Application.LoadLevel("OtherDimension");
            //   SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
            SceneManager.LoadScene(levelName, LoadSceneMode.Single);
            Debug.Log("you entered");
        }
    }

    public void OnTriggerLeave(Collider other)
    {
        Debug.Log("you Leaved");
    }
}
