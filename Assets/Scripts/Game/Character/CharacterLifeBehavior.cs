using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLifeBehavior : MonoBehaviour
{
    private bool CanTakeDamage = true;

    [SerializeField] private int LifeCounter = 5;
     void OnCollisionEnter2D(Collision2D col)
    {
        if(col.otherCollider.tag == "Shot")
        {
            Damage();
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
    }

    void Damage()
    {
        if(CanTakeDamage)
        {
        LifeCounter--;
        CanTakeDamage = false;
        this.gameObject.GetComponent<Collider2D>().enabled = false;
        StartCoroutine("DamageTimer");
        }
    }
    IEnumerator DamageTimer()
    {
        yield return new WaitForSeconds(3f);
        CanTakeDamage = true;
        this.gameObject.GetComponent<Collider2D>().enabled = true;
    }

    void LifeControler()
    {
        
    }
}
