using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNote : MonoBehaviour
{
    public GameObject note;
    public void generate()
    {
        GameObject newNote = Instantiate(note, GameObject.Find("HomeBoard").transform);
    }
}
