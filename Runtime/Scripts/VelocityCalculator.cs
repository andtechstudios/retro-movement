/*
 *	Copyright (c) 2021, AndtechGames
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using System;
using UnityEngine;

namespace Andtech.RetroMovement {

	[Serializable]
	public class VelocityCalculator {
		/// <summary>
		/// Lateral movement speed (unit / s)
		/// </summary>
		[SerializeField]
		private float maxLateralMoveSpeed = 40.0F;
		/// <summary>
		/// Forward movement speed (unit / s)
		/// </summary>
		[SerializeField]
		private float maxForwardMoveSpeed = 50.0F;
		public Func<bool> IsRunningStrategy { get; set; }
		public Func<Vector3> CurrentVelocityStrategy { get; set; }
		public Func<Vector3> DesiredVelocityStrategy { get; set; }

		private bool IsRunning => IsRunningStrategy?.Invoke() ?? false;
		private Vector3 CurrentVelocity => CurrentVelocityStrategy?.Invoke() ?? Vector3.zero;
		private Vector3 DesiredVelocity => DesiredVelocityStrategy?.Invoke() ?? Vector3.zero;

		public VelocityCalculator(float maxLateralMoveSpeed = 40.0F, float maxForwardMoveSpeed = 50.0F) {
			this.maxLateralMoveSpeed = maxLateralMoveSpeed * Constants.DOOM2UNITY_SPEED;
			this.maxForwardMoveSpeed = maxForwardMoveSpeed * Constants.DOOM2UNITY_SPEED;
		}

		/// <summary>
		/// Converts the inputs into a (local) velocity vector.
		/// </summary>
		/// <param name="x">The lateral input value.</param>
		/// <param name="y">The forward input value.</param>
		/// <returns>The local velocity vector.</returns>
		public Vector3 Transform(float x, float y) {
			var velocity = new Vector3 {
				x = x * maxLateralMoveSpeed,
				z = y * maxForwardMoveSpeed
			};
			if (!IsRunning)
				velocity /= 2.0F;

			return velocity;
		}

		public Vector3 CalculateVelocity(float timestep) {
			var velocity = CurrentVelocity;
			var desiredVelocity = DesiredVelocity;

			var frameFriction = Mathf.Pow(Constants.FrictionClassic, timestep);
			var leftoverVelocity = velocity * frameFriction;
			var frameMoveFactor = Constants.MoveFactorClassic * timestep;
			var thrust = desiredVelocity * frameMoveFactor;
			velocity = leftoverVelocity + thrust;

			return velocity;
		}
	}
}
