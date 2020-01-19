using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveSphere : MonoBehaviour {

    public Material mat;
    public float increment = 0.1f;
    private float amt = 0;

    private void Start() {
        //mat = GetComponent<Renderer>().material;
    }

    private void Update() {
        //mat.SetFloat("_DissolveAmount", Mathf.Sin(Time.time) / 2 + 0.5f);
        
        if (amt >= 1f)
        {
            amt = 1f;
        }
        else { amt += Time.deltaTime * increment; }
        mat.SetFloat("_DissolveAmount", amt);
    }
}