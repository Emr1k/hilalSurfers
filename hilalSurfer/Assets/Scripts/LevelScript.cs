using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public int speed = 5;
    void Update()
    {
        transform.position += new Vector3(0,0,speed) * Time.deltaTime;
    }
}
