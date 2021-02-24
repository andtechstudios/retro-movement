/*
 *	Copyright (c) 2020, AndrewMJordan
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using UnityEngine;

namespace Andtech.RetroMovement {

	public static class Constants {
		public const float FRICTION_CLASSIC_RAW = 0.90625F;
		public const float MOVEFACTOR_CLASSIC = 1.0F / 32.0F;
		public const float FPS_CLASSIC = 35.0F;
		public const float TIMESTEP_CLASSIC = 1.0F / FPS_CLASSIC;
		public const float MAXSPEED_CLASSIC = 30.0F;
		public const float DOOM2UNITY_SPEED = METERPERUNIT * FPS_CLASSIC;

		public static readonly float FrictionClassic = Mathf.Pow(FRICTION_CLASSIC_RAW, 1.0F / TIMESTEP_CLASSIC);
		public static readonly float MoveFactorClassic = MOVEFACTOR_CLASSIC * (1.0F / TIMESTEP_CLASSIC);

		/// <summary>
		/// How many meters per 1 classic map unit.
		/// </summary>
		public const float METERPERUNIT = 1.0F / 32.0F;
		/// <summary>
		/// How many classic map units per 1 meter.
		/// </summary>
		public const float UNITPERMETER = 1.0F / METERPERUNIT;
	}
}
