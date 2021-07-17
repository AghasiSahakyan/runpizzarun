using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject levelsPanel;

    private void Start()
    {
        levelsPanel.SetActive(false);
    }
}
