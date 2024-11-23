using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class UnityJs : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void UnityPluginRequestJs(int value);

    [DllImport("__Internal")]
    private static extern void UnityPluginRequestAvatar();

    [SerializeField] private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("GetAvatar", 0.3f);
    }

    private void GetAvatar()
    {
        UnityPluginRequestAvatar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RequestJs()
    {
        UnityPluginRequestJs(gm.Score);
    }

    public void ResponseFromJsAvatar(string nm)
    {
        gm.ViewAvatar(nm);
    }

    public void ResponseOk()
    {
        gm.ViewDebug("OK !!!");
    }

    public void ResponseError()
    {
        gm.ViewDebug("ERROR");
    }
}
