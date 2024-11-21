using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountsBalls : MonoBehaviour
{
    [SerializeField] private string nameTag;
    [SerializeField] private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(nameTag))
        {
            gm.AddScore(1);
        }
        other.gameObject.tag = "Untagged";
        Destroy(other.gameObject, 1f);
    }
}
