using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Compass : MonoBehaviour
{
    public Transform Player;
    Vector3 dir;
    private void Update()
    {
        dir.z = Player.eulerAngles.y;
        transform.localEulerAngles = dir;
    }
}