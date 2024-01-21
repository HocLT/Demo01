using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject uiScreen;

    public GameObject player;

    void Start()
    {
        // if (UIFade.instance == null)
        // {
        //     Instantiate(uiScreen);
        // }
        if (PlayerController.instance == null)
        {
            Instantiate(player);
        }
    }

    void Update()
    {

    }
}
