using UnityEngine;
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
		var lhs_transform = lhs.transform;
		var lhs_bounds = lhs.bounds;
		var rhs_transform = rhs.transform;
		var rhs_bounds = rhs.bounds;

		var distance_axis = lhs_bounds.center - rhs_bounds.center;
		var lhs_unit_axis = new Axis3d(lhs_transform.rotation);
		var lhs_extents = Vector3.Scale(lhs.size * 0.5f, lhs_transform.lossyScale);
		var lhs_extents_axis = new Axis3d(lhs_extents, lhs_transform.rotation);
		var rhs_unit_axis = rhs_transform.rotation * GetDirectionBaseVectorOfCapsule(rhs);
		var rhs_scale = GetMaxLengthInAxis(rhs_transform.lossyScale);
		var rhs_extents_ray = rhs_unit_axis * (rhs.height - rhs.radius * 2.0f) * 0.5f * rhs_scale;
		var rhs_extents_radius = rhs.radius * rhs_scale;

		{
			var rhs_ray = GetRayOfCapsule(rhs);
			var lhs_nearest = GetNearestPoint(rhs_ray.origin, lhs);
			var rhs_ray_nearest_progress = Vector3.Dot(rhs_ray.direction, lhs_nearest - rhs_ray.origin) / rhs_ray.direction.sqrMagnitude;
			var rhs_ray_nearest = rhs_ray.origin + rhs_ray.direction * rhs_ray_nearest_progress;
	
			var split_axis = rhs_ray_nearest - lhs_nearest;
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= GetVectorLengthOfProjection(lhs_extents_axis, split_axis);
			GetVectorLengthOfProjection(rhs_extents_ray, split_axis);
			distance -= rhs_extents_radius;
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}
#if false
		//Box
		for (int i = 0, i_max = 3; i < i_max; ++i) {
			var split_axis = lhs_unit_axis[i];
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= lhs_extents[i];
			distance -= GetVectorLengthOfProjection(rhs_extents_ray, split_axis);
			distance -= rhs_extents_radius;
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}
		//2nd split axis
		for (int i = 0, i_max = 3; i < i_max; ++i) {
			var split_axis = Vector3.Cross(lhs_unit_axis[i], rhs_unit_axis);
			var distance = GetVectorLengthOfProjection(distance_axis, split_axis);
			distance -= GetVectorLengthOfProjection(lhs_extents_axis, split_axis);
			//"GetVectorLengthOfProjection(rhs_extents_ray, split_axis);" is always 0.0f
			distance -= rhs_extents_radius;
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}
		//Hemisphere Test
		{
			var sqr_rhs_extents_radius = rhs_extents_radius * rhs_extents_radius;
			var rhs_ray = GetRayOfCapsule(rhs);
			var rhs_hemisphere_rays = new[]{new{center=rhs_ray.origin, direction=rhs_ray.direction}
											, new{center=rhs_ray.origin + rhs_ray.direction, direction=-rhs_ray.direction}
											};
			foreach (var rhs_hemisphere_ray in rhs_hemisphere_rays) {
				var lhs_nearest = GetNearestPoint(rhs_hemisphere_ray.center, lhs);
				var hemisphere_to_nearest = lhs_nearest - rhs_hemisphere_ray.center;
				var direction_projection = Vector3.Dot(hemisphere_to_nearest, rhs_hemisphere_ray.direction);
				if (direction_projection < 0.0f) {
					var sqr_distance = (hemisphere_to_nearest).sqrMagnitude;
					if (sqr_rhs_extents_radius < sqr_distance) {
						//NoHit
						return false;
					}
				}
			}
		}
#endif

		//Hit
		return true;
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
		var lhs_transform = lhs.transform;
		var lhs_bounds = lhs.bounds;
		var rhs_transform = rhs.transform;
		var rhs_ray = GetRayOfCapsule(rhs);

		var sqr_distance = GetSqrDistance(lhs_bounds.center, rhs_ray);
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
		var lhs_ray = GetRayOfCapsule(lhs);
		var rhs_ray = GetRayOfCapsule(rhs);

		var sqr_distance = GetSqrDistance(lhs_ray, rhs_ray);
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

	private static Ray GetRayOfCapsule(CapsuleCollider src) {
		var src_transform = src.transform;

		Vector3 origin = GetDirectionBaseVectorOfCapsule(src);
		var length = src.height - src.radius * 2.0f;
		var direction = src_transform.rotation * Vector3.Scale(origin * length, src_transform.lossyScale);
		origin = direction * -0.5f + src.bounds.center;
		return new Ray(origin, direction);
	}

	private static Vector3 GetNearestPoint(Vector3 lhs, Ray rhs) {
		var rhs_origin = rhs.origin;
		var rhs_direction = rhs.direction;

		var between = lhs - rhs_origin;
		var rhs_sqr_length = rhs_direction.sqrMagnitude;

		var between_of_rhs_projection = Vector3.Dot(rhs_direction, between);
		var rhs_progress = Mathf.Clamp01(between_of_rhs_projection / rhs_sqr_length);
		return rhs_origin + rhs_direction * rhs_progress;
	}

	private static float GetSqrDistance(Vector3 lhs, Ray rhs) {
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

	private static Vector3[] GetNearestPoint(Ray lhs, Ray rhs) {
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
				//Point & Ray
				lhs_progress = 0.0f;
				rhs_progress = Mathf.Clamp01(between_of_rhs_projection / rhs_sqr_length);
				break;
			}
			var between_of_lhs_projection = Vector3.Dot(lhs_direction, between);
			if (0.0f == rhs_sqr_length) {
				//Ray & Point
				lhs_progress = Mathf.Clamp01(-between_of_lhs_projection / lhs_sqr_length);
				rhs_progress = 0.0f;
				break;
			}
			//Ray & Ray
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

	private static float GetSqrDistance(Ray lhs, Ray rhs) {
		var nearest_points = GetNearestPoint(lhs, rhs);
		var distance = nearest_points[0]  - nearest_points[1];
		return distance.sqrMagnitude;
	}
}
