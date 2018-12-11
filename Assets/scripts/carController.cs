using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

    public float carSpeed;
    Vector3 position;
    public float maxPos = 2.2f;

    // Use this for initialization
    void Start () {
		position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "EnemyCar")
        {
            Destroy(gameObject);
        }
    }


}
