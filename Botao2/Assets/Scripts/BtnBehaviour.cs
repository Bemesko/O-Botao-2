using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBehaviour : MonoBehaviour
{
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponentInParent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClicked()
    {
        Debug.Log("Clicado");
        _audioSource.PlayOneShot(_audioSource.clip);
    }
}
