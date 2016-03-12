// (C) 2014 ERAL
// Distributed under the Boost Software License, Version 1.0.
// (See copy at http://www.boost.org/LICENSE_1_0.txt)


using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public partial class ColliderIsHitExtention : MonoBehaviour {

	public class UnknownColliderException: System.NotImplementedException {
		public UnknownColliderException(): base() {}
		public UnknownColliderException(string message): base(message) {}
		public UnknownColliderException(string message, System.Exception innerException): base(message, innerException) {}
	}
}
