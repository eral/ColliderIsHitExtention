// (C) 2014 ERAL
// Distributed under the Boost Software License, Version 1.0.
// (See copy at http://www.boost.org/LICENSE_1_0.txt)


using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public partial class ColliderIsHitExtention : MonoBehaviour {

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

	#region BoxCollider
	public static bool IsHit(BoxCollider lhs, BoxCollider rhs) {
		var lhsTransform = lhs.transform;
		var lhsBounds = lhs.bounds;
		var rhsTransform = rhs.transform;
		var rhsBounds = rhs.bounds;

		var distanceAxis = lhsBounds.center - rhsBounds.center;
		var lhsUnitAxis = new AxisPack3(lhsTransform.rotation);
		var lhsExtents = Vector3.Scale(lhs.size * 0.5f, lhsTransform.lossyScale);
		var lhsExtentsAxis = new AxisPack3(lhsExtents, lhsTransform.rotation);
		var rhsUnitAxis = new AxisPack3(rhsTransform.rotation);
		var rhsExtents = Vector3.Scale(rhs.size * 0.5f, rhsTransform.lossyScale);
		var rhsExtentsAxis = new AxisPack3(rhsExtents, rhsTransform.rotation);

		//lhs
		for (int i = 0, iMax = 3; i < iMax; ++i) {
			var splitAxis = lhsUnitAxis[i];
			var distance = GetVectorLengthOfProjection(distanceAxis, splitAxis);
			distance -= lhsExtents[i];
			distance -= GetVectorLengthOfProjection(rhsExtentsAxis, splitAxis);
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}
		//rhs
		for (int i = 0, iMax = 3; i < iMax; ++i) {
			var splitAxis = rhsUnitAxis[i];
			var distance = GetVectorLengthOfProjection(distanceAxis, splitAxis);
			distance -= GetVectorLengthOfProjection(lhsExtentsAxis, splitAxis);
			distance -= rhsExtents[i];
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}
		//3rd split axis
		for (int i = 0, iMax = 3; i < iMax; ++i) {
			for (int k = 0, kMax = 3; k < kMax; ++k) {
				var splitAxis = Vector3.Cross(lhsUnitAxis[i], rhsUnitAxis[k]);
				var distance = GetVectorLengthOfProjection(distanceAxis, splitAxis);
				distance -= GetVectorLengthOfProjection(lhsExtentsAxis, splitAxis);
				distance -= GetVectorLengthOfProjection(rhsExtentsAxis, splitAxis);
				if (0.0f < distance) {
					//NoHit
					return false;
				}
			}
		}

		//Hit
		return true;
	}

	public static bool IsHit(BoxCollider lhs, SphereCollider rhs) {
		var lhsTransform = lhs.transform;
		var lhsBounds = lhs.bounds;
		var rhsBounds = rhs.bounds;

		var distanceAxis = lhsBounds.center - rhsBounds.center;
		var lhsUnitAxis = new AxisPack3(lhsTransform.rotation);
		var lhsExtents = Vector3.Scale(lhs.size * 0.5f, lhsTransform.lossyScale);
		var rhsExtents = rhsBounds.extents.x;
		var rhsSqrExtents = rhsExtents * rhsExtents;

		var sqrDistanceFromBoxEdge = 0.0f;
		for (int i = 0, iMax = 3; i < iMax; ++i) {
			var splitAxis = lhsUnitAxis[i];
			var distance = GetVectorLengthOfProjection(distanceAxis, splitAxis);
			distance -= lhsExtents[i];
			if (rhsExtents < distance) {
				//NoHit
				return false;
			} else if (0.0f < distance) {
				sqrDistanceFromBoxEdge += distance * distance;
			}
		}
		return sqrDistanceFromBoxEdge < rhsSqrExtents;
	}

	public static bool IsHit(BoxCollider lhs, CapsuleCollider rhs) {
		var lhsPlanes = GetPlaneOfBox(lhs);
		var rhsTransform = rhs.transform;
		var rhsSegment = GetSegmentOfCapsule(rhs);
		var rhsExtents = rhs.radius * GetMaxLengthInAxis(rhsTransform.lossyScale);

		//Plane & Point
		var points = new[]{rhsSegment.origin, rhsSegment.origin + rhsSegment.direction};
		var planeCross = 0;
		for (int i = 0, i_max = points.Length; i < i_max; ++i) {
			var signDistances = lhsPlanes.Select(x=>GetSignDistance(points[i], x)).ToArray();
			var axisRegion = Enumerable.Range(0, signDistances.Length / 2)
										.Select(x=>x * 2)
										.Select(x=>signDistances[x] * signDistances[x+1])
										.ToArray();
			var voronoiKind = Enumerable.Range(0, axisRegion.Length)
										.Select(x=>((0.0f <= axisRegion[x])? 1<<x: 0))
										.Aggregate((x,y)=>x|y);
			IEnumerable<int> axisIndices = null;
			switch (voronoiKind) {
			case ((1<<0) + (1<<1) + (1<<2)): //Hit
				return true;
			case ((0<<0) + (1<<1) + (1<<2)): //X-axis plane near
				axisIndices = Enumerable.Range(0, 2);
				break;
			case ((1<<0) + (0<<1) + (1<<2)): //Y-axis plane near
				axisIndices = Enumerable.Range(2, 2);
				break;
			case ((1<<0) + (1<<1) + (0<<2)): //Z-axis plane near
				axisIndices = Enumerable.Range(4, 2);
				break;
			default:
				//empty.
				break;
			}
			if (null != axisIndices) {
				var signAxisDistances = axisIndices.Select(x=>signDistances[x]);
				if (signAxisDistances.Any(x=>((0.0f<=x)&&(x<=rhsExtents)))) {
					return true;
				}
			}
			planeCross ^= Enumerable.Range(0, signDistances.Length)
									.Select(x=>((0.0f < signDistances[x])? 1<<x: 0))
									.Aggregate((x,y)=>x|y);
		}

		//Plane & Segment
		if (0 != planeCross) {
			var planeIndices = Enumerable.Range(0, lhsPlanes.Length)
										.Where(x=>0 != ((1 << x) & planeCross));
			foreach (var planeIndex in planeIndices) {
				var crossPoint = GetNearestPoint(new Ray(rhsSegment.origin, rhsSegment.direction), lhsPlanes[planeIndex]);
				var signDistances = Enumerable.Range(0, lhsPlanes.Length)
												.SkipWhile(x=>(x & 0x01) == (planeIndex & 0x01))
												.Select(x=>GetSignDistance(crossPoint, lhsPlanes[x]))
												.ToArray();
				var isCross = Enumerable.Range(0, signDistances.Length / 2)
											.Select(x=>x * 2)
											.Select(x=>signDistances[x] * signDistances[x+1])
											.All(x=>0.0f <= x);
				if (isCross) {
					return true;
				}
			}
		}
	
		//Segment & Segment or Segment & Point
		var lhsSegments = GetSidesOfBox(lhs);
		var rhsSqrExtents = rhsExtents * rhsExtents;
		
		var segmentSqrDistances = new float[lhsSegments.Length];
		for (int i = 0, i_max = lhsSegments.Length; i < i_max; ++i) {
			var segmentSqrDistance = GetSqrDistance(lhsSegments[i], rhsSegment);
			if (segmentSqrDistance < rhsSqrExtents) {
				//Hit
				return true;
			}
			segmentSqrDistances[i] = segmentSqrDistance;
		}

		//NoHit
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
	#endregion

	#region SphereCollider
	public static bool IsHit(SphereCollider lhs, BoxCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(SphereCollider lhs, SphereCollider rhs) {
		var lhsBounds = lhs.bounds;
		var rhsBounds = rhs.bounds;

		var sqrDistance = (lhsBounds.center - rhsBounds.center).sqrMagnitude;
		var lhsExtents = lhsBounds.extents.x;
		var rhsExtents = rhsBounds.extents.x;
		var extents = lhsExtents + rhsExtents;
		var sqrExtents = extents * extents;

		return sqrDistance < sqrExtents;
	}

	public static bool IsHit(SphereCollider lhs, CapsuleCollider rhs) {
		var lhsBounds = lhs.bounds;
		var rhsTransform = rhs.transform;
		var rhsSegment = GetSegmentOfCapsule(rhs);

		var sqrDistance = GetSqrDistance(lhsBounds.center, rhsSegment);
		var lhsExtents = lhsBounds.extents.x;
		var rhsExtents = rhs.radius * GetMaxLengthInAxis(rhsTransform.lossyScale);
		var extents = lhsExtents + rhsExtents;
		var sqrExtents = extents * extents;

		return sqrDistance < sqrExtents;
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
	#endregion

	#region CapsuleCollider
	public static bool IsHit(CapsuleCollider lhs, BoxCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CapsuleCollider lhs, SphereCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CapsuleCollider lhs, CapsuleCollider rhs) {
		var lhsTransform = lhs.transform;
		var rhsTransform = rhs.transform;
		var lhsSegment = GetSegmentOfCapsule(lhs);
		var rhsSegment = GetSegmentOfCapsule(rhs);

		var sqrDistance = GetSqrDistance(lhsSegment, rhsSegment);
		var lhsExtents = lhs.radius * GetMaxLengthInAxis(lhsTransform.lossyScale);
		var rhsExtents = rhs.radius * GetMaxLengthInAxis(rhsTransform.lossyScale);
		var extents = lhsExtents + rhsExtents;
		var sqrExtents = extents * extents;

		return sqrDistance < sqrExtents;
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
	#endregion

	#region CharacterController
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
	#endregion

	#region TerrainCollider
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
	#endregion

	#region WheelCollider
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
	#endregion

	#region Private
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

	private struct Segment3 {
		public Vector3 origin;
		public Vector3 direction;

		public Segment3(Vector3 origin, Vector3 direction) {
			this.origin = origin;
			this.direction = direction;
		}
	}

	private struct Plane3 {
		public Vector3 origin;
		public Vector3 normal;

		public Plane3(Vector3 origin, Vector3 normal) {
			this.origin = origin;
			this.normal = normal;
		}
	}

	private class AxisPack3 {
		private Vector3[] axis;

		public Vector3 this[int i] {
			set{this.axis[i] = value;}
			get{return this.axis[i];}
		}
		public Vector3 right {
			set{this.axis[0] = value;}
			get{return this.axis[0];}
		}
		public Vector3 up {
			set{this.axis[1] = value;}
			get{return this.axis[1];}
		}
		public Vector3 forward {
			set{this.axis[2] = value;}
			get{return this.axis[2];}
		}
		public AxisPack3() : this(Vector3.one, Quaternion.identity) {}
		public AxisPack3(Vector3 scale) : this(scale, Quaternion.identity) {}
		public AxisPack3(Quaternion rotation) : this(Vector3.one, rotation) {}
		public AxisPack3(Vector3 scale, Quaternion rotation) {
			this.axis = new[]{Vector3.right * scale.x, Vector3.up * scale.y, Vector3.forward * scale.z}.Select(x=>rotation * x).ToArray();
		}
		public AxisPack3(Vector3 right, Vector3 up, Vector3 forward) {
			this.axis = new[]{right, up, forward}.ToArray();
		}
	}

	private static float GetMaxLengthInAxis(Vector3 src) {
		return Enumerable.Range(0, 3)
						.Select(x=>src[x])
						.Max();
	}

	private static float GetVectorLengthOfProjection(Vector3 src, Vector3 projection) {
		return Mathf.Abs(Vector3.Dot(projection, src));
	}

	private static float GetVectorLengthOfProjection(AxisPack3 axis, Vector3 projection) {
		float result = Enumerable.Range(0, 3)
								.Select(x=>GetVectorLengthOfProjection(projection, axis[x]))
								.Sum();
		return result;
	}

	private static Vector3 GetDirectionBaseVectorOfCapsule(CapsuleCollider src) {
		Vector3 result;
		switch (src.direction) {
		case 0:	result = Vector3.right;		break; //X-Axis
		case 1:	result = Vector3.up;		break; //Y-Axis
		case 2:	result = Vector3.forward;	break; //Z-Axis
		default:	throw new System.ArgumentOutOfRangeException();
		}
		return result;
	}

	private static Vector3[] GetVerticesOfBox(BoxCollider src) {
		var srcTransform = src.transform;
		var srcBounds = src.bounds;
		var axisSize = new AxisPack3(Vector3.Scale(src.size, srcTransform.lossyScale), srcTransform.rotation);
		var minPoint = srcBounds.center - (axisSize.right + axisSize.up + axisSize.forward) * 0.5f;

		var result = new Vector3[8];
		for (int i = 0, iMax = result.Length; i < iMax; ++i) {
			result[i] = minPoint;
			if (0 != (i & 0x01)) result[i] += axisSize.right;
			if (0 != (i & 0x02)) result[i] += axisSize.up;
			if (0 != (i & 0x04)) result[i] += axisSize.forward;
		}
		return result;
	}

	private static Segment3[] GetSidesOfBox(BoxCollider src) {
		var vertices = GetVerticesOfBox(src);

		Vector3 direction;
		var result = new Segment3[12];
		//x
		direction = vertices[1] - vertices[0];
		result[0] = new Segment3(vertices[0], direction);
		result[1] = new Segment3(vertices[2], direction);
		result[2] = new Segment3(vertices[4], direction);
		result[3] = new Segment3(vertices[6], direction);
		//y
		direction = vertices[2] - vertices[0];
		result[4] = new Segment3(vertices[0], direction);
		result[5] = new Segment3(vertices[1], direction);
		result[6] = new Segment3(vertices[4], direction);
		result[7] = new Segment3(vertices[5], direction);
		//z
		direction = vertices[4] - vertices[0];
		result[8] = new Segment3(vertices[0], direction);
		result[9] = new Segment3(vertices[1], direction);
		result[10]= new Segment3(vertices[2], direction);
		result[11]= new Segment3(vertices[3], direction);

		return result;
	}

	private static float GetSignDistance(Vector3 lhs, Plane3 rhs) {
		return Vector3.Dot(rhs.normal, lhs - rhs.origin);
	}

	private static Vector3 GetNearestPoint(Vector3 lhs, Plane3 rhs) {
		return lhs - rhs.normal * GetSignDistance(lhs, rhs);
	}

	private static Vector3 GetNearestPoint(Ray lhs, Plane3 rhs) {
		var result = lhs.origin;
		if (lhs.direction != rhs.normal) {
			var signDistance = GetSignDistance(lhs.origin, rhs);
			var weight = Vector3.Dot(-rhs.normal, lhs.direction);
			result = lhs.GetPoint(signDistance / weight);
		}
		return result;
	}

	private static Plane3[] GetPlaneOfBox(BoxCollider src) {
		var srcTransform = src.transform;
		var srcBounds = src.bounds;
		var axisUnit = new AxisPack3(srcTransform.rotation);
		var axisSize = new AxisPack3(Vector3.Scale(src.size * 0.5f, srcTransform.lossyScale), srcTransform.rotation);

		var result = new Plane3[6];
		result[0] = new Plane3(srcBounds.center + axisSize.right,  axisUnit.right);
		result[1] = new Plane3(srcBounds.center - axisSize.right, -axisUnit.right);
		result[2] = new Plane3(srcBounds.center + axisSize.up,  axisUnit.up);
		result[3] = new Plane3(srcBounds.center - axisSize.up, -axisUnit.up);
		result[4] = new Plane3(srcBounds.center + axisSize.forward,  axisUnit.forward);
		result[5] = new Plane3(srcBounds.center - axisSize.forward, -axisUnit.forward);
		return result;
	}
	

	private static Segment3 GetSegmentOfCapsule(CapsuleCollider src) {
		var srcTransform = src.transform;

		Vector3 origin = GetDirectionBaseVectorOfCapsule(src);
		var length = src.height - src.radius * 2.0f;
		var direction = srcTransform.rotation * Vector3.Scale(origin * length, srcTransform.lossyScale);
		origin = direction * -0.5f + src.bounds.center;
		return new Segment3(origin, direction);
	}

	private static Vector3 GetNearestPoint(Vector3 lhs, Segment3 rhs) {
		var rhsOrigin = rhs.origin;
		var rhsDirection = rhs.direction;

		var between = lhs - rhsOrigin;
		var rhsSqrLength = rhsDirection.sqrMagnitude;

		var betweenOfRhsProjection = Vector3.Dot(rhsDirection, between);
		var rhsProgress = Mathf.Clamp01(betweenOfRhsProjection / rhsSqrLength);
		return rhsOrigin + rhsDirection * rhsProgress;
	}

	private static float GetSqrDistance(Vector3 lhs, Segment3 rhs) {
		var rhsNearest = GetNearestPoint(lhs, rhs);
		var distance = lhs - rhsNearest;
		return distance.sqrMagnitude;
	}

	private static Vector3 GetNearestPoint(Vector3 lhs, BoxCollider rhs) {
		var rhsTransform = rhs.transform;
		var rhsBounds = rhs.bounds;

		var distanceAxis = lhs - rhsBounds.center;
		var rhsUnitAxis = new AxisPack3(rhsTransform.rotation);
		var rhsExtents = Vector3.Scale(rhs.size * 0.5f, rhsTransform.lossyScale);

		var result = rhsBounds.center;
		for (int i = 0, iMax = 3; i < iMax; ++i) {
			var distance = Vector3.Dot(rhsUnitAxis[i], distanceAxis);
			distance = Mathf.Clamp(distance, -rhsExtents[i], rhsExtents[i]);
			result += rhsUnitAxis[i] * distance;
		}
		return result;
	}

	private static float GetSqrDistance(Vector3 lhs, BoxCollider rhs) {
		var lhsNearest = GetNearestPoint(lhs, rhs);
		var distance = lhsNearest - rhs.bounds.center;
		return distance.sqrMagnitude;
	}

	private static Vector3[] GetNearestPoint(Segment3 lhs, Segment3 rhs) {
		var lhsOrigin = lhs.origin;
		var lhsDirection = lhs.direction;
		var rhsOrigin = rhs.origin;
		var rhsDirection = rhs.direction;

		var between = lhsOrigin - rhsOrigin;
		var lhsSqrLength = lhsDirection.sqrMagnitude;
		var rhsSqrLength = rhsDirection.sqrMagnitude;

		float lhsProgress, rhsProgress;
		do {
			if ((0.0f == lhsSqrLength) || (0.0f == rhsSqrLength)) {
				//Point & Point
				lhsProgress = 0.0f;
				rhsProgress = 0.0f;
				break;
			}

			var betweenOfRhsProjection = Vector3.Dot(rhsDirection, between);
			if (0.0f == lhsSqrLength) {
				//Point & Segment
				lhsProgress = 0.0f;
				rhsProgress = Mathf.Clamp01(betweenOfRhsProjection / rhsSqrLength);
				break;
			}
			var betweenOfLhsProjection = Vector3.Dot(lhsDirection, between);
			if (0.0f == rhsSqrLength) {
				//Segment & Point
				lhsProgress = Mathf.Clamp01(-betweenOfLhsProjection / lhsSqrLength);
				rhsProgress = 0.0f;
				break;
			}
			//Segment & Segment
			var rhsOfLhsProjection = Vector3.Dot(lhsDirection, rhsDirection);
			var denom = lhsSqrLength * rhsSqrLength - rhsOfLhsProjection * rhsOfLhsProjection;
			if (0.0f != denom) {
				lhsProgress = Mathf.Clamp01((rhsOfLhsProjection * betweenOfRhsProjection - betweenOfLhsProjection * rhsSqrLength) / denom);
			} else {
				lhsProgress = 0.0f;
			}
			var rhsProgressNom = rhsOfLhsProjection * lhsProgress + betweenOfRhsProjection;
			if (rhsProgressNom < 0.0f) {
				rhsProgress = 0.0f;
				lhsProgress = Mathf.Clamp01(-betweenOfLhsProjection / lhsSqrLength);
			} else if (rhsSqrLength < rhsProgressNom) {
				rhsProgress = 1.0f;
				lhsProgress = Mathf.Clamp01((rhsOfLhsProjection - betweenOfLhsProjection) / lhsSqrLength);
			} else {
				rhsProgress = rhsProgressNom / rhsSqrLength;
			}
		} while (false);
		var lhsPosition = lhsOrigin + lhsDirection * lhsProgress;
		var rhsPosition = rhsOrigin + rhsDirection * rhsProgress;
		return new[]{lhsPosition, rhsPosition};
	}

	private static float GetSqrDistance(Segment3 lhs, Segment3 rhs) {
		var nearestPoints = GetNearestPoint(lhs, rhs);
		var distance = nearestPoints[0]  - nearestPoints[1];
		return distance.sqrMagnitude;
	}
	#endregion
}
