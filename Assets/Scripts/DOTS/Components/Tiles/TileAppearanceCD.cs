using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// L'apparence de la case à l'écran
/// </summary>
public struct TileAppearanceCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// La couleur de la case
    /// </summary>
    public float4 Color;

    /// <summary>
    /// Le caractère de la case
    /// </summary>
    public char Char;

    #endregion
}
