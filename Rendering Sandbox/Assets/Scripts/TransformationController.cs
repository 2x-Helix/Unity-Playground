using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationController : MonoBehaviour
{
    public ScaleTransformation scaleTransform;
    public RotationTransformation rotateTransform;
    public Vector3 scaleAmount = Vector3.zero;
    public Vector3 rotateAmount = Vector3.zero;

    private int time = 0;

    void Update()
    {
        float theta = time * Mathf.Deg2Rad;
        scaleTransform.scale = new Vector3(
            scaleTransform.scale.x + (scaleAmount.x * Mathf.Sin(theta)),
            scaleTransform.scale.y + (scaleAmount.y * Mathf.Sin(theta)),
            scaleTransform.scale.z + (scaleAmount.z * Mathf.Sin(theta))
        );

        rotateTransform.rotation = new Vector3(
            rotateTransform.rotation.x + rotateAmount.x,
            rotateTransform.rotation.y + rotateAmount.y,
            rotateTransform.rotation.z + rotateAmount.z
        );
        time++;
    }
}
