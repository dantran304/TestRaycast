using UnityEngine;
using System.Collections;

public class ray : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {

            Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red);
            if(hit.collider.tag == "cube")
            {
                Debug.Log("Point to cube");
            }

            if (hit.collider.tag == "sphere")
            {
                Debug.Log("Point to sphere");
            }

            if (hit.collider.tag == "capsule")
            {
                Debug.Log("Point to capsule");
            }

            if (hit.collider.tag == "cylinder")
            {
                Debug.Log("Point to cylinder");
            }

        }
    }
}
