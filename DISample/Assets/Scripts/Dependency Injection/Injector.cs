using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Injector : MonoBehaviour
{
    protected List<IInjectable> _injectableObjects = new();
  
    protected virtual void Awake()
    {
        StartInjection();
    }
    protected void StartInjection()
    {
        var rootObjs = SceneManager.GetActiveScene().GetRootGameObjects();
        var startTime = Time.realtimeSinceStartup;
        foreach (var root in rootObjs)
        {
            Debug.Log(root.name);
            _injectableObjects.AddRange(root.GetComponentsInChildren<IInjectable>(true));
        }
        Debug.Log("Time spent checking all objects" + (Time.realtimeSinceStartup- startTime).ToString("0.000000"));
     
        for(int i=0; i<_injectableObjects.Count;i++)
        {
            MakeInjection(_injectableObjects[i]);
        }
    }
    public abstract void MakeInjection(IInjectable injectable);
}
