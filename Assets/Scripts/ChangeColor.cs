using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Blue()
    {
        GetComponent<MeshRenderer>().material.DOColor(Color.blue, 2);
    }

    public void Green()
    {
        GetComponent<MeshRenderer>().material.DOColor(Color.green, 2);
    }

}
