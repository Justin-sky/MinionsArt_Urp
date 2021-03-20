using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UIPosition : MonoBehaviour
{
    public Transform canvasTransform; //remember to set the Canvas' Transform in the inspector
    Image sImage;

    Material newMat;
    void Start()
    {
        sImage = GetComponent<Image>();
        if(newMat == null)
        {
            Material mat = Instantiate(sImage.material);
            newMat = mat;
        }
        sImage.material = newMat;
    }
    void Update()
    {
        sImage.material.SetFloat("_XOffset", canvasTransform.InverseTransformPoint(transform.position).x);
        sImage.material.SetFloat("_YOffset", canvasTransform.InverseTransformPoint(transform.position).y);
    }
}
