using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // config params
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float min = 1f;
    [SerializeField] float max = 15f;
    [SerializeField] bool autoplayEnabled = false;

    // cached references
    private Ball theBall;
    
    // Start is called before the first frame update
    void Start()
    {
        theBall = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 paddlePos = new Vector2(getNewPosX(), transform.position.y);
        transform.position = paddlePos;


    }

    private float getNewPosX()
    {
        float newPosX;
        if (!autoplayEnabled)
        {
            float mousePosX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
            //newPosX = Mathf.Clamp(theBall.transform.position.x, min, max); // autoplay
            newPosX = Mathf.Clamp(mousePosX, min, max);
        }
        else
        {
            float ballPosX = theBall.transform.position.x;
            newPosX = Mathf.Clamp(ballPosX, min, max);
        }

        return newPosX;
    }
}
