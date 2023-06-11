using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// Les coordonnées de début et fin du couloir
/// </summary>
public struct HallwayStartEndCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// Le début du couloir
    /// </summary>
    public int2 Start;

    /// <summary>
    /// La fin du couloir
    /// </summary>
    public int2 End;

    #endregion
}
