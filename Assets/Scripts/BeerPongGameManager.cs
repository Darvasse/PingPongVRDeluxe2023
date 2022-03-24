using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeerPongGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text ScoreTxt;
    int nbCups= 10;
    public GameObject CupSet;
    public Scene_Manager sm;
    void Start()
    {
        nbCups = CupSet.GetComponent<Transform>().childCount;
    }

    // Update is called once per frame
    void Update()
    {
        nbCups = CupSet.GetComponent<Transform>().childCount;
        if (nbCups == 1)
        {
            ScoreTxt.text = nbCups + " verre restant";
        }
        else
        {
            ScoreTxt.text = nbCups + " verres restants";
        }
        if(nbCups == 0)
        {
            sm.setOtherLevel(SceneID.MainMenu);
        }
        

    }
}
