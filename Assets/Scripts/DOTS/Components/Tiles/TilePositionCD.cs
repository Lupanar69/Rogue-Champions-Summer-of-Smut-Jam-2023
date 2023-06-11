using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// Les coordonnées de la case sur la grille
/// </summary>
public struct TilePositionCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// Les coordonnées de la case sur la grille
    /// </summary>
    public int2 Value;

    #endregion
}
