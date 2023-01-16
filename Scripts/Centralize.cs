using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centralize : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += (transform.parent.position - transform.position) * 50 * Time.deltaTime;
    }
}
