using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoButton : MonoBehaviour
{
    private bool isClick = false;
    private Coroutine coroutine;
    void Update()
    {
        if (isClick&&coroutine == null)
        {
            coroutine = StartCoroutine(AutoClick());
        }
    }

    public void onClick()
    {
        isClick = true;
    }

    private IEnumerator AutoClick()
    {
        GameManager.Instance.AddScore();
        yield return new WaitForSeconds(1);
        coroutine = null;
    }
}
