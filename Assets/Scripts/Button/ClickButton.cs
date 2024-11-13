using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    void OnMouseDown()
    {
        GameManager.Instance.AddScore();
    }
}
