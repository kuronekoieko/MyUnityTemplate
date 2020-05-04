﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Unity CameraのcullingMaskについて
http://shinriyo.hateblo.jp/entry/20130208/p3
*/
public class UICameraController : MonoBehaviour
{
    [SerializeField] ParticleSystem confettiL;
    [SerializeField] ParticleSystem confettiR;

    void Start()
    {
        Camera uiCam = GetComponent<Camera>();
        uiCam.cullingMask |= 1 << LayerMask.NameToLayer("Confetti");
    }

    void Update()
    {
    }

    public void PlayConfetti()
    {
        confettiL.Play();
        confettiR.Play();
        SoundManager.i.PlayOneShot(1);
    }
}