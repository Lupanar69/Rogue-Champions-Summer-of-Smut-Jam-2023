using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// La position du centre de la salle
/// </summary>
public struct RoomPositionCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// La position du centre de la salle
    /// </summary>
    public int2 Value;

    #endregion
}
