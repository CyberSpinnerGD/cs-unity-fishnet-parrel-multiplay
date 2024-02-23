$unityTitles = @("cs_unity-main-online", "cs_unity-main-online_clone_0", "cs_unity-main-online_clone_1")

foreach ($title in $unityTitles) {
    $unityProcesses = Get-Process | Where-Object { $_.ProcessName -eq "Unity" -or $_.ProcessName -eq "UnityEditor"} # Filtra por nombre de proceso
    $process = $unityProcesses | Where-Object { $_.MainWindowTitle -like "*$title*" } | Select-Object -First 1
    if ($process -ne $null) {
        $processId = $process.Id
        Add-Type -AssemblyName Microsoft.VisualBasic
        Add-Type -AssemblyName System.Windows.Forms
        [Microsoft.VisualBasic.Interaction]::AppActivate($processId)
        Start-Sleep -Milliseconds 500 # Espera un poco para asegurar que la ventana esté activa
        [System.Windows.Forms.SendKeys]::SendWait("^p") # Simula presionar Ctrl+P
        Start-Sleep -Milliseconds 500 # Espera después de enviar la tecla
    }
    else {
        Write-Output "No se encontró el proceso con título $title"
    }
}
