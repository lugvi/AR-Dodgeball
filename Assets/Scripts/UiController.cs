using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

public Slider accuracySlider, forceSlider;

public BallDispenser ballDispenser;

private void Start()
{	
	accuracySlider.value = ballDispenser.accuracyOffset;
	forceSlider.value = ballDispenser.shotForce;
	accuracySlider.onValueChanged.AddListener((v)=>ballDispenser.accuracyOffset=v);
	forceSlider.onValueChanged.AddListener((v)=>ballDispenser.shotForce=v);
}
}
