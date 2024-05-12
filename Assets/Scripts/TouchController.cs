using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5.0f;


    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                PressAndDrag(touch.position);
            }

        }
    }

    

    void PressAndDrag(Vector2 touchPosition)
    {

        Vector3 currentPosition = transform.position;
        Vector3 touchWorldPosition = Camera.main.ScreenToWorldPoint(touchPosition);
        touchWorldPosition.y = currentPosition.y;
        touchWorldPosition.z = currentPosition.z;
        transform.position = Vector3.MoveTowards(currentPosition, touchWorldPosition, moveSpeed * Time.deltaTime);
    }
}
