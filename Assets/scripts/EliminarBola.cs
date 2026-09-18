using UnityEngine;

public class EliminarBola : MonoBehaviour
{

    public GameObject objetoADesactivar;

    private void OnTriggerEnter(Collider other)
    {
        if (objetoADesactivar != null)
        {
            objetoADesactivar.SetActive(false);
        }
        Debug.Log("Has entrado");
    }


    private void OnTriggerExit(Collider other)
    {
        if (objetoADesactivar != null)
        {
            objetoADesactivar.SetActive(true);
        }
        Debug.Log("Has salido");
    }
}
