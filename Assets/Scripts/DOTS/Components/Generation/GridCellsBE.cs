using Unity.Entities;

/// <summary>
/// La liste ordonnée des cellules de la grille.
/// </summary>
public struct GridCellsBE : IBufferElementData
{
    #region Variables d'instance

    /// <summary>
    /// L'entité Cell de la carte
    /// </summary>
    public Entity Value;

    #endregion
}