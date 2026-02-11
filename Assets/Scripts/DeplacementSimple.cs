using UnityEngine;

public class DeplacementSimple : MonoBehaviour
{
    public Vector2 deplacement;
    
    public float vitesseX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // changer la position de mon transform
        // transform.position = transform.position + (Vector3)deplacement;
        transform.position += new Vector3(vitesseX, 0, 0) * Time.deltaTime;
    }
}
