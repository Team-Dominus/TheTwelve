using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �⺻ ������ ������ ���� ������Ʈ

namespace XII.Components
{
    public class XII_BaseAttackComponent : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position + new Vector3(1.0f,0f,0f),Vector3.one);

        }

        public void Attack()
        {
            Debug.Log("Attack");
            Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(transform.position + new Vector3(1.0f, 0f, 0f),Vector3.one, 0);

            foreach (Collider2D collider in collider2Ds)
            {
                if (collider.gameObject.CompareTag("Enemy"))
                {
                    Debug.Log("Hit Enemy: " + collider.gameObject.name);
                    this.gameObject.GetComponent<XII_CombatComponent>().SendDamage(collider);
                    // ���⿡ ������ �������� �ִ� ������ �߰��� �� �ֽ��ϴ�.
                    // ��: collider.GetComponent<Enemy>().TakeDamage(damageAmount);
                }
            }
        }
    }
    
}
