namespace RodecoRADI.Core.Persistance.Models
{
    public enum AxleShape
    {
        straight,
        left_transition_curve,
        right_transition_curve,
        left_circular_curve,
        right_circular_curve,
        s_curve
    }

    public enum AlignmentShape
    {
        one_sided_inclination,
        concave_curve,
        convex_curve
    }

    public enum PavementTransverseFall
    {
        one_sided,
        two_sided,
        warp,
        not_exist
    }

    public enum GalleryMaterial
    {
        reinforcedConcrete,
        steel
    }

    public enum DrainageSystem
    {
        side_ditch,
        sewerage_system,
        free_fall
    }
    
    public enum PavementMaterial
    {
        asphalt,
        concrete
    }
    
    public enum PedestrianWayMaterial
    {
        pouredAsphalt,
        asphalt,
        concrete,
        concreteCubes
    }
    
    public enum Installations
    {
        electrical,
        telecommunication,
        water,
        not_exist
    }
}
