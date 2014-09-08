using UnityEngine;

public class ColliderIsHitExtention : MonoBehaviour {

	public static bool IsHit(Collider lhs, Collider rhs) {
		switch (((int)ColliderTypeOf(lhs) << 16) | (int)ColliderTypeOf(rhs)) {
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.BoxCollider:				throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.SphereCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.CapsuleCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.CharacterController:		throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.MeshCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.TerrainCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.WheelCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.UnknownCollider:				throw new UnknownColliderException();
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.BoxCollider:					return IsHit((BoxCollider)lhs, (BoxCollider)rhs);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.SphereCollider:				return IsHit((BoxCollider)lhs, (SphereCollider)rhs);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.CapsuleCollider:				return IsHit((BoxCollider)lhs, (CapsuleCollider)rhs);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.CharacterController:			return IsHit((BoxCollider)lhs, (CharacterController)rhs);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((BoxCollider)lhs, (MeshCollider)rhs);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.TerrainCollider:				return IsHit((BoxCollider)lhs, (TerrainCollider)rhs);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.WheelCollider:				return IsHit((BoxCollider)lhs, (WheelCollider)rhs);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((SphereCollider)lhs, (BoxCollider)rhs);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((SphereCollider)lhs, (SphereCollider)rhs);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((SphereCollider)lhs, (CapsuleCollider)rhs);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((SphereCollider)lhs, (CharacterController)rhs);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((SphereCollider)lhs, (MeshCollider)rhs);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((SphereCollider)lhs, (TerrainCollider)rhs);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.WheelCollider:			return IsHit((SphereCollider)lhs, (WheelCollider)rhs);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((CapsuleCollider)lhs, (BoxCollider)rhs);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((CapsuleCollider)lhs, (SphereCollider)rhs);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((CapsuleCollider)lhs, (CapsuleCollider)rhs);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((CapsuleCollider)lhs, (CharacterController)rhs);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.MeshCollider:			return IsHit((CapsuleCollider)lhs, (MeshCollider)rhs);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((CapsuleCollider)lhs, (TerrainCollider)rhs);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.WheelCollider:			return IsHit((CapsuleCollider)lhs, (WheelCollider)rhs);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.UnknownCollider:		throw new UnknownColliderException();
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.BoxCollider:			return IsHit((CharacterController)lhs, (BoxCollider)rhs);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.SphereCollider:		return IsHit((CharacterController)lhs, (SphereCollider)rhs);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.CapsuleCollider:		return IsHit((CharacterController)lhs, (CapsuleCollider)rhs);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.CharacterController:	return IsHit((CharacterController)lhs, (CharacterController)rhs);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.MeshCollider:		return IsHit((CharacterController)lhs, (MeshCollider)rhs);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.TerrainCollider:		return IsHit((CharacterController)lhs, (TerrainCollider)rhs);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.WheelCollider:		return IsHit((CharacterController)lhs, (WheelCollider)rhs);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((MeshCollider)lhs, (BoxCollider)rhs);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.SphereCollider:				return IsHit((MeshCollider)lhs, (SphereCollider)rhs);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((MeshCollider)lhs, (CapsuleCollider)rhs);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((MeshCollider)lhs, (CharacterController)rhs);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((MeshCollider)lhs, (MeshCollider)rhs);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((MeshCollider)lhs, (TerrainCollider)rhs);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.WheelCollider:				return IsHit((MeshCollider)lhs, (WheelCollider)rhs);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((TerrainCollider)lhs, (BoxCollider)rhs);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((TerrainCollider)lhs, (SphereCollider)rhs);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((TerrainCollider)lhs, (CapsuleCollider)rhs);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((TerrainCollider)lhs, (CharacterController)rhs);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.MeshCollider:			return IsHit((TerrainCollider)lhs, (MeshCollider)rhs);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((TerrainCollider)lhs, (TerrainCollider)rhs);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.WheelCollider:			return IsHit((TerrainCollider)lhs, (WheelCollider)rhs);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((WheelCollider)lhs, (BoxCollider)rhs);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((WheelCollider)lhs, (SphereCollider)rhs);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((WheelCollider)lhs, (CapsuleCollider)rhs);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((WheelCollider)lhs, (CharacterController)rhs);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((WheelCollider)lhs, (MeshCollider)rhs);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((WheelCollider)lhs, (TerrainCollider)rhs);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.WheelCollider:				return IsHit((WheelCollider)lhs, (WheelCollider)rhs);
		default: throw new System.NotImplementedException();
		}
	}

	public static bool IsHit(BoxCollider lhs, BoxCollider rhs) {
		return false;
	}

	public static bool IsHit(BoxCollider lhs, SphereCollider rhs) {
		return false;
	}

	public static bool IsHit(BoxCollider lhs, CapsuleCollider rhs) {
		return false;
	}

	public static bool IsHit(BoxCollider lhs, CharacterController rhs) {
		return false;
	}

