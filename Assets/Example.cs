using UnityEngine;
using UnityEngine.InputSystem;

public class Example : MonoBehaviour
{
    //InputAction es el objeto que alamacena los mapas de acciones de mi proyecto
    InputAction moveAction;
    public float velocidad = 5f;
   
    void Start()
    {

        moveAction = InputSystem.actions.FindAction("Movement"); //No puedo usar el Getcomponent con el inputaction. ya que
    }

    private void OnEnable()
       


    // Update is called once per frame
    void Update()
    {


        Vector2 moveValue = moveAction.ReadValue<Vector2>();

       
    }
}
