using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float offsetX;
    int currentPos = 0;
    public float delay;
    Animator anim;
    void Start()
    {
        currentPos = 0;
        anim = GetComponent<Animator>();
        anim.SetTrigger("goleft");

    }

    void Update()
    {
        Debug.Log(currentPos);

        StartCoroutine(sideMove1());
        StartCoroutine(sideMove2());

        transform.position = new Vector3(offsetX * currentPos , transform.position.y, transform.position.z);
    }

    IEnumerator sideMove1()
    {
        if (Input.GetAxis("Horizontal") > 0f && currentPos != 1) { currentPos++; }
        yield return new WaitForSeconds(delay);
    }

    IEnumerator sideMove2()
    {
        if (Input.GetAxis("Horizontal") < 0f && currentPos != -1) { currentPos--; }
        yield return new WaitForSeconds(delay);
    }
}
