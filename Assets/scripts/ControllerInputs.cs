using UnityEngine;


//Capturar Inputs y enviarlos a quienes escuchan


public class ControllerInputs : MonoBehaviour
{


    private Vector2 _VetorMovement = Vector2.zero;


    void Update()
    {

        _VetorMovement.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        EventsHolder.ON_INPUTS?.Invoke(_VetorMovement);
    }
}
