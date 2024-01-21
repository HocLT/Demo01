using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    public string areaToLoad;

    public string areaTransitionName;

    AreaEntrance theEntrance;

    //UIFade uiFace;

    public float waitToLoad = 1f;
    bool shouldLoadAfterFade;

    public void Awake()
    {
        //uiFace = FindObjectOfType<UIFade>();
    }

    void Start()
    {
        theEntrance = FindObjectOfType<AreaEntrance>();
        theEntrance.transitionName = areaTransitionName;
    }

    void Update()
    {
        if (shouldLoadAfterFade)
        {
            waitToLoad -= Time.deltaTime;
            if (waitToLoad <= 0)
            {
                shouldLoadAfterFade = false;
                SceneManager.LoadScene(areaToLoad);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene(areaToLoad);
            shouldLoadAfterFade = true;
            UIFade.instance.FadeToBlack();   // làm màn hình đen
            PlayerController.instance.areaTransitionName = areaTransitionName;
        }
    }
}

