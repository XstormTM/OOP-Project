using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_B_HumanSarface : HumanSarface
{

    float characterSpeed = 5f;
    float swarveSpeed = 0.003f;
    ControlFreak2.InputRig.Touch touch;
    void Update()
    {
        //SimpleForowardMovementOfTheCharacter(this.transform.gameObject,characterSpeed);
        //CharacterSuarvMovement(swarveSpeed,swarveSpeed,transform.gameObject);
        //CharacterSwarvMovement(touch,transform.gameObject, swarveSpeed,characterSpeed);

        if (ControlFreak2.CF2Input.touchCount > 0 && ControlFreak2.CF2Input.touchCount <= 1)
        {
            Debug.Log("Friction Starts");
            TopDownCharacterMovement(transform.gameObject, characterSpeed);
        }
    }
}
