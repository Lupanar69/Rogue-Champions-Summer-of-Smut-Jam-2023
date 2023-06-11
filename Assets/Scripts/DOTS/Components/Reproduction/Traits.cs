using Unity.Entities;

/// <summary>
/// Une liste d'IDs indiquant quels traits du personnage sont dominants, neutres ou faibles.
/// L'ID n°0 est toujours celui du trait mental.
/// </summary>
[InternalBufferCapacity(8)]
public struct TraitDominanceLevelBE : IBufferElementData
{
    #region Variables d'instance

    /// <summary>
    /// 0: Faible ; 1: neutre ; 2 : Dominant
    /// </summary>
    public int Value;

    #endregion
}

/// <summary>
/// La personnalité du personnage.
/// Utilisé pour le calcul des stats.
/// </summary>
public struct MentalTraitCD : IComponentData
{
    #region Variables d'instance

    /// <summary>
    /// Le type du trait mental
    /// </summary>
    public MentalTraitType Value;

    #endregion
}

/// <summary>
/// Les traits physiques du personnage.
/// Utilisé pour le calcul des stats.
/// </summary>
[InternalBufferCapacity(7)]
public struct PhysicalTraitBE : IBufferElementData
{
    #region Variables d'instance

    /// <summary>
    /// Le type du trait physique
    /// </summary>
    public PhysicalTraitType Type;

    /// <summary>
    /// La variante du trait physique
    /// </summary>
    public int Variant;

    #endregion
}