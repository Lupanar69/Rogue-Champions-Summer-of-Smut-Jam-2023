using Unity.Entities;

/// <summary>
/// Le type de la case (Sol, mur, personnage, etc...)
/// </summary>
public struct TileTypeCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// Le type de la case (Sol, mur, personnage, etc...)
    /// </summary>
    public int Value;

    #endregion
}
