using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// Les coordonnées de la cellule sur la grille
/// </summary>
public struct CellPositionCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// Les coordonnées de la cellule sur la grille
    /// </summary>
    public int2 Value;

    #endregion
}
