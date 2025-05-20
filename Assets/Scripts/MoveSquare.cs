using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public float speed;
    public Transform maxDistance;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        SetStartPosition(transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movement = movement.normalized;

        transform.position += (Vector3)(movement * (speed * Time.deltaTime));

        float distance = Vector3.Distance(transform.position, maxDistance.position); // se uso sqrMagnitude evito la radice quadrata > piu efficiente
        Debug.Log("Distanza dall'obiettivo: " + distance);
        if (distance < 0.1f)
        {
            transform.position = GetStartPosition();
        }


    }

    public Vector3 GetStartPosition() => startPosition;
    public void SetStartPosition(Vector3 startPosition) => this.startPosition = startPosition;
    
 
}