using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu_Travel : MonoBehaviour
{
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Main Camera")
        {
            switch (gameObject.name)
            {
                case "Alex":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Alex_Scene);
                        break;
                    }
                case "Axel":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Alex_Scene);
                        break;
                    }
                case "AI":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.AIVersus);
                        break;
                    }
                case "Sahel":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Sahel_Scene);
                        break;
                    }
                case "Carlos":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Carlos_Scene);
                        break;
                    }
                case "Solo":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.SceneDesert);
                        break;
                    }
            }
        }
    }
    
}
