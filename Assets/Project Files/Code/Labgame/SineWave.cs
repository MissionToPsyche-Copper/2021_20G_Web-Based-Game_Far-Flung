using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWave : MonoBehaviour
{
    public Vector3 lineStart;
    public Vector3 lineEnd;
    public LineRenderer wave;
    public float lineWidth;

    // Start is called before the first frame update
    void Start()
    {
        wave = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
