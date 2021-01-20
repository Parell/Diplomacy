using UnityEngine;

[CreateAssetMenu(fileName = "SaveData")]
public class SaveData : ScriptableObject
{
    public string countryName;
    public int points = 20;
    public float pointsPerTurn;
    public int turn; // 3 months
    [Space]
    public float health;
    public float unemployment;
    public float crime;
    public float education;
    public float poverty;
    public int population;
    [Header("Economy")]
    public float income;
    public float expenditure;
    public float debt;
    public float emissions;
    public float cleanEnergy; // %
    public float agricultureUsage;
    public float agricultureProcuction;
    public float agricultureEfficiency;
    public float energyUsage;
    public float energyProcuction;
    public float energyEfficiency;    
    public float waterUsage;
    public float waterProcuction;
    public float waterEfficiency;
    [Space]
    public bool agricultureSubsidies;
    public bool verticalFarmSubsidies;
    public bool cityFarms;
    public bool carbonCaptureAndStorage;
    public bool ecoHomeRegulations;
    public bool greenElectronicsSubsidies;
    public bool spaceProgram;
    [Header("Transportation")]
    public float trafficCongestion;
    public float railUsage;
    public float carUsage;
    public float busUsage;
    public float bicycleUsage;
    public float planeUsage;
    [Space]
    public bool biofuelSubsidies;
    public bool busSubsidies;
    public bool bicycleSubsidies;
    public bool electricCarSubsidies;
    public bool driverlessCarLaws;
}
