using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{

#region Singleton
	public static UiController instance;

	private void Awake()
	{
		instance = this;
	}
#endregion
    public Slider accuracySlider, forceSlider;

    public BallDispenser ballDispenser;

	public Text scoreText;
	public int score = 0;

    private void Start()
    {
        accuracySlider.value = ballDispenser.accuracyOffset;
        forceSlider.value = ballDispenser.shotForce;
        accuracySlider.onValueChanged.AddListener((v) => ballDispenser.accuracyOffset = v);
        forceSlider.onValueChanged.AddListener((v) => ballDispenser.shotForce = v);
    }

    public void UpdateScore()
    {
        scoreText.text = score+"";
    }

    public void IncreaseScore(int amount=1)
    {
        score+=amount;
        UpdateScore();
    }
}
