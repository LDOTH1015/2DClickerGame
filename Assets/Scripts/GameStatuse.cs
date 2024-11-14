using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatuse : MonoBehaviour
{
    private float clickPower = 1;
    private float gameLevel = 1;
    private float attackGold = 1;
    private float upgradePrice = 100;
    private float gold = 0;
    private float score = 0;
    public float GetClickPower()
    {
        return clickPower;
    }

    public void UpClickPower()
    {
        clickPower *= 2;
    }

    public float GetGameLevel()
    {
        return gameLevel;
    }

    public void GameLevelUp()
    {
        gameLevel++;
    }

    public float GetAttackGold()
    {
        return attackGold;
    }

    public void UpAttackGold()
    {
        attackGold *= 2f;
    }

    public float GetGold()
    {
        return gold;
    }

    public void SetGold(float data)
    {
        gold += Mathf.FloorToInt(data);
    }

    public float GetScore()
    {
        return score;
    }

    public void SetScore(float data)
    {
        score += data;
    }

    private void Start()
    {
        GameManager.Instance.GameStatuse = this;
    }

    public float GetUpgradePrice()
    {
        return Mathf.CeilToInt(upgradePrice);
    }

    public void UpUpgradePrice()
    {
        upgradePrice *= 2.5f;
    }
}
