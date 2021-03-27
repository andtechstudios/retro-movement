/*
 *	Copyright (c) 2021, AndtechGames
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using CMF;
using System;
using UnityEngine;

namespace Andtech.RetroMovement {

	public class AndtechWalkerController : AdvancedWalkerController {
		public ControllerState CurrentControllerState => currentControllerState;

		/// <value>
		/// How should the movement direction be computed for the current frame?
		/// </value>
		public Func<Vector3> ReadMovementDirection { get; set; }
		/// <value>
		/// How should the movement velocity be computed for the current frame?
		/// </value>
		public Func<Vector3> ReadMovementVelocity { get; set; }
		/// <value>
		/// How should we determine whether the controller can jump during the current frame?
		/// </value>
		public Func<bool> ReadCanJump { get; set; }

		protected override Vector3 CalculateMovementDirection() => ReadMovementDirection?.Invoke() ?? base.CalculateMovementDirection();

		protected override Vector3 CalculateMovementVelocity() => ReadMovementVelocity?.Invoke() ?? base.CalculateMovementVelocity();

		protected override bool IsJumpKeyPressed() => (ReadCanJump?.Invoke() ?? true) && base.IsJumpKeyPressed();
	}
}
