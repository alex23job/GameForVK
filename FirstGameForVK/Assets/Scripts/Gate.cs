using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] private Transform gateLeft;
    [SerializeField] private Transform gateRight;

    // Start is called before the first frame update
    void Start()
    {
        OnCenterClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLeftClick()
    {
        gateLeft.position = new Vector3(0, 1.1f, 1.2f);
        gateLeft.rotation = Quaternion.Euler(new Vector3(0, 45f, 0));
        gateRight.position = new Vector3(0.84f, 1.1f, 1.2f);
        gateRight.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    public void OnRightClick()
    {
        gateLeft.position = new Vector3(-0.84f, 1.1f, 1.2f);
        gateLeft.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        gateRight.position = new Vector3(0, 1.1f, 1.2f);
        gateRight.rotation = Quaternion.Euler(new Vector3(0, -45f, 0));
    }

    public void OnCenterClick()
    {
        gateLeft.position = new Vector3(-0.84f, 1.1f, 1.2f);
        gateLeft.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        gateRight.position = new Vector3(0.84f, 1.1f, 1.2f);
        gateRight.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}
