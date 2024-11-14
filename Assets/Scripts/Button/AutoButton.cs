using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoButton : MonoBehaviour
{
    private bool isClick = false;
    private Vector2 clickPosition = new Vector2(0, 0);
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
        RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

        if (hit.collider != null)
        {
            hit.collider.gameObject.SendMessage("OnAutoClick", clickPosition, SendMessageOptions.DontRequireReceiver);
        }
        yield return new WaitForSeconds(1);
        coroutine = null;
    }
}
