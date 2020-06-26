using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	bool isStuck;

	public float speed;

	Rigidbody2D rb;

	GameManager gm;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		if (isStuck == false)
		{
			rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Spinner"))
		{
			transform.SetParent(collision.transform);
			//collision.GetComponent<Spinner>().speed += 5;
			//collision.GetComponent<Spinner>().speed *= -1;
			isStuck = true;

			FindObjectOfType<GameManager>().ScoreCounter();
		}
		else if (collision.CompareTag("Ball"))
		{
			FindObjectOfType<GameManager>().GameEnd();
		}
	}
}
