using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu_Travel : MonoBehaviour
{
    public string LevelName;
    public void OnTriggerStay(Collider collision)
    {
        Debug.Log("EnterSmthg");
        if (collision.gameObject.name == "Main Camera")
        {
            Debug.Log("Enter Main Cam");
            switch (gameObject.name)
            {
                case "SpherePupitreAlex":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Alex_Scene);
                        break;
                    }
                case "SpherePupitreAxel":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Axel_Scene);
                        break;
                    }
                case "SpherePupitreAI":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.AIVersus);
                        break;
                    }
                case "SpherePupitreBeerPong":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.BeerPong);
                        break;
                    }
                case "SpherePupitreCarlos":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Carlos_Scene);
                        break;
                    }
                case "SpherePupitreSolo":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.SceneDesert);
                        break;
                    }
                case "SpherePupitreCannon":
                    {
                        Scene_Manager.instance.setOtherLevel(SceneID.Cannon);
                        break;
                    }
            }
        }
    }
    
}
