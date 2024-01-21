using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName;
    void Start()
    {
        FindObjectOfType<PlayerController>().transform.position = transform.position;

        FindObjectOfType<UIFade>().FadeFromBlack(); // chuyển hình ở chế độ trong suốt
    }

    void Update()
    {

    }
}
