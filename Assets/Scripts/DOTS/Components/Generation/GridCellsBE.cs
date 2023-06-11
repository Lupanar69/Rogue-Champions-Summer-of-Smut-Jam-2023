using Unity.Entities;

/// <summary>
/// La liste ordonn�e des cellules de la grille.
/// </summary>
public struct GridCellsBE : IBufferElementData
{
    #region Variables d'instance

    /// <summary>
    /// L'entit� Cell de la carte
    /// </summary>
    public Entity Value;

    #endregion
}