using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public GameObject theMenu;

    CharStats[] playerStats;

    public TMP_Text[] nameText, hpText, mpText, lvlText, expText;
    public Slider[] expSlider;
    public Image[] charImage;
    public GameObject[] charStatHolder;

    public GameObject[] windows;

    void Start()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = FindObjectOfType<GameManager>().GetComponent<GameManager>();
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (theMenu.activeInHierarchy)
            {
                theMenu.SetActive(false);
                GameManager.instance.gameMenuOpen = false;
            }
            else
            {
                theMenu.SetActive(true);
                UpdateMainStats();
                GameManager.instance.gameMenuOpen = true;
            }
        }
    }

    public void UpdateMainStats()
    {
        playerStats = GameManager.instance.playerStats;

        for (int i = 0; i < playerStats.Length; i++)
        {
            if (playerStats[i].gameObject.activeInHierarchy)
            {
                charStatHolder[i].SetActive(true);
                nameText[i].text = playerStats[i].CharName;
                hpText[i].text = $"HP: {playerStats[i].currentHP}/{playerStats[i].maxHP}";
                mpText[i].text = $"HP: {playerStats[i].currentMP}/{playerStats[i].maxMP}";
                lvlText[i].text = $"Lvl: {playerStats[i].playerLevel}";
                expText[i].text = $"{playerStats[i].currentEXP}/{playerStats[i].expToNextLevel[playerStats[i].playerLevel]}";
                expSlider[i].maxValue = playerStats[i].expToNextLevel[playerStats[i].playerLevel];
                expSlider[i].value = playerStats[i].currentEXP;
                charImage[i].sprite = playerStats[i].charImage;
            }
            else
            {
                charStatHolder[i].SetActive(false);
            }
        }
    }

    public void ToggleWindow(int idx)
    {
        for (int i = 0; i < windows.Length; i++)
        {
            if (i == idx)
            {
                windows[i].SetActive(!windows[i].activeInHierarchy);
            }
            else 
            {
                windows[i].SetActive(false);
            }
        }
    }

    public void CloseMenu()
    {
        for (int i = 0; i < windows.Length; i++)
        {
            windows[i].SetActive(false);
        }

        theMenu.SetActive(false);
        GameManager.instance.gameMenuOpen = false;  // cho nhân vật di chuyển
    }
}
