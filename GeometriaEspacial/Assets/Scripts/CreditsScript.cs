using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour
{
    float h;
    float v;
    void Start()
    {

    }
    void Update()
    {
        h = Input.GetAxis("Mouse X") * 5;
        v = Input.GetAxis("Mouse Y") * 5;
        if (Input.GetMouseButton(0))
        {
            this.transform.eulerAngles += new Vector3(0f, -h, v);
        }
    }
}