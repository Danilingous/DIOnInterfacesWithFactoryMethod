using System.Collections;
using UnityEngine;

public class MultiCanvasSwaper : CanvasSwaper
{
    public override void SwapeCanvases(GameObject imageOldCanvas, GameObject imageNewCanvas)
    {
        StartCoroutine(CoroutineChangeCanvas(imageOldCanvas, imageNewCanvas));
    }

    private IEnumerator CoroutineChangeCanvas(GameObject imageOldCanvas, GameObject imageNewCanvas)
    {
        _menuSceneManager.ForbidClickButtons();
        float currentScaleValue = 1;
        for (int i = 0; i < 15; i++)
        {
            currentScaleValue -= 0.066f;
            imageOldCanvas.GetComponent<RectTransform>().localScale = new Vector3(currentScaleValue, currentScaleValue, currentScaleValue);
            yield return new WaitForSeconds(0.02f);
        }
        imageOldCanvas.GetComponent<RectTransform>().localScale = Vector3.zero;
        currentScaleValue = 0;
        for (int i = 0; i < 15; i++)
        {
            currentScaleValue += 0.066f;
            imageNewCanvas.GetComponent<RectTransform>().localScale = new Vector3(currentScaleValue, currentScaleValue, currentScaleValue);
            yield return new WaitForSeconds(0.02f);
        }
        imageNewCanvas.GetComponent<RectTransform>().localScale = Vector3.one;
        _menuSceneManager.LetClickButtons();
    }
}
