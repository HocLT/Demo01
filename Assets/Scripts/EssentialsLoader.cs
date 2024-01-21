using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject uiScreen;

    public GameObject player;

    void Start()
    {
        if (UIFade.instance == null)
        {
            UIFade.instance = Instantiate(uiScreen).GetComponent<UIFade>();
        }
        if (PlayerController.instance == null)
        {
            PlayerController.instance = Instantiate(player).GetComponent<PlayerController>();
        }
    }

    void Update()
    {

    }
}
