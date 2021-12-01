using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarveMovement : MonoBehaviour
{

    private ControlFreak2.InputRig.Touch touch;
    bool isTouch,isBlance;
    float playerSpeed;

    void Update()
    {
        if (ControlFreak2.CF2Input.touchCount > 0 )
        {
            touch = ControlFreak2.CF2Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                    transform.position = new Vector3(
                        transform.position.x + touch.deltaPosition.x * .005f,
                        transform.position.y,
                        transform.position.z);
            }

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.phase >= 0)
                {
                    //Call The Simple Movement Function Here........
                }
                
            }
        }
    }

    void SwarvMovement(ControlFreak2.InputRig.Touch touch, GameObject character,float swarvSpeed , HumanSarface mathod)
    {
        if(ControlFreak2.CF2Input.touchCount > 0)
        {
            touch = ControlFreak2.CF2Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                character.transform.position = new Vector3(
                        character.transform.position.x + touch.deltaPosition.x * .005f,
                        character.transform.position.y,
                        character.transform.position.z
                    );
            }
            //if (touch.phase == TouchPhase.Began)
            //{
            //    if (touch.phase >= 0)
            //    {
            //        mathod.SimpleForowardMovementOfTheCharacter(character,);
            //    }

            //}
        }
    }

}
