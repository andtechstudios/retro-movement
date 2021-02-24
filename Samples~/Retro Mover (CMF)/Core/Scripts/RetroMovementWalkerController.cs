/*
 *	Copyright (c) 2020, AndrewMJordan
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using CMF;
using UnityEngine;

namespace Andtech.RetroMovement {

	public class RetroMovementWalkerController : AndtechWalkerController {
		[Header("Retro Movement Settings")]
		[SerializeField]
		private new Rigidbody rigidbody;
		[SerializeField]
		private CameraController cameraController;
		private VelocityCalculator velocityCalculator;

		protected override void Setup() {
			base.Setup();

			rigidbody = GetComponentInChildren<Rigidbody>();
			velocityCalculator = new VelocityCalculator() {
				IsRunningStrategy = () => (characterInput as RetroCharacterInput)?.IsSprintKeyPressed() ?? false,
				CurrentVelocityStrategy = GetPlanarVelocity,
				DesiredVelocityStrategy = CalculateDesiredVelocity
			};
		}

		protected override Vector3 CalculateMovementVelocity() => velocityCalculator.CalculateVelocity(Time.deltaTime);

		private Vector3 GetPlanarVelocity() => Vector3.ProjectOnPlane(rigidbody.velocity, cameraController.GetUpDirection());

		private Vector3 CalculateDesiredVelocity() {
			var x = characterInput.GetHorizontalMovementInput();
			var y = characterInput.GetVerticalMovementInput();
			var localVelocity = velocityCalculator.Transform(x, y);
			var velocity =
				localVelocity.x * cameraController.GetStrafeDirection()
				+ localVelocity.z * cameraController.GetFacingDirection();

			return velocity;
		}
	}
}
