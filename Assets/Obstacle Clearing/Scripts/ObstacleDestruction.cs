using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestruction : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    void OnMouseDown()
    {
        if (gameObject.tag == "obs1")
        {
            gameObject.SetActive(false);
        } 
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
       mousePoint.z = mZCoord;
       return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        if (gameObject.tag == "obs2")
        {
            transform.position = GetMouseAsWorldPoint() + mOffset;
        }
        
    }
}
