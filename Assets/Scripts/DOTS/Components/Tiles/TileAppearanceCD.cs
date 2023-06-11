using Unity.Entities;
using Unity.Mathematics;

/// <summary>
/// L'apparence de la case � l'�cran
/// </summary>
public struct TileAppearanceCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// La couleur de la case
    /// </summary>
    public float4 Color;

    /// <summary>
    /// Le caract�re de la case
    /// </summary>
    public char Char;

    #endregion
}
