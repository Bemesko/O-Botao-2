using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject particleFx;
    [SerializeField]
    private int maxClickCount = 5;

    private ButtonAnimator _buttonAnimator;
    private AudioSource _audioSource;
    private int _clickCount;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _buttonAnimator = GetComponent<ButtonAnimator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonClicked()
    {
        if (_clickCount > maxClickCount)
            Destroy(gameObject);
        Debug.Log("Clicado");
        _audioSource.PlayOneShot(_audioSource.clip);
        Instantiate(particleFx, transform.position, transform.rotation);
        _buttonAnimator.AnimateButton();
        _clickCount++;
    }
}
