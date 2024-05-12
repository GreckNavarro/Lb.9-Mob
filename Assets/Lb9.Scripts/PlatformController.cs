using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] StaticObjectPooling staticObjectPooling;
    [SerializeField] float speed; 

   
    public void SetObjectPooling(StaticObjectPooling pool)
    {
        staticObjectPooling = pool;
    }

    public void InitVariables()
    {

        float randomX = Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(randomX, 13.2f, 0);

    }
    private void Update()
    {

        transform.position += Vector3.down * speed * Time.deltaTime;
        
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Limite")
        {
            Debug.Log("Choco");
            staticObjectPooling.SetObject(this.gameObject);
            staticObjectPooling.GetObject();
        }
    }


}
