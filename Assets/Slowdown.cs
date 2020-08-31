using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowdown : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Time.timeScale = 0.5f;
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		Time.timeScale = 1f;
	}
}
