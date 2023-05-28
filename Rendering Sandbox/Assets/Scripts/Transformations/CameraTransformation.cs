using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransformation : Transformation
{
    public float focalLength = 1f;  // Configures distance between image and camera

    public override Matrix4x4 Matrix {
        // Orthographic camera
        //get { 
        //    Matrix4x4 matrix = new Matrix4x4();
        //    matrix.SetRow(0, new Vector4(1f, 0f, 0f, 0f));
        //    matrix.SetRow(1, new Vector4(0f, 1f, 0f, 0f));
        //    matrix.SetRow(2, new Vector4(0f, 0f, 0f, 0f));  // Drop z-axis to render
        //    matrix.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
        //    return matrix; 
        //}

        // Perspective camera
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(focalLength, 0f, 0f, 0f));
            matrix.SetRow(1, new Vector4(0f, focalLength, 0f, 0f));
            matrix.SetRow(2, new Vector4(0f, 0f, 0f, 0f));
            matrix.SetRow(3, new Vector4(0f, 0f, 1f, 0f));  // divide everything by z-coord
            return matrix;
        }
    }
}
