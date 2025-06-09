using UnityEngine;

public class coincollection : MonoBehaviour
{
    
    private int chess = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "chess")
        {
            chess++;
            Debug.Log(chess);
            Destroy(other.gameObject);
        }
    }


}
