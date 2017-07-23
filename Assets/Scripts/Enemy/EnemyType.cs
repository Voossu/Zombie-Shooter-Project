using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type {
	BIO,
	MECH
}

public class EnemyType: MonoBehaviour {
	public Type type;
}