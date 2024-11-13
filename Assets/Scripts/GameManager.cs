using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return instance;
        }
    }

    private GameStatuse gameStatuse;

    public GameStatuse GameStatuse
    {
        get { return gameStatuse; }
        set { gameStatuse = value; }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance == this)
            {
                Destroy(gameObject);
            }
        }
    }

    void Update()
    {
        score.text = gameStatuse.GetScore().ToString();
    }

    public void AddScore()
    {
        gameStatuse.SetScore(gameStatuse.GetClickPower());
    }
}
