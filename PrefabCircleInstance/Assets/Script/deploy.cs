using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deploy : MonoBehaviour {

    public GameObject B;

    float a, b, x, z;
    float r = 5;

    public float theta;

	// Use this for initialization
	void Start () {
        a = this.transform.position.x;
        b = this.transform.position.z;
        
        for (int i = 0; i < 25; i += 2)
        {
            x = Mathf.Cos(Mathf.PI / 12 * i) * r;
            z = Mathf.Sin(Mathf.PI / 12 * i) * r;

            Instantiate(B, new Vector3(x, 0, z), transform.rotation);
            Debug.Log(i + " : " + x + ", " + z);
        }
        
    }
}
