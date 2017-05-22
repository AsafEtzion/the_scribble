﻿using UnityEngine;
using System.Collections;

namespace STB.ADAOPS
{
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	/// <summary>
	/// Class: MeatPiece
	/// # A class to handle meat pieces
	/// </summary>
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	public class MeatPiece : DirtyObject
	{
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		/// <summary>
		/// Start
		/// # Start the class and set some values
		/// </summary>
		///////////////////////////////////////////////////////////////////////////////////////////////////////
		void Start ()
		{
			continuousMode = true;
			destroyTime = 6;
			scaleMultiplierRange = new Vector2 (1, 2);
			rotationRange = new Vector2 (0, 360);
			timeBetweenDecalCreations = 1;
		}
	}
}