	public static bool IsHit(BoxCollider lhs, MeshCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(BoxCollider lhs, TerrainCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(BoxCollider lhs, WheelCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(SphereCollider lhs, BoxCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(SphereCollider lhs, SphereCollider rhs) {
		return false;
	}

	public static bool IsHit(SphereCollider lhs, CapsuleCollider rhs) {
		return false;
	}

	public static bool IsHit(SphereCollider lhs, CharacterController rhs) {
		return false;
	}

	public static bool IsHit(SphereCollider lhs, MeshCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(SphereCollider lhs, TerrainCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(SphereCollider lhs, WheelCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CapsuleCollider lhs, BoxCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CapsuleCollider lhs, SphereCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CapsuleCollider lhs, CapsuleCollider rhs) {
		return false;
	}

	public static bool IsHit(CapsuleCollider lhs, CharacterController rhs) {
		return false;
	}

	public static bool IsHit(CapsuleCollider lhs, MeshCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CapsuleCollider lhs, TerrainCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CapsuleCollider lhs, WheelCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CharacterController lhs, BoxCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CharacterController lhs, SphereCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CharacterController lhs, CapsuleCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CharacterController lhs, CharacterController rhs) {
		return false;
	}

	public static bool IsHit(CharacterController lhs, MeshCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CharacterController lhs, TerrainCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CharacterController lhs, WheelCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider lhs, BoxCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider lhs, SphereCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider lhs, CapsuleCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider lhs, CharacterController rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider lhs, MeshCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider lhs, TerrainCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider lhs, WheelCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider lhs, BoxCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider lhs, SphereCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider lhs, CapsuleCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider lhs, CharacterController rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider lhs, MeshCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider lhs, TerrainCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider lhs, WheelCollider rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(Collider2D lhs, Collider2D rhs) {
		switch (((int)Collider2DTypeOf(lhs) << 16) | (int)Collider2DTypeOf(rhs)) {
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.CircleCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:		throw new UnknownColliderException();
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.BoxCollider2D:			return IsHit((BoxCollider2D)lhs, (BoxCollider2D)rhs);
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.CircleCollider2D:		return IsHit((BoxCollider2D)lhs, (CircleCollider2D)rhs);
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:		return IsHit((BoxCollider2D)lhs, (EdgeCollider2D)rhs);
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:		return IsHit((BoxCollider2D)lhs, (PolygonCollider2D)rhs);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		return IsHit((CircleCollider2D)lhs, (BoxCollider2D)rhs);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.CircleCollider2D:	return IsHit((CircleCollider2D)lhs, (CircleCollider2D)rhs);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:		return IsHit((CircleCollider2D)lhs, (EdgeCollider2D)rhs);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	return IsHit((CircleCollider2D)lhs, (PolygonCollider2D)rhs);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		return IsHit((EdgeCollider2D)lhs, (BoxCollider2D)rhs);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.CircleCollider2D:		return IsHit((EdgeCollider2D)lhs, (CircleCollider2D)rhs);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:		return IsHit((EdgeCollider2D)lhs, (EdgeCollider2D)rhs);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	return IsHit((EdgeCollider2D)lhs, (PolygonCollider2D)rhs);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		return IsHit((PolygonCollider2D)lhs, (BoxCollider2D)rhs);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.CircleCollider2D:	return IsHit((PolygonCollider2D)lhs, (CircleCollider2D)rhs);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:	return IsHit((PolygonCollider2D)lhs, (EdgeCollider2D)rhs);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	return IsHit((PolygonCollider2D)lhs, (PolygonCollider2D)rhs);
		default: throw new System.NotImplementedException();
		}
	}

	public static bool IsHit(BoxCollider2D lhs, BoxCollider2D rhs) {
		return false;
	}

	public static bool IsHit(BoxCollider2D lhs, CircleCollider2D rhs) {
		return false;
	}

	public static bool IsHit(BoxCollider2D lhs, EdgeCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(BoxCollider2D lhs, PolygonCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CircleCollider2D lhs, BoxCollider2D rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CircleCollider2D lhs, CircleCollider2D rhs) {
		return false;
	}

	public static bool IsHit(CircleCollider2D lhs, EdgeCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CircleCollider2D lhs, PolygonCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D lhs, BoxCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D lhs, CircleCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D lhs, EdgeCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D lhs, PolygonCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D lhs, BoxCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D lhs, CircleCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D lhs, EdgeCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D lhs, PolygonCollider2D rhs) {
		throw new System.NotImplementedException();
	}


	public class UnknownColliderException: System.NotImplementedException {
		public UnknownColliderException(): base() {}
		public UnknownColliderException(string message): base(message) {}
		public UnknownColliderException(string message, System.Exception innerException): base(message, innerException) {}
	}

	private enum ColliderType {
		UnknownCollider,
		BoxCollider,
		SphereCollider,
		CapsuleCollider,
		CharacterController,
		MeshCollider,
		TerrainCollider,
		WheelCollider,
	}

	private static ColliderType ColliderTypeOf(Collider collider) {
		var result = ColliderType.UnknownCollider;
		if (collider is BoxCollider) {
			result = ColliderType.BoxCollider;
		} else if (collider is CapsuleCollider) {
			result = ColliderType.CapsuleCollider;
		} else if (collider is MeshCollider) {
			result = ColliderType.MeshCollider;
		} else if (collider is SphereCollider) {
			result = ColliderType.SphereCollider;
		} else if (collider is TerrainCollider) {
			result = ColliderType.TerrainCollider;
		} else if (collider is WheelCollider) {
			result = ColliderType.WheelCollider;
		} else if (null == collider) {
			throw new System.ArgumentNullException();
		}
		return result;
	}

	private enum Collider2DType {
		UnknownCollider2D,
		BoxCollider2D,
		CircleCollider2D,
		EdgeCollider2D,
		PolygonCollider2D,
	}

	private static Collider2DType Collider2DTypeOf(Collider2D collider) {
		var result = Collider2DType.UnknownCollider2D;
		if (collider is BoxCollider2D) {
			result = Collider2DType.BoxCollider2D;
		} else if (collider is CircleCollider2D) {
			result = Collider2DType.CircleCollider2D;
		} else if (collider is EdgeCollider2D) {
			result = Collider2DType.EdgeCollider2D;
		} else if (collider is PolygonCollider2D) {
			result = Collider2DType.PolygonCollider2D;
		} else if (null == collider) {
			throw new System.ArgumentNullException();
		}
		return result;
	}
}
