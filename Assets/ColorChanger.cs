using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _colorTo;
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    private void Update()
    {
        ChangeColorTo();
    }
    public void ChangeColorTo()
    {
        _image.color = _colorTo;
    }
}
