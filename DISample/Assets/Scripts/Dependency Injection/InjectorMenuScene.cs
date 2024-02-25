using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InjectorMenuScene : Injector
{
    [Header("Servisec")]
    [SerializeField] private MenuSceneUIManager _menuSceneUIManager;
    [SerializeField] private MenuSceneManager _menuSceneManager;

    private ICanvasSwaper _canvasSwaper;
    private CanvasSwaperCreator _canvasSwaperCreator;

    protected override void Awake()
    {
        ChooseCanvasSwaperCreator();
        _canvasSwaper= CreateCanvasSwaper(_canvasSwaperCreator);
        base.Awake();
    }
    public override void MakeInjection(IInjectable injectable)
    {   
            switch(injectable)
            {
                case MenuSceneManager injectebleObject:
                    injectebleObject.Inject(_menuSceneUIManager);
                    break;
            case CanvasSwaper canvasSwaper:
                canvasSwaper.Inject(_menuSceneManager);
                break;
            case MenuSceneUIManager menuSceneUIManager:
                menuSceneUIManager.Inject(_canvasSwaper);
                break;

            default:
                break;
            }
    }

    private void ChooseCanvasSwaperCreator()
    {
        //  The test version
        if (UnityEngine.Random.Range(0, 2) > 0)
            _canvasSwaperCreator = new MultiCanvasSwaperCreator();
        else _canvasSwaperCreator = new VerticalCanvasSwaperCreator();
    }

    private ICanvasSwaper CreateCanvasSwaper(CanvasSwaperCreator  canvasSwaperCreator)
    {
        return canvasSwaperCreator.FactoryMethod(this);
    }
}
