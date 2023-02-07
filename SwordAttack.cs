using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider2D swordCollider;

    public float swordrange = 3f;
    public float damage = 3;
   
    Vector2 rightAttackOffset;

    public void Start(){
        rightAttackOffset = transform.position;
    }


    public void AttackRight(){
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }
    public void AttackLeft(){
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x*-1, rightAttackOffset.y);
    }
    public void StopAttack(){
        swordCollider.enabled = false;
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null)
            {
                Vector3 parentPosition = gameObject.GetComponentInParent<Transform>().position;
           //     Vector2 direction = (Vector2)(other.gameObject.transform.position - parentPosition).normalized;
                enemy.TakeDamage(damage, parentPosition, other.gameObject.transform.position, swordrange);
                
            }
        }
    
    }


   
}
