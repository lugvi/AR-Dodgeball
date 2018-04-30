using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
		{
			//Time.timeScale = 0;
            Debug.Log("hit");
		}
	}

}
