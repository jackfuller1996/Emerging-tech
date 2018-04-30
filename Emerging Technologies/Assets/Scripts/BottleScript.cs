using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class BottleScript : MonoBehaviour {

    float timeLeft = 5.0f;
    public int scoreValue = 10;

    void Start()
    {
    }
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        HandModel hand = collision.gameObject.GetComponentInParent<HandModel>();
        if (hand != null)
        {
            ScoreManager.score += scoreValue;
            Destroy(this.gameObject);
        }
    }
}
