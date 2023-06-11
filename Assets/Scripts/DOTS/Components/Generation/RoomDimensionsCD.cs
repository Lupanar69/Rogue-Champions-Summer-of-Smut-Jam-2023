using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// La longueur et largeur de la salle
/// </summary>
public struct RoomDimensionsCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// La longueur et largeur de la salle
    /// </summary>
    public int2 Value;

    #endregion
}
