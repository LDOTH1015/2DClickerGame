using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    [SerializeField]private GameObject upgradeUI;

    public void OpenUpgradeUI()
    {
        upgradeUI.SetActive(true);
    }
}
