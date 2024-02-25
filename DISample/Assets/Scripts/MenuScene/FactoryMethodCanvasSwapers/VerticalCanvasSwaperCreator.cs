using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalCanvasSwaperCreator : CanvasSwaperCreator
{
    public override ICanvasSwaper FactoryMethod(Injector injector)
    {
        GameObject newCanvasSwaper = new GameObject(name: "CanvasSwaper");
        newCanvasSwaper.AddComponent(typeof(VerticalCanvasSwaper));
        injector.MakeInjection(newCanvasSwaper.GetComponent<CanvasSwaper>());
        return newCanvasSwaper.GetComponent<ICanvasSwaper>();
    }
}

