﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GlobalStore : MonoBehaviour {

	public static GlobalStore instance;

	private int[]ressources = new int[300];   //Number of ressources
	public int startSize = 10;
	private int storeSize = 0;			      //Size of store

	//All text-components
	public Text storeText;
	public Text woodText;
	public Text woodText2;
	public Text stoneText;
	public Text stoneText2;


	public void Start(){
		instance = this;
		addSize(startSize);
		addRessources(Ressources.Wood, 10);
	}

	public int getNumberOfRessource(Ressources id) {
		return ressources[(int)id];
	}

	public int getNumberOfRessource(int id) {
		return ressources[id];
	}


	public void addSize(int value){
		storeSize += value;

		storeText.text = "" + storeSize;
	}


	public void addRessources(Ressources id, int value){
		int idInt = (int)id;
		ressources[idInt] += value;
		
		//Die Anzahl einer Ressource darf nicht kleiner als 0 und nicht größer als die Lagergröße sein
		if(ressources[idInt] < 0)
			ressources[idInt] = 0;
		else if(ressources[idInt] > storeSize){
			ressources[idInt] = storeSize;
		}
		
		//Actualize the text for the ressource id
		actualizeText(id);
	}


	public void actualizeText(Ressources id){
		switch(id){
			case Ressources.Wood: 
				woodText.text = "" + getNumberOfRessource(id);
				woodText2.text = "" + getNumberOfRessource(id);
				break;
			case Ressources.Stone: 
				stoneText.text = "" + getNumberOfRessource(id);
				stoneText2.text = "" + getNumberOfRessource(id);
				break;
		}
	}
}