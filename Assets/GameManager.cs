using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GameObject[] checks;
    public CanvasGroup fade;
    public PlayerMovement player;
    public GameObject outro;
    public GameObject oldCar;
    public GameObject ObjUI;
    public GameObject crosshair;

    private int itemCount;

    public void closeApp()
    {
        Application.Quit();
    }

    private void Start()
    {
        StartCoroutine(startRountine());
    }

    private IEnumerator startRountine()
    {
        LeanTween.alphaCanvas(fade, 0, 3);
        yield return new WaitForSeconds(3.5f);
        player.enabled = true;
    }

    public void checkObject(int index)
    {
        checks[index].SetActive(true);
        itemCount++;

        if (itemCount == 5)
            StartCoroutine(finishRoutine());
    }

    private IEnumerator finishRoutine()
    {
        yield return new WaitForSeconds(3);
        LeanTween.alphaCanvas(fade, 1, 3);
        yield return new WaitForSeconds(3f);
        player.gameObject.SetActive(false);
        outro.SetActive(true);
        oldCar.SetActive(false);
        crosshair.SetActive(false);
        ObjUI.SetActive(false);
        LeanTween.alphaCanvas(fade, 0, 1);
    }
}
