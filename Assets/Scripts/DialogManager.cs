using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public static DialogManager instance;
    public TMP_Text dialogText, headerText;

    public GameObject dialog, header;

    public string[] dialogLines;
    public int currentLine;

    bool justStarted;

    void Start()
    {
        instance = this;

        dialogText.text = dialogLines[currentLine];
    }

    void Update()
    {
        if (dialog.activeInHierarchy)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                if (!justStarted)
                {
                    currentLine++;
                    if (currentLine >= dialogLines.Length)
                    {
                        dialog.SetActive(false);    // ẩn dialog

                        PlayerController.instance.canMove = true;
                    }
                    else
                    {
                        CheckName();
                        dialogText.text = dialogLines[currentLine];
                    }
                }
                else
                {
                    justStarted = false;
                }
            }
        }
    }

    public void ShowDialog(string[] newLines)
    {
        dialogLines = newLines;
        currentLine = 0;

        CheckName();

        dialogText.text = dialogLines[currentLine];
        dialog.SetActive(true); // hiển thị dialog

        justStarted = true;

        PlayerController.instance.canMove = false;
    }

    public void CheckName()
    {
        if (dialogLines[currentLine].StartsWith("n-"))
        {
            headerText.text = dialogLines[currentLine++].Replace("n-", "");
        }
    }
}
