using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneManager : MonoBehaviour,IService,IInjectable
{
    public bool IsAvaliableClickButtons { get; private set; } = true;
    private MenuSceneUIManager _menuSceneUIManager;
    private GameObject asd;

    public void Inject(MenuSceneUIManager menuSceneUIManager)
    {
        _menuSceneUIManager = menuSceneUIManager;
    }

    public void LetClickButtons() => IsAvaliableClickButtons = true;
    public void ForbidClickButtons() => IsAvaliableClickButtons = false;


    public void ClickSettingsButton()
    {
        if (IsAvaliableClickButtons) _menuSceneUIManager.OpenCanvasSettings();
    }
    public void ClickButtonBackToMenuFromSettings()
    {
        if (IsAvaliableClickButtons) _menuSceneUIManager.ClothCanvasSettings();
    }
    
   
}
