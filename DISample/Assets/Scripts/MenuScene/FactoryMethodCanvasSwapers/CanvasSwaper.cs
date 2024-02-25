using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CanvasSwaper : MonoBehaviour,ICanvasSwaper,IService,IInjectable
{
   protected MenuSceneManager _menuSceneManager;
    public void Inject(MenuSceneManager menuSceneManager)
    {
        _menuSceneManager = menuSceneManager;
    }

    public abstract void SwapeCanvases(GameObject oldCanvas, GameObject newCanvas);
    
}
