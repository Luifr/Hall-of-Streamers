﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeCarisma : Investimentos {

	// Use this for initialization
	protected override void Start () {
		base.Start();
		id = Tipo.Camera;
		isEquipment = false;
		custo = new int[] {30,80,200};
		tempo = new int[] {3,5,5};
	}
	
	public override void Efeito(){
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
