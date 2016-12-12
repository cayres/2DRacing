using UnityEngine;
using System.Collections;

public class TrackController : MonoBehaviour {

    public float speed = 1;
    Vector2 _offset;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        _offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = _offset;
	}
}
