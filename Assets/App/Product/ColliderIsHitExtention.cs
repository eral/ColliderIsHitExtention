using UnityEngine;

public class ColliderIsHitExtention : MonoBehaviour {

	public static bool IsHit(Collider a, Collider b) {
		switch (((int)ColliderTypeOf(a) << 16) | (int)ColliderTypeOf(b)) {
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.BoxCollider:				throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.SphereCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.CapsuleCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.CharacterController:		throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.MeshCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.TerrainCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.UnknownCollider << 16) | (int)ColliderType.WheelCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.UnknownCollider:				throw new UnknownColliderException();
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.BoxCollider:					return IsHit((BoxCollider)a, (BoxCollider)b);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.SphereCollider:				return IsHit((BoxCollider)a, (SphereCollider)b);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.CapsuleCollider:				return IsHit((BoxCollider)a, (CapsuleCollider)b);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.CharacterController:			return IsHit((BoxCollider)a, (CharacterController)b);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((BoxCollider)a, (MeshCollider)b);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.TerrainCollider:				return IsHit((BoxCollider)a, (TerrainCollider)b);
		case ((int)ColliderType.BoxCollider << 16) | (int)ColliderType.WheelCollider:				return IsHit((BoxCollider)a, (WheelCollider)b);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((SphereCollider)a, (BoxCollider)b);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((SphereCollider)a, (SphereCollider)b);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((SphereCollider)a, (CapsuleCollider)b);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((SphereCollider)a, (CharacterController)b);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((SphereCollider)a, (MeshCollider)b);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((SphereCollider)a, (TerrainCollider)b);
		case ((int)ColliderType.SphereCollider << 16) | (int)ColliderType.WheelCollider:			return IsHit((SphereCollider)a, (WheelCollider)b);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((CapsuleCollider)a, (BoxCollider)b);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((CapsuleCollider)a, (SphereCollider)b);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((CapsuleCollider)a, (CapsuleCollider)b);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((CapsuleCollider)a, (CharacterController)b);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.MeshCollider:			return IsHit((CapsuleCollider)a, (MeshCollider)b);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((CapsuleCollider)a, (TerrainCollider)b);
		case ((int)ColliderType.CapsuleCollider << 16) | (int)ColliderType.WheelCollider:			return IsHit((CapsuleCollider)a, (WheelCollider)b);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.UnknownCollider:		throw new UnknownColliderException();
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.BoxCollider:			return IsHit((CharacterController)a, (BoxCollider)b);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.SphereCollider:		return IsHit((CharacterController)a, (SphereCollider)b);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.CapsuleCollider:		return IsHit((CharacterController)a, (CapsuleCollider)b);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.CharacterController:	return IsHit((CharacterController)a, (CharacterController)b);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.MeshCollider:		return IsHit((CharacterController)a, (MeshCollider)b);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.TerrainCollider:		return IsHit((CharacterController)a, (TerrainCollider)b);
		case ((int)ColliderType.CharacterController << 16) | (int)ColliderType.WheelCollider:		return IsHit((CharacterController)a, (WheelCollider)b);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((MeshCollider)a, (BoxCollider)b);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.SphereCollider:				return IsHit((MeshCollider)a, (SphereCollider)b);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((MeshCollider)a, (CapsuleCollider)b);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((MeshCollider)a, (CharacterController)b);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((MeshCollider)a, (MeshCollider)b);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((MeshCollider)a, (TerrainCollider)b);
		case ((int)ColliderType.MeshCollider << 16) | (int)ColliderType.WheelCollider:				return IsHit((MeshCollider)a, (WheelCollider)b);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((TerrainCollider)a, (BoxCollider)b);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((TerrainCollider)a, (SphereCollider)b);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((TerrainCollider)a, (CapsuleCollider)b);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((TerrainCollider)a, (CharacterController)b);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.MeshCollider:			return IsHit((TerrainCollider)a, (MeshCollider)b);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((TerrainCollider)a, (TerrainCollider)b);
		case ((int)ColliderType.TerrainCollider << 16) | (int)ColliderType.WheelCollider:			return IsHit((TerrainCollider)a, (WheelCollider)b);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.UnknownCollider:			throw new UnknownColliderException();
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.BoxCollider:				return IsHit((WheelCollider)a, (BoxCollider)b);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.SphereCollider:			return IsHit((WheelCollider)a, (SphereCollider)b);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.CapsuleCollider:			return IsHit((WheelCollider)a, (CapsuleCollider)b);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.CharacterController:		return IsHit((WheelCollider)a, (CharacterController)b);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.MeshCollider:				return IsHit((WheelCollider)a, (MeshCollider)b);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.TerrainCollider:			return IsHit((WheelCollider)a, (TerrainCollider)b);
		case ((int)ColliderType.WheelCollider << 16) | (int)ColliderType.WheelCollider:				return IsHit((WheelCollider)a, (WheelCollider)b);
		default: throw new System.NotImplementedException();
		}
	}

	public static bool IsHit(BoxCollider a, BoxCollider b) {
		var result = false;
		return result;
	}

	public static bool IsHit(BoxCollider a, SphereCollider b) {
		var result = false;
		return result;
	}

	public static bool IsHit(BoxCollider a, CapsuleCollider b) {
		var result = false;
		return result;
	}

	public static bool IsHit(BoxCollider a, CharacterController b) {
		var result = false;
		return result;
	}

	public static bool IsHit(BoxCollider a, MeshCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(BoxCollider a, TerrainCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(BoxCollider a, WheelCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(SphereCollider a, BoxCollider b) {
		return IsHit(b, a);
	}

	public static bool IsHit(SphereCollider a, SphereCollider b) {
		var result = false;
		return result;
	}

	public static bool IsHit(SphereCollider a, CapsuleCollider b) {
		var result = false;
		return result;
	}

	public static bool IsHit(SphereCollider a, CharacterController b) {
		var result = false;
		return result;
	}

	public static bool IsHit(SphereCollider a, MeshCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(SphereCollider a, TerrainCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(SphereCollider a, WheelCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CapsuleCollider a, BoxCollider b) {
		return IsHit(b, a);
	}

	public static bool IsHit(CapsuleCollider a, SphereCollider b) {
		return IsHit(b, a);
	}

	public static bool IsHit(CapsuleCollider a, CapsuleCollider b) {
		var result = false;
		return result;
	}

	public static bool IsHit(CapsuleCollider a, CharacterController b) {
		var result = false;
		return result;
	}

	public static bool IsHit(CapsuleCollider a, MeshCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CapsuleCollider a, TerrainCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CapsuleCollider a, WheelCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CharacterController a, BoxCollider b) {
		return IsHit(b, a);
	}

	public static bool IsHit(CharacterController a, SphereCollider b) {
		return IsHit(b, a);
	}

	public static bool IsHit(CharacterController a, CapsuleCollider b) {
		return IsHit(b, a);
	}

	public static bool IsHit(CharacterController a, CharacterController b) {
		var result = false;
		return result;
	}

	public static bool IsHit(CharacterController a, MeshCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CharacterController a, TerrainCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CharacterController a, WheelCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider a, BoxCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider a, SphereCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider a, CapsuleCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider a, CharacterController b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider a, MeshCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider a, TerrainCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(TerrainCollider a, WheelCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider a, BoxCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider a, SphereCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider a, CapsuleCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider a, CharacterController b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider a, MeshCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider a, TerrainCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(WheelCollider a, WheelCollider b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(Collider2D a, Collider2D b) {
		switch (((int)Collider2DTypeOf(a) << 16) | (int)Collider2DTypeOf(b)) {
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.CircleCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.UnknownCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:		throw new UnknownColliderException();
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.BoxCollider2D:			return IsHit((BoxCollider2D)a, (BoxCollider2D)b);
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.CircleCollider2D:		return IsHit((BoxCollider2D)a, (CircleCollider2D)b);
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:		return IsHit((BoxCollider2D)a, (EdgeCollider2D)b);
		case ((int)Collider2DType.BoxCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:		return IsHit((BoxCollider2D)a, (PolygonCollider2D)b);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		return IsHit((CircleCollider2D)a, (BoxCollider2D)b);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.CircleCollider2D:	return IsHit((CircleCollider2D)a, (CircleCollider2D)b);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:		return IsHit((CircleCollider2D)a, (EdgeCollider2D)b);
		case ((int)Collider2DType.CircleCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	return IsHit((CircleCollider2D)a, (PolygonCollider2D)b);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		return IsHit((EdgeCollider2D)a, (BoxCollider2D)b);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.CircleCollider2D:		return IsHit((EdgeCollider2D)a, (CircleCollider2D)b);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:		return IsHit((EdgeCollider2D)a, (EdgeCollider2D)b);
		case ((int)Collider2DType.EdgeCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	return IsHit((EdgeCollider2D)a, (PolygonCollider2D)b);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.UnknownCollider2D:	throw new UnknownColliderException();
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.BoxCollider2D:		return IsHit((PolygonCollider2D)a, (BoxCollider2D)b);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.CircleCollider2D:	return IsHit((PolygonCollider2D)a, (CircleCollider2D)b);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.EdgeCollider2D:	return IsHit((PolygonCollider2D)a, (EdgeCollider2D)b);
		case ((int)Collider2DType.PolygonCollider2D << 16) | (int)Collider2DType.PolygonCollider2D:	return IsHit((PolygonCollider2D)a, (PolygonCollider2D)b);
		default: throw new System.NotImplementedException();
		}
	}

	public static bool IsHit(BoxCollider2D a, BoxCollider2D b) {
		var result = false;
		return result;
	}

	public static bool IsHit(BoxCollider2D a, CircleCollider2D b) {
		var result = false;
		return result;
	}

	public static bool IsHit(BoxCollider2D a, EdgeCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(BoxCollider2D a, PolygonCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CircleCollider2D a, BoxCollider2D b) {
		return IsHit(b, a);
	}

	public static bool IsHit(CircleCollider2D a, CircleCollider2D b) {
		var result = false;
		return result;
	}

	public static bool IsHit(CircleCollider2D a, EdgeCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CircleCollider2D a, PolygonCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D a, BoxCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D a, CircleCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D a, EdgeCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(EdgeCollider2D a, PolygonCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D a, BoxCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D a, CircleCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D a, EdgeCollider2D b) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(PolygonCollider2D a, PolygonCollider2D b) {
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

	private static ColliderType ColliderTypeOf(Collider a) {
		var result = ColliderType.UnknownCollider;
		if (a is BoxCollider) {
			result = ColliderType.BoxCollider;
		} else if (a is CapsuleCollider) {
			result = ColliderType.CapsuleCollider;
		} else if (a is MeshCollider) {
			result = ColliderType.MeshCollider;
		} else if (a is SphereCollider) {
			result = ColliderType.SphereCollider;
		} else if (a is TerrainCollider) {
			result = ColliderType.TerrainCollider;
		} else if (a is WheelCollider) {
			result = ColliderType.WheelCollider;
		} else if (null == a) {
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

	private static Collider2DType Collider2DTypeOf(Collider2D a) {
		var result = Collider2DType.UnknownCollider2D;
		if (a is BoxCollider2D) {
			result = Collider2DType.BoxCollider2D;
		} else if (a is CircleCollider2D) {
			result = Collider2DType.CircleCollider2D;
		} else if (a is EdgeCollider2D) {
			result = Collider2DType.EdgeCollider2D;
		} else if (a is PolygonCollider2D) {
			result = Collider2DType.PolygonCollider2D;
		} else if (null == a) {
			throw new System.ArgumentNullException();
		}
		return result;
	}
}
