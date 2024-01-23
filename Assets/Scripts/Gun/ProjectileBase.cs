using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Vector3 direction;
    public float timetToDestroy = 2f;
    public float side = 1;
    public int damageAmount = 1;

    private void Awake()
    {
        Destroy(gameObject, timetToDestroy);
    }

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime * side);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Adicione mensagens de depura��o para verificar a detec��o de colis�o
        Debug.Log("Colis�o detectada com: " + collision.transform.name);

        var enemy = collision.transform.GetComponent<EnemyBase>();

        if (enemy != null)
        {
            enemy.Damage(damageAmount);
            Destroy(gameObject);
        }
    }
}
