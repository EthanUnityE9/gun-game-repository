using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guntwod : MonoBehaviour
{
    private void Update()
    {
        var point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(new Vector3(transform.position.x, point.y, point.z));
    }
   
}
