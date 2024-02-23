#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using ParrelSync;
using FishNet.Managing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using FishNet.Example;

public class CustomArgumentExample : MonoBehaviour
{
    void Start()
    {
        NetworkHudCanvases hudCanvases = FindObjectOfType<NetworkHudCanvases>();
        if (hudCanvases != null)
        {
            if (ClonesManager.IsClone())
            {
                Debug.Log("This is a clone project.");
                
                hudCanvases.SetAutoStartType(NetworkHudCanvases.AutoStartType.Client);           
            }
            else
            {
                Debug.Log("This is the original project.");
                
                hudCanvases.SetAutoStartType(NetworkHudCanvases.AutoStartType.Server); // Ejemplo, ajusta según sea necesario.
            }
        }
        else
        {
            Debug.LogError("NetworkHudCanvases not found.");
        }
    }

    
}
#endif