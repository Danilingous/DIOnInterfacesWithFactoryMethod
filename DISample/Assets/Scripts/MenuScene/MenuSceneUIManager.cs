using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneUIManager : MonoBehaviour, IService ,IInjectable
{
    private ICanvasSwaper _canvasSwaper;

    [Header("Canvases")]
    [SerializeField] private GameObject _canvasFirstOpen;

    [Header("Back images for canvas animations")]
    [SerializeField] private GameObject _imageCanvasMenu;
    [SerializeField] private GameObject _imageCanvasSettings;
    [SerializeField] private GameObject _imageCanvasLevels;

    public void Inject(ICanvasSwaper canvasSwaper)
    {
        _canvasSwaper = canvasSwaper;
    }

    public void OpenCanvasSettings()
    {
        _canvasSwaper.SwapeCanvases(_imageCanvasMenu, _imageCanvasSettings);
    }
    public void ClothCanvasSettings()
    {
        _canvasSwaper.SwapeCanvases(_imageCanvasSettings, _imageCanvasMenu);
    }

}       
