using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Door : MonoBehaviour
{
    public float rotation;
    public void OpenDoor()
    {
        transform.Rotate(0.0f, rotation,0.0f, Space.Self);
    }
}
