using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleport : MonoBehaviour
{
    public void Transition()
    {
        SceneManager.LoadScene(3);
    }

}
