using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBall1 : MonoBehaviour
{
	public GameObject pingPong;
	public float timer, interval;
	public bool noCoolDown, noExitingBall;
	public int numberOfBallsInSpawner;

    // Start is called before the first frame update
    void Start()
	{
		noExitingBall = false;
		noCoolDown = true;
		timer = 0.0f;
		interval = 1.5f;
	}

	// Update is called once per frame
	void Update()
    {
        CheckCooldown();
		CheckForExistingBall();
		SpawnBall();
    }

	public void CheckCooldown()
	{
		if (!noCoolDown)
		{
			if (timer >= interval)
			{
				timer -= interval;
				noCoolDown = true;
			}
			else
			{
				timer += Time.deltaTime;
			}
		}
	}

	public void CheckForExistingBall()
	{
		if (numberOfBallsInSpawner == 0)
		{
			noExitingBall = true;
		}
		else
		{
			noExitingBall = false;
		}
	}

	public void SpawnBall()
	{
		if (noCoolDown && noExitingBall)
		{
			Instantiate(pingPong, transform.position, transform.rotation);
			noCoolDown = false;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("ping pong"))
		{
			numberOfBallsInSpawner++;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("ping pong"))
		{
			numberOfBallsInSpawner--;
		}
	}
}
