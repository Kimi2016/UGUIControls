﻿using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;

namespace UGUIControls
{
	public class PinchGestureRecognizer : GestureRecognizer
	{


		/// <summary>
		/// The scale factor relative to the points of the two touches in screen coordinates.
		/// </summary>
		public float scale;

		/// <summary>
		/// The velocity of the pinch in scale factor per second. (read-only)
		/// </summary>
		public float velocity;

	}
}
