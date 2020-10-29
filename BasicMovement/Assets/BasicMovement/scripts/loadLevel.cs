using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public int levelNumber;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    void Start()
    {
       // myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/0UnityModulII/");
       // scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }

 
    public void OnTriggerEnter(Collider other)
    {
        // Application.LoadLevel("OtherDimension");
        //   SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
        SceneManager.LoadScene(levelNumber);
        Debug.Log("you entered");
    }

    public void OnTriggerLeave(Collider other)
    {
        Debug.Log("you Leaved");
    }
}
