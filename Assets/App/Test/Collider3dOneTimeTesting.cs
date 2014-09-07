using UnityEngine;
using System.Collections;

public class Collider3dOneTimeTesting : MonoBehaviour {
	public Collider		m_A;
	public Collider		m_B;
	public Condition	m_Pass = Condition.Hit;

	public enum Condition {
		Hit,
		NoHit,
		ThrowSystemArgumentNullException,
		ThrowUnknownColliderException,
		ThrowSystemNotImplementedException,
	}
	
	// Update is called once per frame
	void Update() {
		try {
			if (ColliderIsHitExtention.IsHit(m_A, m_B)) {
				Pass(Condition.Hit);
			} else {
				Pass(Condition.NoHit);
			}
		} catch (ColliderIsHitExtention.UnknownColliderException) {
			Pass(Condition.ThrowUnknownColliderException);
		} catch (System.ArgumentException) {
			Pass(Condition.ThrowSystemArgumentNullException);
		} catch (System.NotImplementedException) {
			Pass(Condition.ThrowSystemNotImplementedException);
		} catch {
			IntegrationTest.Fail(gameObject);
		}
	}

	private void Pass(Condition cond) {
		if (cond == m_Pass) {
			IntegrationTest.Pass(gameObject);
		} else {
			IntegrationTest.Fail(gameObject);
		}
	}
}
