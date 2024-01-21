using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFade : MonoBehaviour
{
    public static UIFade instance;
    public Image fadeScreen;

    public float fadeSpeed = 1f;

    public bool shoudFadeToBlack;
    public bool shoudFadeFromBlack;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            // xóa đối tượng được tạo ra khi load lại scene
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (shoudFadeToBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime));

            if (fadeScreen.color.a == 1)
            {
                shoudFadeToBlack = false;
            }
        }

        if (shoudFadeFromBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime));

            if (fadeScreen.color.a == 0)
            {
                shoudFadeFromBlack = false;
            }
        }
    }

    public void FadeToBlack()
    {
        shoudFadeToBlack = true;
        shoudFadeFromBlack = false;
    }

    public void FadeFromBlack()
    {
        shoudFadeToBlack = false;
        shoudFadeFromBlack = true;
    }
}
