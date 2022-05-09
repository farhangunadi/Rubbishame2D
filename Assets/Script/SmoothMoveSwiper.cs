using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMoveSwiper : MonoBehaviour
{
    private Vector2 startTouchPosition, endTouchPosition;
    private Vector3 startBinPosition, endBinPosition;
    private float flyTime;
    private float flightDuration = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if ((endTouchPosition.x < startTouchPosition.x) && transform.position.x > -1.75f)
                StartCoroutine(Stand("left"));

            if ((endTouchPosition.x > startTouchPosition.x) && transform.position.x < -1.75f)
                StartCoroutine(Stand("right"));
        }
    }

    private IEnumerator Stand(string whereToStand)
    {
        switch (whereToStand)
        {
            case "left":
                flyTime = 0f;
                startBinPosition = transform.position;
                endBinPosition = new Vector3
                    (startBinPosition.x - 1.75f, transform.position.y, transform.position.z);

                while (flyTime < flightDuration)
                {
                    flyTime += Time.deltaTime;
                    transform.position = Vector2.Lerp
                        (startBinPosition, endBinPosition, flyTime / flightDuration);
                    yield return null;
                }
                break;

            case "right":
                flyTime = 0f;
                startBinPosition = transform.position;
                endBinPosition = new Vector3
                    (startBinPosition.x + 1.75f, transform.position.y, transform.position.z);

                while (flyTime < flightDuration)
                {
                    flyTime += Time.deltaTime;
                    transform.position = Vector2.Lerp
                        (startBinPosition, endBinPosition, flyTime / flightDuration);
                    yield return null;
                }
                break;
        }
    }
}
