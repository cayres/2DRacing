using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    public float carSpeed = 10;
    public float minPosition = -2.15f;
    public float maxPosition = 2.15f;
    Vector3 _position;

    // Use this for initialization
    void Start () {
        _position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        _position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;

        _position.x = Mathf.Clamp(_position.x, minPosition, maxPosition);

        transform.position = _position;
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
