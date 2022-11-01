namespace RodecoRADI.Core.Persistance.Models
{
    //public enum AxleShape
    //{
    //    straight,
    //    left_transition_curve,
    //    right_transition_curve,
    //    left_circular_curve,
    //    right_circular_curve,
    //    s_curve
    //}

    //public enum AlignmentShape
    //{
    //    one_sided_inclination,
    //    concave_curve,
    //    convex_curve
    //}

    //public enum PavementTransverseFall
    //{
    //    one_sided,
    //    two_sided,
    //    warp,
    //    not_exist
    //}

    //public enum GalleryMaterial
    //{
    //    reinforcedConcrete,
    //    steel
    //}

    //public enum DrainageSystem
    //{
    //    side_ditch,
    //    sewerage_system,
    //    free_fall
    //}

    //public enum PavementMaterial
    //{
    //    asphalt,
    //    concrete
    //}

    //public enum PedestrianWayMaterial
    //{
    //    pouredAsphalt,
    //    asphalt,
    //    concrete,
    //    concreteCubes
    //}

    //public enum Installations
    //{
    //    electrical,
    //    telecommunication,
    //    water,
    //    not_exist
    //}


    //public enum LiningMaterial
    //{
    //    concrete,
    //    reinforced_concrete,
    //    sprayed_concrete,
    //    not_exist
    //}

    //public enum DrainageSystem
    //{

    //}

    //public enum PavementMaterial
    //{

    //}

    //public enum PedestrianWayMaterial
    //{

    //}

    //public enum TunnelVentilation
    //{

    //}

    //public enum TunnelInstallations
    //{

    //}

    public enum TunnelVentilation
    {
        natural,
        single_row_fan,
        double_row_fan,
    }

    public enum TunnelLiningMaterial
    {
        concrete,
        reinforced_concrete,
        sprayed_concrete,
        not_exist,
    }

    public enum TunnelPedestrianWayMaterial
    {
        poured_asphalt,
        asphalt,
        concrete,
        concrete_cubes,
    }

	public enum BridgePedestrianWaysCover
    {
        molten_asphalt,
        asphalt,
        wood,
        no_cover,
    }

    public enum BridgeFacilityType
    {
        bridge,
        viaduct,
        overpass,
        overpass_over_road,
        semi_object,
        other,
    }

    public enum BridgeStaticSystem
    {
        single_span_beam,
        cantilever_beam,
        continuous_girder,
        arch,
        series_of_the_arches,
        gerber_girder,
        series_of_single_span_beams,
        frame_girder,
        concrete_stone_vault,
        series_of_the_vaults,
        suspension_bridge,
        other,
    }

    public enum BridgeCrossSectionType
    {
        solid_slab,
        hollow_slab,
        tt_girder,
        truss_girder,
        composite_tt,
        other,
    }

    public enum BridgePedestrianSeparation
    {
        stone_concrete_steel_wood_curbs,
        traffic_barrier,
        not_exist,
    }

    public enum BridgeTrafficBarriers
    {
        steel,
        concrete,
        not_exist,
    }

    public enum BridgePedestrianFences
    {
        steel,
        concrete_solid,
        concrete_with_holes,
        wood,
        not_exist,
        other,
    }

    public enum BridgeConstructionMethod
    {
        classic_classic,
        classic_prefabricated,
        prefabricated_prefabricated,
        classic_console,
        by_thrust,
        segmental,
        unknown,
        other,
    }

    public enum BridgePavementMaterial
    {
        asphalt,
        concrete,
        molten_asphalt,
        wood,
        gravel,
        stone_cubes,
    }

    public enum BridgeSuperstructureMaterial
    {
        concrete,
        reinforced_concrete,
        prestressed_concrete,
        steel,
        composite_steel_concrete,
        stone,
        wood,
    }

    public enum BridgeAlignmentShape
    {
        slope_less_2,
        slope_more_2,
        concave_curve,
        convex_curve,
    }

    public enum BridgeSupportType
    {
        classic_steel,
        steel,
        concrete_swings,
        rail_plate,
        neoprene,
        direct_reliance,
        other,
    }

    public enum BridgeWaterproofing
    {
        bitumen_coating,
        bitumen_tape,
        mastix,
        isotex,
        not_exist,
        unknown,
    }

    public enum BridgeFoundation
    {
        directly,
        nailed_pillars,
        drilled_pillars,
        wells_boxes,
        caisson,
        unknown,
    }

    public enum BridgeDilatationDevices
    {
        copper,
        sliding_steel,
        steel_combs,
        neoprene,
        asphalt,
        not_exist,
        the_system_does_not_require,
    }

    public enum WallType
    {
        o_cladding,
        retaining,
        retaining_cladding,
    }

    public enum WallLocation
    {
        left,
        right
    }

    public enum WallLocationCrossSection
    {
        long_ditch,
        in_the_shoulder,
        embankment_toe,
    }

    public enum WallMaterial
    {
        stone,
        concrete,
        reinforced_concrete,
        sprayed_concrete,
        gabion,
    }

    public enum WallFoundation
    {
        shallow,
        on_the_contrafores,
        pillars,
    }

    public enum SidewalkStructureMaterial
    {
        reinforced_concrete,
        steel,
    }

    public enum GalleryMaterial
    {
        reinforcedConcrete,
        steel,
    }

    public enum GalleryPedestrianWayMaterial
    {
        pouredAsphalt,
        asphalt,
        concrete,
        concreteCubes,
    }

    public enum PavementTransverseFall
    {
        one_sided,
        two_sided,
        warp,
        not_exist,
    }

    public enum PavementMaterial
    {
        asphalt,
        concrete
    }

    public enum Installations
    {
        electrical,
        telecommunication,
        water,
        not_exist,
    }

    public enum AxleShape
    {
        straight,
        left_transition_curve,
        right_transition_curve,
        left_circular_curve,
        right_circular_curve,
        s_curve,
    }

    public enum AlignmentShape
    {
        one_sided_inclination,
        concave_curve,
        convex_curve,
    }

    public enum DrainageSystem
    {
        side_ditch,
        sewerage_system,
        free_fall,
    }

    public enum BridgeDrainageSystem
    {
        water_inlets,
        sewerage_system,
        free_fall,
    }
}
