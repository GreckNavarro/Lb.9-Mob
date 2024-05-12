using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamicObjectPooling : MonoBehaviour
{
    public List<GameObject> objectPool;
    public GameObject objectPrefab;
    public GameObject inicialposition;

    public void GetObject()
    {
        GameObject tmp;
        if (objectPool.Count > 0)
        {
            tmp = objectPool[0];
            objectPool.RemoveAt(0);
            tmp.SetActive(true);
            tmp.GetComponent<PlatformController>().InitVariables();
        }
        else
        {
            tmp = Instantiate(objectPrefab, inicialposition.transform.position, transform.rotation);
            //tmp.GetComponent<PlatformController>().SetObjectPooling(this);
           // tmp.GetComponent<PlatformController>().InitVariables();
            tmp.transform.SetParent(this.transform);
            tmp.SetActive(true);
        }
    }
    public void SetObject(GameObject obj)
    {
        objectPool.Add(obj);
        obj.SetActive(false);
    }
}
