using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class MultiPlay : MonoBehaviour
{
    [MenuItem("Multi-Play/RUN %#m")]
    public static void RunMultiPlay()
    {
        
        string relativePath = "Editor/mp.ps1";

        // Construye la ruta absoluta
        string scriptPath = System.IO.Path.Combine(Application.dataPath, relativePath);

        // Ejecuta el script de PowerShell
        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            FileName = "powershell.exe",
            Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"",
            UseShellExecute = false
        };
        Process process = new Process() { StartInfo = startInfo };
        process.Start();
    }
}
