using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleObject : MonoBehaviour
{
    [SerializeField] float velocity;

    private void Start()
    {
        IndicatorManager.instance.SpawnIndicator(transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += Vector3.down * velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.position += Vector3.up * velocity * Time.deltaTime;
        }
    }
}
