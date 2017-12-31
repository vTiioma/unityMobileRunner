using System.Collections;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T> {

	private static T reference;
	public static T instance {
		get {
			return reference;
		}
	}

	public static bool isInitialized {
		get {
			return reference != null;
		}
	}

	protected virtual void Awake () {
		if (isInitialized) {
			Debug.LogErrorFormat ("Trying to instantiate a second instance of singleton class {0}!", GetType ().Name);
		} else {
			reference = (T)this;
		}
	}

	protected virtual void OnDestroy () {
		if (reference == this) {
			reference = null;
		}
	}
}
