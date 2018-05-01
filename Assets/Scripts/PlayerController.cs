using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
		{
            UiController.instance.IncreaseScore();
            Destroy(other.gameObject,1f);
            Debug.Log("hit");
		}
	}

}
