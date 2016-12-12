using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    public float minPosition = -2.15f;
    public float maxPosition = 2.15f;
    public float delayTimer = 1f;
    float _timer;

    // Use this for initialization
    void Start () {
        _timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {

        _timer -= Time.deltaTime;

        if (_timer <= 0 )
        {
            Vector3 enemyPosition = transform.position;
            enemyPosition.x = Random.Range(minPosition, maxPosition);
            
            Instantiate(enemy, enemyPosition, transform.rotation);
            _timer = delayTimer;
        }

    }
}
