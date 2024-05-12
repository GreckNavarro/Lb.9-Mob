using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObjectPooling : MonoBehaviour
{
    public List<GameObject> objectPool;
    public GameObject prefabGO;
    public float distancePlatform = 3.0f;

    public int maxQuantity;

    private void Start()
    {
        InstantiateObjects();
    }
    public void InstantiateObjects()
    {
        GameObject tmp;
        for (int i = 1; i <= maxQuantity; ++i)
        {
            tmp = Instantiate(prefabGO, new Vector3(Random.Range(-2.7f, 2.7f), (transform.position.y + distancePlatform * i), transform.position.z), transform.rotation);
            tmp.GetComponent<PlatformController>().SetObjectPooling(this);
            objectPool.Add(tmp);
            tmp.transform.SetParent(this.transform);
            
        }


    }
    public void GetObject()
    {
        if (objectPool.Count > 0)
        {
            GameObject tmp = objectPool[0];
            objectPool.Remove(tmp);
            tmp.GetComponent<PlatformController>().InitVariables();
            Debug.Log("Ha sido activado");
            tmp.SetActive(true);

        }
        else
        {
            print("No hay más objetos en el pool");
        }
    }
    public void SetObject(GameObject obj)
    {
        objectPool.Add(obj);
        obj.SetActive(false);
    }
}
