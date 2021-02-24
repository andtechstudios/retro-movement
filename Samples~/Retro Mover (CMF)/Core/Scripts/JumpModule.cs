/*
 *	Copyright (c) 2020, AndrewMJordan
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using UnityEngine;
using static CMF.AdvancedWalkerController;

namespace Andtech.RetroMovement {

	public class JumpModule : MonoBehaviour {
		[SerializeField]
		private AndtechWalkerController walkerController;
		[SerializeField]
		private float coyoteTime = 1.0F;
		[SerializeField]
		private int maxJumpCount = 1;

		private float lastGroundTime = 0.0F;
		private int jumps = 0;

		protected virtual void Reset() {
			walkerController = GetComponentInParent<AndtechWalkerController>();
		}

		protected virtual void Awake() {
			walkerController.ReadCanJump = CanJump;
			walkerController.OnLand += velocity => ResetJumps();
			walkerController.OnJump += velocity => jumps--;
		}

		protected virtual void FixedUpdate() {
			if (walkerController.CurrentControllerState == ControllerState.Grounded) {
				lastGroundTime = Time.fixedTime;
			}
		}

		protected virtual bool CanJump() {
			if (jumps <= 0)
				return false;

			return walkerController.CurrentControllerState == ControllerState.Grounded || walkerController.CurrentControllerState == ControllerState.Falling && (Time.fixedTime - lastGroundTime < coyoteTime);
		}

		private void ResetJumps() {
			lastGroundTime = Time.fixedTime;
			jumps = maxJumpCount;
		}
	}
}
