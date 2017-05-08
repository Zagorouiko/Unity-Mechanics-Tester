using UnityEngine;
using System.Collections;

public class RayViewer : MonoBehaviour
{

    public float weaponRange = 500f;
    public Transform gunTip;

    void Update()
    {
        Vector3 lineOrigin = gunTip.position;
        Debug.DrawRay(lineOrigin, -gunTip.forward * weaponRange, Color.green);
    }
}
