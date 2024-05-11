using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    
    [SerializeField] DinamicObjectPooling DinamicObjectPool;
    [SerializeField] StaticObjectPooling StaticObjectPool;

    private Vector3 startPosition;

    public void SetObjectPoolDinamic(DinamicObjectPooling obj )
    {
        DinamicObjectPool = obj;
    }
    public void SetObjectPoolStatic(StaticObjectPooling obj)
    {
        StaticObjectPool = obj;
    }

    public void InitVariables()
    {
        // Funcion que se encarga de inicializar nuestro objeto según las necesidades
    }
    public void ReturnObjectPool()
    {
        //DinamicObjectPool.SetObject(this.gameObject);
        //StaticObjectPool.SetObject(this.gameObject);
    }

}
