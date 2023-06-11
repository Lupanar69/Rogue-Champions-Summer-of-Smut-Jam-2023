using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// Les coordonn�es de d�but et fin du couloir
/// </summary>
public struct HallwayStartEndCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// Le d�but du couloir
    /// </summary>
    public int2 Start;

    /// <summary>
    /// La fin du couloir
    /// </summary>
    public int2 End;

    #endregion
}
