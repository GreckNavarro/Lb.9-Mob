using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
   

    // DOUBLE TAP;
    bool tapping = false;
    float lastTapTime = 0;
    float doubleTapThreshold = 0.2f;

    //PRESS AND DRAG
    bool presstouch = false;
   



    //SWIPE
    Vector2 startPos;
    Vector2 endPos;
    [SerializeField] float swipeThreshold = 300f;
    bool endswipe = true;
    bool swiperealizado = false;





    void Start()
    {
        


    }


    void Update()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);




            if (touch.phase == TouchPhase.Began)
            {

                startPos = touch.position;
                swiperealizado = false;

                Vector2 touchpos = Camera.main.ScreenToWorldPoint(touch.position);




                if (!tapping)
                {
                    tapping = true;
                    StartCoroutine(SingleTap(touch.position));
                }


                if ((Time.time - lastTapTime) < doubleTapThreshold)
                {
                    //Mecanica doubletap
                }
                lastTapTime = Time.time;

            }

            if (touch.phase == TouchPhase.Moved)
            {
                presstouch = true;
                PressAndDrag(touch.position);


            }

            if (touch.phase == TouchPhase.Ended)
            {
                presstouch = false;

                endPos = touch.position;
                Vector2 DiferencePosition = endPos - startPos;
                if (DiferencePosition.magnitude > swipeThreshold && endswipe == true)
                {

                    //Mecanica Swipe
                    swiperealizado = true;
                }

                endswipe = true;
            }


        }
    }

    IEnumerator SingleTap(Vector2 touchposition)
    {
        yield return new WaitForSeconds(doubleTapThreshold);
        if (tapping && presstouch == false && swiperealizado == false)
        {
            //Mecanica de single TAP
        }
        tapping = false;
    }


    void PressAndDrag(Vector2 touchPosition)
    {
    
    }
}
