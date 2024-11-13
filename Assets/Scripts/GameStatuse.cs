using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatuse : MonoBehaviour
{
    private int clickPower = 1;
    private int gameLevel = 1;
    private int attackGold = 10;
    private int gold = 0;
    private int score = 0;
    public int GetClickPower()
    {
        return clickPower;
    }

    public void SetClickPower(int data)
    {
        clickPower += data;
    }

    public int GetGameLevel()
    {
        return gameLevel;
    }

    public void GameLevelUp()
    {
        gameLevel++;
    }

    public int GetAttackGold()
    {
        return attackGold;
    }

    public void SetAttackGold(int data)
    {
        attackGold += data;
    }

    public int GetGold()
    {
        return gold;
    }

    public void SetGold(int data)
    {
        gold += data;
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int data)
    {
        score += data;
    }

    private void Start()
    {
        GameManager.Instance.GameStatuse = this;
    }
}
