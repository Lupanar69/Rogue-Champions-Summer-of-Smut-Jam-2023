using Unity.Entities;

/// <summary>
/// La liste des cases sur cette cellule
/// </summary>
public struct CellTilesBE : IBufferElementData
{
    #region Variables d'instance

    /// <summary>
    /// L'entité Cell de la carte
    /// </summary>
    public Entity Value;

    #endregion
}
