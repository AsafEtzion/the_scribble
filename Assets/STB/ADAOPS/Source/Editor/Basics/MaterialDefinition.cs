﻿using UnityEngine;
using System.Collections;
using System;

namespace STB.ADAOPS
{
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Class: MaterialDefinition
	/// # A class to define materials
	/// </summary>
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	[Serializable]
	public class MaterialDefinition
	{
		// public
		public Material material;
		public string path = "NOT_DEFINED";
	}
}