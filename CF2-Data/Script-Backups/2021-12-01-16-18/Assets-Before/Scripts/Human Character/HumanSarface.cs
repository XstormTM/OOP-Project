using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanSarface : MonoBehaviour
{
    #region All Types Of Character Movement.......!!

    public void SimpleForowardMovementOfTheCharacter(GameObject character,float speed)
    {
        character.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void CharacterSwarvMovement(Touch touch, GameObject character, float swarvSpeed,float characterSpeed)
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                character.transform.position = new Vector3(
                        character.transform.position.x + touch.deltaPosition.x * swarvSpeed,
                        character.transform.position.y,
                        character.transform.position.z
                    );
            }
                    SimpleForowardMovementOfTheCharacter(character,characterSpeed);
        }
    }
    public void CharacterButtonMovement(GameObject character,float speed)
    {
        //Use OnButtonDown Event Into The Editor.....
        SimpleForowardMovementOfTheCharacter(character,speed);
    }
    public void TopDownCharacterMovement(GameObject character,float playerSpeed)
    {
        float inputX = ControlFreak2.CF2Input.GetAxis("Horizontal") * playerSpeed;
        float inputY = ControlFreak2.CF2Input.GetAxis("Vertical") * playerSpeed;
        Vector3 direction = new Vector3(inputX, 0, inputY).normalized;
        Vector3 lookAtPosition = character.transform.position + direction;
        transform.LookAt(lookAtPosition);
        character.transform.Translate(direction * playerSpeed, Space.World);
    }

    #endregion
}
