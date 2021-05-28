using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // parameters
    [SerializeField] int breakableBlocks;

    // cached references
    SceneLoader levelSceneLoader;

    private void Start()
    {
        levelSceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            levelSceneLoader.LoadNextScene();
        }
    }
}
