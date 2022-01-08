using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AnimFin : MonoBehaviour
{
    public GameObject finalFrame;
    public CanvasGroup whiteFade;

    public void fade()
    {
        StartCoroutine(fadeRoutine());
    }

    private IEnumerator fadeRoutine()
    {
        whiteFade.gameObject.SetActive(true);
        whiteFade.alpha = 1;
        finalFrame.SetActive(true);
        yield return new WaitForSeconds(1);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        LeanTween.alphaCanvas(whiteFade, 0, 3);
    }
}
