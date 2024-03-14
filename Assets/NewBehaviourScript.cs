using UnityEngine;

public class OrbitMotion : MonoBehaviour
{
    public Transform center; 
    public float orbitSpeed = 10.0f; 
    public float orbitRadius = 10.0f; 

    private void Start()
    {
        
        if (center != null)
        {
            transform.position = (transform.position - center.position).normalized * orbitRadius + center.position;
        }
    }

    void Update()
    {
        if (center != null)
        {
            
            transform.RotateAround(center.position, Vector3.up, orbitSpeed * Time.deltaTime);

            
            transform.position = (transform.position - center.position).normalized * orbitRadius + center.position;
        }
    }
}
