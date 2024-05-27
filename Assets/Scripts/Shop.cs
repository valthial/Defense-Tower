using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileTurret;
    public TurretBlueprint laserBeamer;

    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }
  public void SelectStandartTurret ()
    {
        Debug.Log("Select standard");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("Select MissileLauncher");
        buildManager.SelectTurretToBuild(missileTurret);
    }
    public void SelectlaserBeamer()
    {
        Debug.Log("Select Laser Beamer");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
