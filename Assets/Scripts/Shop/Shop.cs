using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShopType {
	AMMO,
	WEAPON_MP5K,
	WEAPON_AKM,
	WEAPON_M870,
	UPGRADE_DAMAGE,
	UPGRADE_MAGAZINE,
	UPGRADE_MAX_AMMO,
	UPGRADE_RANGE,
	UPGRADE_RECOIL,
	UPGRADE_RELOAD,
	UPGRADE_STEADY
};

public class Shop : MonoBehaviour {
	public ShopType shopType;
	public string title;
	public string description;
	public int price;
}
