using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovimentControler : MonoBehaviour
{
    [SerializeField] float standardSpeed;
    [SerializeField] float SpeedX;
    [SerializeField] float SpeedY;
    void Start()
    {

    }

    void Update()
    {
        Moviment();
    }

    void Moviment()
    {
        SpeedX = Input.GetAxis("Horizontal") * standardSpeed;
        SpeedY = Input.GetAxis("Vertical") * standardSpeed;
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(SpeedX,SpeedY);
        
    }
}
