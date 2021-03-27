using CMF;
using UnityEngine;

namespace Andtech.RetroMovement {

	public class CMFPhysicsProbe : PhysicsProbe {
		[SerializeField]
		private Controller controller;
		[SerializeField]
		private new Rigidbody rigidbody;
		[SerializeField]
		private CameraController cameraController;

		#region INTERFACE
		public override Vector3 Position => rigidbody.position;
		public override Quaternion Rotation => rigidbody.rotation;
		public override Vector3 Scale => rigidbody.transform.lossyScale;

		public override Quaternion Orientation => Quaternion.LookRotation(cameraController.GetFacingDirection(), cameraController.GetUpDirection());

		public override Vector3 Velocity => rigidbody.velocity;
		public override Vector3 AngularVelocity => rigidbody.angularVelocity;
		public override bool IsGrounded => controller.IsGrounded();
		#endregion
	}
}
