using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDispenser : MonoBehaviour {

	public GameObject ballPrefab;

	[Range(0,1000)]
	public float shotForce;
	[Range(0,1000)]
	public float accuracyOffset;
	private void Start()
	{
		InvokeRepeating("Shoot",1f,0.5f);
	}
	void Shoot()
	{
		Rigidbody ballRB = Instantiate(ballPrefab,transform.position,Quaternion.identity).GetComponent<Rigidbody>();
		Destroy(ballRB.gameObject,3f);
		Vector3 campos = Camera.main.transform.position;
		Vector3 targetPos = new Vector3(campos.x+Random.Range(-(10/accuracyOffset)+1,(10/accuracyOffset)-1),
										campos.y+Random.Range(-(10/accuracyOffset)+1,(10/accuracyOffset)-1),
										campos.z+Random.Range(-(10/accuracyOffset)+1,(10/accuracyOffset)-1));
		ballRB.AddForce((targetPos - transform.position).normalized*shotForce,ForceMode.Impulse);
	}

}
