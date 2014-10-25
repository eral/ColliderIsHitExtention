// (C) 2014 ERAL
// Distributed under the Boost Software License, Version 1.0.
// (See copy at http://www.boost.org/LICENSE_1_0.txt)


using UnityEngine;
using System.Collections.Generic;
using System.Linq;

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
		var lhs_transform = lhs.transform;
		var lhs_bounds = lhs.bounds;
		var rhs_transform = rhs.transform;
		var rhs_bounds = rhs.bounds;

		var distance_axis = lhs_bounds.center - rhs_bounds.center;
		var lhs_unit_axis = new Axis3d(lhs_transform.rotation);
		var lhs_extents = Vector3.Scale(lhs.size * 0.5f, lhs_transform.lossyScale);
		var lhs_extents_axis = new Axis3d(lhs_extents, lhs_transform.rotation);
		var rhs_unit_axis = new Axis3d(rhs_transform.rotation);
		var rhs_extents = Vector3.Scale(rhs.size * 0.5f, rhs_transform.lossyScale);
		var rhs_extents_axis = new Axis3d(rhs_extents, rhs_transform.rotation);

		//lhs
		for (int i = 0, i_max = 3; i < i_max; ++i) {
			var split_axis = lhs_unit_axis[i];
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= lhs_extents[i];
			distance -= GetVectorLengthOfProjection(rhs_extents_axis, split_axis);
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}
		//rhs
		for (int i = 0, i_max = 3; i < i_max; ++i) {
			var split_axis = rhs_unit_axis[i];
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= GetVectorLengthOfProjection(lhs_extents_axis, split_axis);
			distance -= rhs_extents[i];
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}
		//3rd split axis
		for (int i = 0, i_max = 3; i < i_max; ++i) {
			for (int k = 0, k_max = 3; k < k_max; ++k) {
				var split_axis = Vector3.Cross(lhs_unit_axis[i], rhs_unit_axis[k]);
				var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
				distance -= GetVectorLengthOfProjection(lhs_extents_axis, split_axis);
				distance -= GetVectorLengthOfProjection(rhs_extents_axis, split_axis);
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
		var lhs_transform = lhs.transform;
		var lhs_bounds = lhs.bounds;
		var rhs_bounds = rhs.bounds;

		var distance_axis = lhs_bounds.center - rhs_bounds.center;
		var lhs_unit_axis = new Axis3d(lhs_transform.rotation);
		var lhs_extents = Vector3.Scale(lhs.size * 0.5f, lhs_transform.lossyScale);
		var rhs_extents = rhs_bounds.extents.x;
		var sqr_rhs_extents = rhs_extents * rhs_extents;

		var sqr_distance_from_box_edge = 0.0f;
		for (int i = 0, i_max = 3; i < i_max; ++i) {
			var split_axis = lhs_unit_axis[i];
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= lhs_extents[i];
			if (rhs_extents < distance) {
				//NoHit
				return false;
			} else if (0.0f < distance) {
				sqr_distance_from_box_edge += distance * distance;
			}
		}
		return sqr_distance_from_box_edge < sqr_rhs_extents;
	}

	public static bool IsHit(BoxCollider lhs, CapsuleCollider rhs) {
		var lhs_planes = GetPlaneOfBox(lhs);
		var rhs_transform = rhs.transform;
		var rhs_segment = GetSegmentOfCapsule(rhs);
		var rhs_extents = rhs.radius * GetMaxLengthInAxis(rhs_transform.lossyScale);

		//Plane & Point
		var points = new[]{rhs_segment.origin, rhs_segment.origin + rhs_segment.direction};
		foreach (var point in points) {
			var sign_distances = lhs_planes.Select(x=>GetSignDistance(point, x)).ToArray();
			var axis_region = Enumerable.Range(0, sign_distances.Length / 2)
										.Select(x=>x * 2)
										.Select(x=>sign_distances[x] * sign_distances[x+1])
										.ToArray();
			var voronoi_kind = Enumerable.Range(0, axis_region.Length)
										.Select(x=>((0.0f <= axis_region[x])? 1<<x: 0))
										.Sum();	
										
			switch (voronoi_kind) {
			case ((1<<0) + (1<<1) + (1<<2)): //Hit
				return true;
			case ((0<<0) + (1<<1) + (1<<2)): //X-axis plane near
				if (Enumerable.Range(0, 2)
								.Select(x=>sign_distances[x])
								.Any(x=>((0.0f<=x)&&(x<=rhs_extents)))) {
					return true;
				}
				break;
			case ((1<<0) + (0<<1) + (1<<2)): //Y-axis plane near
				if (Enumerable.Range(2, 2)
								.Select(x=>sign_distances[x])
								.Any(x=>((0.0f<=x)&&(x<=rhs_extents)))) {
					return true;
				}
				break;
			case ((1<<0) + (1<<1) + (0<<2)): //Z-axis plane near
				if (Enumerable.Range(4, 2)
								.Select(x=>sign_distances[x])
								.Any(x=>((0.0f<=x)&&(x<=rhs_extents)))) {
					return true;
				}
				break;
			default:
				//empty.
				break;
			}
		}
	
		//Segment & Segment or Segment & Point
		var lhs_segments = GetSidesOfBox(lhs);
		var sqr_rhs_extents = rhs_extents * rhs_extents;
		
		foreach (var lhs_segment in lhs_segments) {
			var segment_sqr_distance = GetSqrDistance(lhs_segment, rhs_segment);
			if (segment_sqr_distance < sqr_rhs_extents) {
				//Hit
				return true;
			}
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

	public static bool IsHit(SphereCollider lhs, BoxCollider rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(SphereCollider lhs, SphereCollider rhs) {
		var lhs_bounds = lhs.bounds;
		var rhs_bounds = rhs.bounds;

		var sqr_distance = (lhs_bounds.center - rhs_bounds.center).sqrMagnitude;
		var lhs_extents = lhs_bounds.extents.x;
		var rhs_extents = rhs_bounds.extents.x;
		var extents = lhs_extents + rhs_extents;
		var sqr_extents = extents * extents;

		return sqr_distance < sqr_extents;
	}

	public static bool IsHit(SphereCollider lhs, CapsuleCollider rhs) {
		var lhs_bounds = lhs.bounds;
		var rhs_transform = rhs.transform;
		var rhs_segment = GetSegmentOfCapsule(rhs);

		var sqr_distance = GetSqrDistance(lhs_bounds.center, rhs_segment);
		var lhs_extents = lhs_bounds.extents.x;
		var rhs_extents = rhs.radius * GetMaxLengthInAxis(rhs_transform.lossyScale);
		var extents = lhs_extents + rhs_extents;
		var sqr_extents = extents * extents;

		return sqr_distance < sqr_extents;
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
		var lhs_transform = lhs.transform;
		var rhs_transform = rhs.transform;
		var lhs_segment = GetSegmentOfCapsule(lhs);
		var rhs_segment = GetSegmentOfCapsule(rhs);

		var sqr_distance = GetSqrDistance(lhs_segment, rhs_segment);
		var lhs_extents = lhs.radius * GetMaxLengthInAxis(lhs_transform.lossyScale);
		var rhs_extents = rhs.radius * GetMaxLengthInAxis(rhs_transform.lossyScale);
		var extents = lhs_extents + rhs_extents;
		var sqr_extents = extents * extents;

		return sqr_distance < sqr_extents;
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
		var lhs_bounds = lhs.bounds;
		var rhs_bounds = rhs.bounds;

		var distance_axis = (Vector2)lhs_bounds.center - (Vector2)rhs_bounds.center;
		var lhs_extents_axis = GetExtentsAxisOfBox(lhs);
		var rhs_extents_axis = GetExtentsAxisOfBox(rhs);

		//lhs right angle
		for (int i = 0, i_max = 2; i < i_max; ++i) {
			var split_axis = Vector2Angle(lhs_extents_axis[i], 90.0f).normalized;
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= GetVectorLengthOfProjection(lhs_extents_axis, split_axis);
			distance -= GetVectorLengthOfProjection(rhs_extents_axis, split_axis);
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}

		//rhs right angle
		for (int i = 0, i_max = 2; i < i_max; ++i) {
			var split_axis = Vector2Angle(rhs_extents_axis[i], 90.0f).normalized;
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= GetVectorLengthOfProjection(lhs_extents_axis, split_axis);
			distance -= GetVectorLengthOfProjection(rhs_extents_axis, split_axis);
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}

		//Hit
		return true;
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

	struct Segment {
		public Vector3 origin;
		public Vector3 direction;

		public Segment(Vector3 origin, Vector3 direction) {
			this.origin = origin;
			this.direction = direction;
		}
	}

	struct Plane {
		public Vector3 origin;
		public Vector3 normal;

		public Plane(Vector3 origin, Vector3 normal) {
			this.origin = origin;
			this.normal = normal;
		}
	}

	private class Axis3d {
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
		public Axis3d() : this(Vector3.one, Quaternion.identity) {}
		public Axis3d(Vector3 scale) : this(scale, Quaternion.identity) {}
		public Axis3d(Quaternion rotation) : this(Vector3.one, rotation) {}
		public Axis3d(Vector3 scale, Quaternion rotation) {
			this.axis = new[]{Vector3.right * scale.x, Vector3.up * scale.y, Vector3.forward * scale.z}.Select(x=>rotation * x).ToArray();
		}
		public Axis3d(Vector3 right, Vector3 up, Vector3 forward) {
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

	private static float GetVectorLengthOfProjection(Axis3d axis, Vector3 projection) {
		float result = Enumerable.Range(0, 3)
								.Select(x=>Vector3.Dot(projection, axis[x]))
								.Select(x=>Mathf.Abs(x))
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
		var src_transform = src.transform;
		var src_bounds = src.bounds;
		var axis_size = new Axis3d(Vector3.Scale(src.size, src_transform.lossyScale), src_transform.rotation);
		var min_point = src_bounds.center - (axis_size.right + axis_size.up + axis_size.forward) * 0.5f;

		var result = new Vector3[8];
		for (int i = 0, i_max = result.Length; i < i_max; ++i) {
			result[i] = min_point;
			if (0 != (i & 0x01)) result[i] += axis_size.right;
			if (0 != (i & 0x02)) result[i] += axis_size.up;
			if (0 != (i & 0x04)) result[i] += axis_size.forward;
		}
		return result;
	}

	private static Segment[] GetSidesOfBox(BoxCollider src) {
		var vertices = GetVerticesOfBox(src);

		Vector3 direction;
		var result = new Segment[12];
		//x
		direction = vertices[1] - vertices[0];
		result[0] = new Segment(vertices[0], direction);
		result[1] = new Segment(vertices[2], direction);
		result[2] = new Segment(vertices[4], direction);
		result[3] = new Segment(vertices[6], direction);
		//y
		direction = vertices[2] - vertices[0];
		result[4] = new Segment(vertices[0], direction);
		result[5] = new Segment(vertices[1], direction);
		result[6] = new Segment(vertices[4], direction);
		result[7] = new Segment(vertices[5], direction);
		//z
		direction = vertices[4] - vertices[0];
		result[8] = new Segment(vertices[0], direction);
		result[9] = new Segment(vertices[1], direction);
		result[10]= new Segment(vertices[2], direction);
		result[11]= new Segment(vertices[3], direction);

		return result;
	}

	private static float GetSignDistance(Vector3 lhs, Plane rhs) {
		return Vector3.Dot(rhs.normal, lhs - rhs.origin);
	}

	private static Vector3 GetNearestPoint(Vector3 lhs, Plane rhs) {
		return lhs - rhs.normal * GetSignDistance(lhs, rhs);
	}

	private static Plane[] GetPlaneOfBox(BoxCollider src) {
		var src_transform = src.transform;
		var src_bounds = src.bounds;
		var axis_unit = new Axis3d(src_transform.rotation);
		var axis_size = new Axis3d(Vector3.Scale(src.size * 0.5f, src_transform.lossyScale), src_transform.rotation);

		var result = new Plane[6];
		result[0] = new Plane(src_bounds.center + axis_size.right,  axis_unit.right);
		result[1] = new Plane(src_bounds.center - axis_size.right, -axis_unit.right);
		result[2] = new Plane(src_bounds.center + axis_size.up,  axis_unit.up);
		result[3] = new Plane(src_bounds.center - axis_size.up, -axis_unit.up);
		result[4] = new Plane(src_bounds.center + axis_size.forward,  axis_unit.forward);
		result[5] = new Plane(src_bounds.center - axis_size.forward, -axis_unit.forward);
		return result;
	}
	

	private static Segment GetSegmentOfCapsule(CapsuleCollider src) {
		var src_transform = src.transform;

		Vector3 origin = GetDirectionBaseVectorOfCapsule(src);
		var length = src.height - src.radius * 2.0f;
		var direction = src_transform.rotation * Vector3.Scale(origin * length, src_transform.lossyScale);
		origin = direction * -0.5f + src.bounds.center;
		return new Segment(origin, direction);
	}

	private static Vector3 GetNearestPoint(Vector3 lhs, Segment rhs) {
		var rhs_origin = rhs.origin;
		var rhs_direction = rhs.direction;

		var between = lhs - rhs_origin;
		var rhs_sqr_length = rhs_direction.sqrMagnitude;

		var between_of_rhs_projection = Vector3.Dot(rhs_direction, between);
		var rhs_progress = Mathf.Clamp01(between_of_rhs_projection / rhs_sqr_length);
		return rhs_origin + rhs_direction * rhs_progress;
	}

	private static float GetSqrDistance(Vector3 lhs, Segment rhs) {
		var rhs_nearest = GetNearestPoint(lhs, rhs);
		var distance = lhs - rhs_nearest;
		return distance.sqrMagnitude;
	}

	private static Vector3 GetNearestPoint(Vector3 lhs, BoxCollider rhs) {
		var rhs_transform = rhs.transform;
		var rhs_bounds = rhs.bounds;

		var distance_axis = lhs - rhs_bounds.center;
		var rhs_unit_axis = new Axis3d(rhs_transform.rotation);
		var rhs_extents = Vector3.Scale(rhs.size * 0.5f, rhs_transform.lossyScale);

		var result = rhs_bounds.center;
		for (int i = 0, i_max = 3; i < i_max; ++i) {
			var distance = Vector3.Dot(rhs_unit_axis[i], distance_axis);
			distance = Mathf.Clamp(distance, -rhs_extents[i], rhs_extents[i]);
			result += rhs_unit_axis[i] * distance;
		}
		return result;
	}

	private static float GetSqrDistance(Vector3 lhs, BoxCollider rhs) {
		var lhs_nearest = GetNearestPoint(lhs, rhs);
		var distance = lhs_nearest - rhs.bounds.center;
		return distance.sqrMagnitude;
	}

	private static Vector3[] GetNearestPoint(Segment lhs, Segment rhs) {
		var lhs_origin = lhs.origin;
		var lhs_direction = lhs.direction;
		var rhs_origin = rhs.origin;
		var rhs_direction = rhs.direction;

		var between = lhs_origin - rhs_origin;
		var lhs_sqr_length = lhs_direction.sqrMagnitude;
		var rhs_sqr_length = rhs_direction.sqrMagnitude;

		float lhs_progress, rhs_progress;
		do {
			if ((0.0f == lhs_sqr_length) || (0.0f == rhs_sqr_length)) {
				//Point & Point
				lhs_progress = 0.0f;
				rhs_progress = 0.0f;
				break;
			}

			var between_of_rhs_projection = Vector3.Dot(rhs_direction, between);
			if (0.0f == lhs_sqr_length) {
				//Point & Segment
				lhs_progress = 0.0f;
				rhs_progress = Mathf.Clamp01(between_of_rhs_projection / rhs_sqr_length);
				break;
			}
			var between_of_lhs_projection = Vector3.Dot(lhs_direction, between);
			if (0.0f == rhs_sqr_length) {
				//Segment & Point
				lhs_progress = Mathf.Clamp01(-between_of_lhs_projection / lhs_sqr_length);
				rhs_progress = 0.0f;
				break;
			}
			//Segment & Segment
			var rhs_of_lhs_projection = Vector3.Dot(lhs_direction, rhs_direction);
			var denom = lhs_sqr_length * rhs_sqr_length - rhs_of_lhs_projection * rhs_of_lhs_projection;
			if (0.0f != denom) {
				lhs_progress = Mathf.Clamp01((rhs_of_lhs_projection * between_of_rhs_projection - between_of_lhs_projection * rhs_sqr_length) / denom);
			} else {
				lhs_progress = 0.0f;
			}
			var rhs_progress_nom = rhs_of_lhs_projection * lhs_progress + between_of_rhs_projection;
			if (rhs_progress_nom < 0.0f) {
				rhs_progress = 0.0f;
				lhs_progress = Mathf.Clamp01(-between_of_lhs_projection / lhs_sqr_length);
			} else if (rhs_sqr_length < rhs_progress_nom) {
				rhs_progress = 1.0f;
				lhs_progress = Mathf.Clamp01((rhs_of_lhs_projection - between_of_lhs_projection) / lhs_sqr_length);
			} else {
				rhs_progress = rhs_progress_nom / rhs_sqr_length;
			}
		} while (false);
		var lhs_position = lhs_origin + lhs_direction * lhs_progress;
		var rhs_position = rhs_origin + rhs_direction * rhs_progress;
		return new[]{lhs_position, rhs_position};
	}

	private static float GetSqrDistance(Segment lhs, Segment rhs) {
		var nearest_points = GetNearestPoint(lhs, rhs);
		var distance = nearest_points[0]  - nearest_points[1];
		return distance.sqrMagnitude;
	}

	private class Axis2d {
		private Vector2[] axis;

		public Vector2 this[int i] {
			set{this.axis[i] = value;}
			get{return this.axis[i];}
		}
		public Vector2 right {
			set{this.axis[0] = value;}
			get{return this.axis[0];}
		}
		public Vector2 up {
			set{this.axis[1] = value;}
			get{return this.axis[1];}
		}
		public Axis2d() : this(Vector2.one, 0.0f) {}
		public Axis2d(Vector2 scale) : this(scale, 0.0f) {}
		public Axis2d(float rotation) : this(Vector2.one, rotation) {}
		public Axis2d(Vector2 scale, float rotation) {
			this.axis = new[]{Vector2.right * scale.x, Vector2.up * scale.y}.Select(x=>Vector2Angle(x, rotation)).ToArray();
		}
		public Axis2d(Vector2 right, Vector2 up) {
			this.axis = new[]{right, up}.ToArray();
		}
	}

	private static Vector2 Vector2Angle(Vector2 src, float rotation) {
		return (Vector2)(Quaternion.AngleAxis(rotation, Vector3.forward) * src);
	}

	private static float GetVectorLengthOfProjection(Vector2 src, Vector2 projection) {
		return Mathf.Abs(Vector2.Dot(projection, src));
	}

	private static float GetVectorLengthOfProjection(Axis2d axis, Vector2 projection) {
		float result = Enumerable.Range(0, 2)
								.Select(x=>GetVectorLengthOfProjection(projection, axis[x]))
								.Sum();
		return result;
	}

	private static Vector2[] GetVerticesOfBox(BoxCollider2D src) {
		var matrix = src.transform.localToWorldMatrix;
		var min_point = src.center - src.size * 0.5f;

		var local_position = new Vector2[4];
		for (int i = 0, i_max = local_position.Length; i < i_max; ++i) {
			local_position[i] = min_point;
			if (0 != (i & 0x01)) local_position[i].x += src.size.x;
			if (0 != (i & 0x02)) local_position[i].y += src.size.y;
		}
		var result = local_position.Select(x=>(Vector2)matrix.MultiplyPoint3x4(x))
									.ToArray();
		return result;
	}

	private static Axis2d GetExtentsAxisOfBox(BoxCollider2D src) {
		var vertices = GetVerticesOfBox(src);

		var directions = new[]{vertices[1] - vertices[0], vertices[2] - vertices[0]};
		var extents = directions.Select(x=>x * 0.5f)
								.ToArray();
		return new Axis2d(extents[0], extents[1]);
	}
}
