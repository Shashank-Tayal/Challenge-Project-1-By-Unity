using UnityEngine;

public class PropellerSpinningMotionX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 2.210115F, 3.643463F);
    public float rotationSpeed = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);

    }
}
