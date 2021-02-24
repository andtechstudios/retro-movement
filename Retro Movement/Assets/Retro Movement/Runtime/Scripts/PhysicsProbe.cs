using UnityEngine;

namespace Andtech.RetroMovement {

	public interface ITransformProbe {
		/// <summary>
		/// The world position.
		/// </summary>
		Vector3 Position { get; }
		/// <summary>
		/// The world rotation.
		/// </summary>
		Quaternion Rotation { get; }
		/// <summary>
		/// The world scale.
		/// </summary>
		Vector3 Scale { get; }
	}

	public interface IOrientationProbe {
		/// <summary>
		/// The reference frame for this body.
		/// </summary>
		Quaternion Orientation { get; }
	}

	public interface IBodyProbe {
		/// <summary>
		/// Is the body grounded currently?
		/// </summary>
		bool IsGrounded { get; }
		/// <summary>
		/// The world velocity.
		/// </summary>
		Vector3 Velocity { get; }
		/// <summary>
		/// The angular velocity.
		/// </summary>
		Vector3 AngularVelocity { get; }
	}

	public abstract class PhysicsProbe : MonoBehaviour, ITransformProbe, IOrientationProbe, IBodyProbe {

		#region INTERFACE
		public abstract Vector3 Position { get; }
		public abstract Quaternion Rotation { get; }
		public abstract Vector3 Scale { get; }

		public abstract Quaternion Orientation { get; }

		public abstract Vector3 AngularVelocity { get; }
		public abstract Vector3 Velocity { get; }
		public abstract bool IsGrounded { get; }
		#endregion
	}
}
