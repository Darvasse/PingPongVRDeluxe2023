using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Scene_or_Menu : MonoBehaviour
{

    private SceneID LevelName;
    // Start is called before the first frame update
    void Start()
    {
        LevelName = Scene_Manager.instance.getCurrentSceneID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Main Camera")
        {
            switch(gameObject.name)
            {
                case "SphereMenu":
                    Scene_Manager.instance.setOtherLevel(SceneID.MainMenu);
                    break;
                case "SphereReset":
                    Scene_Manager.instance.setOtherLevel(LevelName);
                    break;
                default:
                    Debug.LogError("Error Switching Scene: Wrong Sphere Name");
                    break;
            }
        }
    }
}
