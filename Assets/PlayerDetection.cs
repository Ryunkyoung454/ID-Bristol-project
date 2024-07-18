using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
   public GameObject plane;
    private bool isTriggered = false;

    void Start()
    {
        plane.SetActive(false);  // Ensure the plane starts inactive
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered)
        {
            isTriggered = true;
            plane.SetActive(true);
            StartCoroutine(HidePlaneAfterDelay());
        }
    }

    private IEnumerator HidePlaneAfterDelay()
    {
        yield return new WaitForSeconds(3);
        plane.SetActive(false);
        isTriggered = false;  // Reset the trigger state
    }
}
