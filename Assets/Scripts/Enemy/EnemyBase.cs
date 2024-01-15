using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private int damage = 10;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log(collision.transform.name);

		var health = collision.gameObject.GetComponent<HealthBase>();

		if(health != null)
		{
			health.Damage(damage);
		}
	} 
}
