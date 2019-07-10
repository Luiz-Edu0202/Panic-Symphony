using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovimentControler : MonoBehaviour
{
    [SerializeField] float standardSpeed;
    //this variable is what the program uses as default for speed
    [SerializeField] float SpeedX;
    //This variable is the speed of X axis
    [SerializeField] float SpeedY;
        //This variable is the speed of Y axis
    void Update()
    {
        Moviment();
    }
    // Update is called once per frame
    void Moviment()
    {
        SpeedX = Input.GetAxis("Horizontal") * standardSpeed;
        /*The velocity on the x-axis is multiplication 
        of the return of the horizontal get axis method and the standard velocity*/
        SpeedY = Input.GetAxis("Vertical") * standardSpeed;
        /* The velocity on the Y-axis is multiplication 
        of the return of the Vertival get axis method and the standard velocity*/
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(SpeedX,SpeedY);
        //This method set the velocity(velocity of the Componet Rigidbody2D) to the two velocitys (Speed x, Speed Y)
    }
    //This method do the moviment of the character
}
