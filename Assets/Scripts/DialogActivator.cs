using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogActivator : MonoBehaviour
{
    public string[] lines;

    bool canActive;
    void Start()
    {
        
    }

    void Update()
    {
        if (canActive && Input.GetButtonDown("Fire1") && !DialogManager.instance.dialog.activeInHierarchy)
        {
            DialogManager.instance.ShowDialog(lines);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            canActive = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            canActive = false;
        }
    }
}
