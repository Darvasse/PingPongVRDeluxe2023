using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneID
{
    MainMenu = 0,
    AIVersus = 1,
    SceneDesert = 2,
    Alex_Scene = 3,
    Axel_Scene = 4,
    Carlos_Scene = 5,
    BeerPong = 6,
    Cannon = 7

}

public class Scene_Manager : MonoBehaviour
{
    public static Scene_Manager instance;
    private SceneID currentSceneID;
    private SceneID lastSceneID;
    public void Awake()
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
    
    public void setOtherLevel(int LevelID)
    {
        switch (LevelID)
        {
            case 0:
                {
                    SceneManager.LoadScene("MainMenu");
                    currentSceneID = SceneID.MainMenu;
                    break;
                }
            case 1:
                {
                    SceneManager.LoadScene("AIVersusScene");
                    currentSceneID = SceneID.AIVersus;
                    break;
                }
            case 2:
                {
                    SceneManager.LoadScene("SceneDesert");
                    currentSceneID = SceneID.SceneDesert;
                    break;
                }
            case 3:
                {
                    SceneManager.LoadScene("Alex_Scene");
                    currentSceneID = SceneID.Alex_Scene;
                    break;
                }
            case 4:
                {
                    SceneManager.LoadScene("Axel_Scene");
                    currentSceneID = SceneID.Axel_Scene;
                    break;
                }
            case 5:
                {
                    SceneManager.LoadScene("Carlos_Scene");
                    currentSceneID = SceneID.Carlos_Scene;
                    break;
                }
            case 6:
                {
                    SceneManager.LoadScene("BeerPong");
                    currentSceneID = SceneID.BeerPong;
                    break;
                }

            case 7:
                {
                    SceneManager.LoadScene("Cannon");
                    currentSceneID = SceneID.Cannon;
                    break;
                }
                {
                    SceneManager.LoadScene("BeerPong");
                    currentSceneID = SceneID.BeerPong;
                    break;
                }
            default: 
                { 
                    Debug.LogError("Erreur In SceneLoader"); 
                    break; 
                }
        }
    }
    public void setOtherLevel(string LevelName)
    {
        switch (LevelName)
        {
            case "MainMenu":
                {
                    SceneManager.LoadScene(sceneBuildIndex: (int)SceneID.MainMenu);
                    currentSceneID = SceneID.MainMenu;
                    break;
                }
            case "AIVersus":
                {
                    SceneManager.LoadScene("AIVersusScene");
                    currentSceneID = SceneID.AIVersus;
                    break;
                }
            case "SceneDesert":
                {
                    SceneManager.LoadScene("SceneDesert");
                    currentSceneID = SceneID.SceneDesert;
                    break;
                }
            case "Alex_Scene":
                {
                    SceneManager.LoadScene("Alex_Scene");
                    currentSceneID = SceneID.Alex_Scene;
                    break;
                }
            case "Axel_Scene":
                {
                    SceneManager.LoadScene("Axel_Scene");
                    currentSceneID = SceneID.Axel_Scene;
                    break;
                }
            case "Carlos_Scene":
                {
                    SceneManager.LoadScene("Carlos_Scene");
                    currentSceneID = SceneID.Carlos_Scene;
                    break;
                }
            case "BeerPong_Scene":
                {
                    SceneManager.LoadScene("BeerPong");
                    currentSceneID = SceneID.BeerPong;
                    break;
                }
            case "Cannon":
                {
                    SceneManager.LoadScene("Cannon");
                    currentSceneID = SceneID.Cannon;
                    break;
                }
            default:
                {
                    Debug.LogError("Erreur In SceneLoader");
                    break;
                }
        }
    }
    public void setOtherLevel(SceneID sceneID)
    {
        switch (sceneID)
        {
            case SceneID.MainMenu:
                {
                    SceneManager.LoadScene(sceneBuildIndex: (int)SceneID.MainMenu);
                    currentSceneID = SceneID.MainMenu;
                    break;
                }
            case SceneID.AIVersus:
                {
                    SceneManager.LoadScene("AIVersusScene");
                    currentSceneID = SceneID.AIVersus;
                    break;
                }
            case SceneID.SceneDesert:
                {
                    SceneManager.LoadScene("SceneDesert");
                    currentSceneID = SceneID.SceneDesert;
                    break;
                }
            case SceneID.Alex_Scene:
                {
                    SceneManager.LoadScene("Alex_Scene");
                    currentSceneID = SceneID.Alex_Scene;
                    break;
                }
            case SceneID.Axel_Scene:
                {
                    SceneManager.LoadScene("Axel_Scene");
                    currentSceneID = SceneID.Axel_Scene;
                    break;
                }
            case SceneID.Carlos_Scene:
                {
                    SceneManager.LoadScene("Carlos_Scene");
                    currentSceneID = SceneID.Carlos_Scene;
                    break;
                }
            case SceneID.BeerPong:
                {
                    SceneManager.LoadScene("BeerPong");
                    currentSceneID = SceneID.BeerPong;
                    break;
                }
            case SceneID.Cannon:
                {
                    SceneManager.LoadScene("Cannon");
                    currentSceneID = SceneID.Cannon;
                    break;
                }
            default:
                {
                    Debug.LogError("Erreur In SceneLoader");
                    break;
                }
        }
    }
    public void EndApp()
    {
        Application.Quit();
    }
    public void LoadLastScene()
    {
        currentSceneID = lastSceneID;
        setOtherLevel(currentSceneID);
    }
    public SceneID getCurrentSceneID()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "MainMenu": currentSceneID = SceneID.MainMenu;break;
            case "AIVersusScene": currentSceneID = SceneID.AIVersus; break;
            case "SceneDesert":currentSceneID = SceneID.SceneDesert;break;
            case "Alex_Scene": currentSceneID = SceneID.Alex_Scene;break;
            case "Axel_Scene": currentSceneID = SceneID.Axel_Scene;break;
            case "Carlos_Scene": currentSceneID = SceneID.Carlos_Scene;break;
            case "BeerPong_Scene": currentSceneID = SceneID.BeerPong;break;
            case "Cannon": currentSceneID = SceneID.Cannon;break;
        }
        return currentSceneID;
    }
}
