using UnityEngine;
using UnityEditor;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float speed = 8f;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, speed * Time.deltaTime));
        _AutoDestroy();
	}

    private void _AutoDestroy()
    {
        if (transform.position.y <= -7f)
        {
            DestroyObject(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
