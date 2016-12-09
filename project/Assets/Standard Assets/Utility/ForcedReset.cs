using System;
using UnityEngine;
<<<<<<< Updated upstream
using UnityEngine.SceneManagement;
=======
>>>>>>> Stashed changes
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof (GUITexture))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
<<<<<<< Updated upstream
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
=======
            Application.LoadLevelAsync(Application.loadedLevelName);
>>>>>>> Stashed changes
        }
    }
}
