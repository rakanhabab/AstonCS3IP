using UnityEngine;

public class ProximityAction : MonoBehaviour
{


    
    public GameObject tube1;
    public GameObject tube2;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject tube3;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject Untransformed;
    public GameObject Transformed;

    void Start(){

            tube1.SetActive(false);
            tube2.SetActive(false);
            ball1.SetActive(false);
            ball2.SetActive(false);
            Transformed.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            Debug.Log("Target object is close!");
            tube1.SetActive(true);
            tube2.SetActive(true);
            tube3.SetActive(false);
            ball1.SetActive(true);
            ball2.SetActive(true);
            ball3.SetActive(false);
            ball4.SetActive(false);
            Untransformed.SetActive(false);
            Transformed.SetActive(true);
        }
    }
    //void OnTriggerExit(Collider other){if (other.CompareTag(targetTag)){Debug.Log("Target object has moved away.");}}
}
