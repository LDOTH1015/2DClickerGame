using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeSystem : MonoBehaviour
{
    [SerializeField]private GameObject upgradeUI;
    [SerializeField] private TextMeshProUGUI price;
    [SerializeField] private TextMeshProUGUI gold;

    void Update()
    {
        gold.text = GameManager.Instance.GameStatuse.GetGold().ToString();
        price.text = GameManager.Instance.GameStatuse.GetUpgradePrice().ToString();
    }

    public void OpenUpgradeUI()
    {
        upgradeUI.SetActive(true);
    }

    public void CloseUpgradeUI()
    {
        upgradeUI.SetActive(false);
    }

    public void BuyUpgrade()
    {
        GameManager.Instance.GameStatuse.SetGold(-GameManager.Instance.GameStatuse.GetUpgradePrice());
        GameManager.Instance.GameStatuse.UpUpgradePrice();
        GameManager.Instance.GameStatuse.UpClickPower();
        GameManager.Instance.GameStatuse.UpAttackGold();
    }
}
