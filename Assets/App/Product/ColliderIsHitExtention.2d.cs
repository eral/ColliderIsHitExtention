// (C) 2014 ERAL
// Distributed under the Boost Software License, Version 1.0.
// (See copy at http://www.boost.org/LICENSE_1_0.txt)


using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public partial class ColliderIsHitExtention : MonoBehaviour {

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

	#region BoxCollider2D
	public static bool IsHit(BoxCollider2D lhs, BoxCollider2D rhs) {
		var lhsBounds = lhs.bounds;
		var rhsBounds = rhs.bounds;

		var distanceAxis = (Vector2)lhsBounds.center - (Vector2)rhsBounds.center;
		var lhsExtentsAxis = GetExtentsAxisOfBox(lhs);
		var rhsExtentsAxis = GetExtentsAxisOfBox(rhs);

		//lhs right angle
		for (int i = 0, iMax = 2; i < iMax; ++i) {
			var splitAxis = Vector2Angle(lhsExtentsAxis[i], 90.0f).normalized;
			var distance = GetVectorLengthOfProjection(distanceAxis, splitAxis);
			distance -= GetVectorLengthOfProjection(lhsExtentsAxis, splitAxis);
			distance -= GetVectorLengthOfProjection(rhsExtentsAxis, splitAxis);
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}

		//rhs right angle
		for (int i = 0, iMax = 2; i < iMax; ++i) {
			var splitAxis = Vector2Angle(rhsExtentsAxis[i], 90.0f).normalized;
			var distance = GetVectorLengthOfProjection(distanceAxis, splitAxis);
			distance -= GetVectorLengthOfProjection(lhsExtentsAxis, splitAxis);
			distance -= GetVectorLengthOfProjection(rhsExtentsAxis, splitAxis);
			if (0.0f < distance) {
				//NoHit
				return false;
			}
		}

		//Hit
		return true;
	}

	public static bool IsHit(BoxCollider2D lhs, CircleCollider2D rhs) {
		var lhsVertices = GetVerticesOfBox(lhs);
		var rhsBounds = rhs.bounds;
		var rhsExtents = rhsBounds.extents.x;
		var sqrRhsExtents = rhsExtents * rhsExtents;

		var lhsVerticesClockwise = new[]{lhsVertices[0], lhsVertices[1], lhsVertices[3], lhsVertices[2]};
		var sqrDistances = GetSqrDistance(rhsBounds.center, lhsVerticesClockwise);

		return sqrDistances < sqrRhsExtents;
	}

	public static bool IsHit(BoxCollider2D lhs, EdgeCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(BoxCollider2D lhs, PolygonCollider2D rhs) {
		throw new System.NotImplementedException();
	}
	#endregion

	#region CircleCollider2D
	public static bool IsHit(CircleCollider2D lhs, BoxCollider2D rhs) {
		return IsHit(rhs, lhs);
	}

	public static bool IsHit(CircleCollider2D lhs, CircleCollider2D rhs) {
		var lhsBounds = lhs.bounds;
		var rhsBounds = rhs.bounds;

		var sqrDistance = (lhsBounds.center - rhsBounds.center).sqrMagnitude;
		var lhsExtents = lhsBounds.extents.x;
		var rhsExtents = rhsBounds.extents.x;
		var extents = lhsExtents + rhsExtents;
		var sqrExtents = extents * extents;

		return sqrDistance < sqrExtents;
	}

	public static bool IsHit(CircleCollider2D lhs, EdgeCollider2D rhs) {
		throw new System.NotImplementedException();
	}

	public static bool IsHit(CircleCollider2D lhs, PolygonCollider2D rhs) {
		throw new System.NotImplementedException();
	}
	#endregion

	#region EdgeCollider2D
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
	#endregion

	#region PolygonCollider2D
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
	#endregion

	#region Private
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

	private class AxisPack2 {
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
		public AxisPack2() : this(Vector2.one, 0.0f) {}
		public AxisPack2(Vector2 scale) : this(scale, 0.0f) {}
		public AxisPack2(float rotation) : this(Vector2.one, rotation) {}
		public AxisPack2(Vector2 scale, float rotation) {
			this.axis = new[]{Vector2.right * scale.x, Vector2.up * scale.y}.Select(x=>Vector2Angle(x, rotation)).ToArray();
		}
		public AxisPack2(Vector2 right, Vector2 up) {
			this.axis = new[]{right, up}.ToArray();
		}
	}

	private static Vector2 Vector2Angle(Vector2 src, float rotation) {
		return (Vector2)(Quaternion.AngleAxis(rotation, Vector3.forward) * src);
	}

	private static float Vector2PrepDot(Vector2 lhs, Vector2 rhs) {
		return Vector2.Dot(new Vector2(-lhs.y, lhs.x), rhs);
	}

	private static float GetVectorLengthOfProjection(Vector2 src, Vector2 projection) {
		return Mathf.Abs(Vector2.Dot(projection, src));
	}

	private static float GetVectorLengthOfProjection(AxisPack2 axis, Vector2 projection) {
		float result = Enumerable.Range(0, 2)
								.Select(x=>GetVectorLengthOfProjection(projection, axis[x]))
								.Sum();
		return result;
	}

	private static Vector2[] GetVerticesOfBox(BoxCollider2D src) {
		var matrix = src.transform.localToWorldMatrix;
		var minPoint = src.center - src.size * 0.5f;

		var localPosition = new Vector2[4];
		for (int i = 0, iMax = localPosition.Length; i < iMax; ++i) {
			localPosition[i] = minPoint;
			if (0 != (i & 0x01)) localPosition[i].x += src.size.x;
			if (0 != (i & 0x02)) localPosition[i].y += src.size.y;
		}
		var result = localPosition.Select(x=>(Vector2)matrix.MultiplyPoint3x4(x))
									.ToArray();
		return result;
	}

	private static AxisPack2 GetExtentsAxisOfBox(BoxCollider2D src) {
		var vertices = GetVerticesOfBox(src);

		var directions = new[]{vertices[1] - vertices[0], vertices[2] - vertices[0]};
		var extents = directions.Select(x=>x * 0.5f)
								.ToArray();
		return new AxisPack2(extents[0], extents[1]);
	}

	private static Vector2 GetNearestPoint(Vector2 lhs, IEnumerable<Vector2> rhsVerticesCounterclockwise) {
		switch (rhsVerticesCounterclockwise.Count()) {
		case 0:
			throw new System.ArgumentException();
		case 1:
			return rhsVerticesCounterclockwise.First();
		case 2:
			{ //Segment & Point
				var rhsVertices = rhsVerticesCounterclockwise.ToArray();
				var rhsSegment = rhsVertices[1] - rhsVertices[0];
				var lhsRhs0 = lhs - rhsVertices[1];
				var progress = Vector2.Dot(rhsSegment, lhsRhs0) / rhsSegment.sqrMagnitude;
				return rhsVertices[0] + rhsSegment * progress;
			}
		default:
			return GetNearestPointConvexPolygon(lhs, rhsVerticesCounterclockwise);
		}
	}

	private static float GetSqrDistance(Vector2 lhs, IEnumerable<Vector2> rhsVerticesCounterclockwise) {
		var rhsNearest = GetNearestPoint(lhs, rhsVerticesCounterclockwise);
		var distance = lhs - rhsNearest;
		return distance.sqrMagnitude;
	}

	private static Vector2 GetNearestPointConvexPolygon(Vector2 lhs, IEnumerable<Vector2> rhsVerticesCounterclockwise) {
		var rhsVerticesEnumerator = rhsVerticesCounterclockwise.GetEnumerator();
		rhsVerticesEnumerator.MoveNext();
		var firstVertex = rhsVerticesEnumerator.Current;
		var crntVertex = firstVertex;
		var doubtVertexNearest = false;

		rhsVerticesEnumerator.MoveNext();
		var secondVertex = rhsVerticesEnumerator.Current;
		do {
			var nextVertex = rhsVerticesEnumerator.Current;

			var nextCrnt = nextVertex - crntVertex;
			var lhsCrnt = lhs - crntVertex;
			var dotValue = Vector2.Dot(nextCrnt, lhsCrnt);
			if (0.0f <= dotValue) {
				if (Vector2PrepDot(nextCrnt, lhsCrnt) <= 0.0f) {
					//out
					var nextCrntSqrLength = nextCrnt.sqrMagnitude;
					if (dotValue <= nextCrntSqrLength) {
						//Segment & Point
						var progress = dotValue / nextCrntSqrLength;
						return crntVertex + nextCrnt * progress;
					} else {
						doubtVertexNearest = true;
					}
				}
			} else if (doubtVertexNearest) {
				return crntVertex;
			}

			crntVertex = nextVertex;
		} while (rhsVerticesEnumerator.MoveNext());

		if (doubtVertexNearest) {
			var nextCrnt = secondVertex - firstVertex;
			var lhsCrnt = lhs - firstVertex;
			var dotValue = Vector2.Dot(nextCrnt, lhsCrnt);
			if (dotValue < 0.0f) {
				return firstVertex;
			}
		}

		return lhs;
	}

	private static float GetSqrDistanceConvexPolygon(Vector2 lhs, IEnumerable<Vector2> rhsVerticesCounterclockwise) {
		var rhsNearest = GetNearestPointConvexPolygon(lhs, rhsVerticesCounterclockwise);
		var distance = lhs - rhsNearest;
		return distance.sqrMagnitude;
	}
	#endregion
}
