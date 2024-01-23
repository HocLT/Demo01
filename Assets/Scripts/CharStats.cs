using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{
    public string CharName;
    public int playerLevel = 1;
    public int currentEXP;
    public int[] expToNextLevel;
    public int maxLevel = 100;
    public int baseEXP = 1000;

    public int currentHP;
    public int maxHP = 100;
    public int currentMP;
    public int maxMP = 30;

    public int defence;
    public int wpnPwr;
    public int armrPwr;
    public string equippedWpn;
    public string equippedArmr;
    public Sprite charImage;
    void Start()
    {
        expToNextLevel = new int[maxLevel];
        expToNextLevel[1] = baseEXP;
        for (int i = 2; i < maxLevel; i++) 
        {
            expToNextLevel[i] = Mathf.FloorToInt(expToNextLevel[i-1] * 1.05f);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U)) 
        {
            AddExp(500);
        }
    }

    public void AddExp(int exp)
    {
        currentEXP +=  exp;
        if (currentEXP > expToNextLevel[playerLevel])
        {
            currentEXP -= expToNextLevel[playerLevel];
            playerLevel++;

            // tự xử lý phần tăng thuộc tính nhân vật
        }
    }
}
