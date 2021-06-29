using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterSelect : MonoBehaviour
{
    [SerializeField] int level;
    public void GoTo()
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }

}
