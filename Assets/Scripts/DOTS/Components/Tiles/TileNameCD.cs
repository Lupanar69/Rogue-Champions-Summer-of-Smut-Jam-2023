using Unity.Collections;
using Unity.Entities;

/// <summary>
/// Le nom de la case
/// </summary>
public struct TileNameCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// Le nom de la case
    /// </summary>
    public FixedString64Bytes Value;

    #endregion
}
