using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneID
{
    MainMenu=0,
    AIVersus = 1,
    SceneDesert=2
}

public class Scene_Manager : MonoBehaviour
{
    public static Scene_Manager instance;
    private SceneID currentSceneID;
    private SceneID lastSceneID;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setOtherLevel()
    {
        switch (currentSceneID)
        {
            case SceneID.MainMenu:
                {
                    SceneManager.LoadScene(sceneBuildIndex: (int)SceneID.MainMenu);
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
