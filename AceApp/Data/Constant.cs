using System.ComponentModel.DataAnnotations;

namespace AceApp.Data
{
    public enum LossType
    {
        None,
        Collision,
        Comprehensive,
        PropertyDamage,
        UninsuredMotorist
    }
    public enum PolicyType
    {
        ReplacementCost,
        ACV
    }
    public enum ClaimType
    {
        AUTO,
        SUBROGATION,
        SPECIALTY,
        PROPERTY,
        TOTALLOSS,
        PHOTOQUOTE
    }
    public class Constant
    {
        public static readonly string[] LossTypeNames = { "None", "Collision", "Comprehensive", "Property Damage", "UninsureMotorist" };
        public static readonly string[] PolicyTypeNames = { "Replacement Cost", "ACV" };
        public static readonly string[] PowerOptionNames = { "Steering", "Brakes", "Windows", "Locks", "Driver Seat", "Pass Seat", "Antenna", "Mirrors", "Trunck" };
        public static readonly string[] RadioNames = { "AM", "FM", "Stereo", "Cassette", "Seek/Scan", "Equalizer", "CD Player", "CB Radio" };
        public static readonly string[] SeatsNames = { "Cloth", "Leather", "Third", "Buckets", "Ecline/Lounge", "Hiback Buckets", "Rear Buckets", "Recaro", "Split Bench" };
        public static readonly string[] DecorNames = { "Tinted Glass", "Bodyside Moulding", "Woodgrain", "Bumper cushings", "Bumper Guards", "Dual Mirrors", "Custom Int.", "Luxury Interior", "Privacy Glass", "Roof Console" };
        public static readonly string[] SafetyNames = { "Antilock Brakes (4)", "Antilock Brakes (2)", "Auto Restraint", "Driver Airbag", "Pass Airbag", "4 Wl Disc Brakes", "Roll Bar", "Positraction" };
        public static readonly string[] WheelsNames = { "Aluminum", "Wire", "Wire Covers", "Styled Steel", "Alloy", "Spoke Aluminum", "Locking Covers", "Locking Wheels" };
        public static readonly string[] ConvenienceNames = { "Air Conditioning", "Rear Defogger", "Tilt Wheel", "Telescopic Wheel", "Intermittent Wipers", "Aux Fuel Tank", "Auto Level", "Climate Control", "Electronic Inst. Panel", "R Window Wiper", "Theft Alarm", "Fog Lights" };
        public static readonly string[] RoofNames = { "Vinyl", "Landau", "Luggage Rf Rack", "Padded Vinyl", "Padded Landau", "Cabriolet", "Elec Steel Sunrf", "Elec Glass Sunrf", "Man Steel Sunrf", "Man Glass Sunrf", "Glass T-Tops", "T-Top", "Flip Roof" };
        public static readonly string[] PaintNames = { "Clear Coat Paint", "Two Tone Paint", "Three Stage Paint", "Metallic", "Custom" };
        public static readonly string[] TruckNames = { "Rear Step Bumper", "Sliding R Window", "Running Boards", "Bedliner/Duraliner", "Chrome Bed", "Tool Box", "Grille Guards", "Dual Rear Wheels", "Trailering Package", "Dual A/C" };
        public static readonly string[] MotorcycleNames = { "Header", "Full Fairing", "Plexiglass", "Custom Seats", "Saddle Bags", "Travel Trunk", "Engine Guard", "Back Rest", "Cruise Control", "Luggage Rack" };
        public static readonly string[] StateNames =
        {
            "Alabama",
            "Alaska",
            "American Samoa",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "District of Columbia",
            "Federated States of Micronesia",
            "Florida",
            "Georgia",
            "Guam",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Marchall Islands",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Northern Mariana Islands",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Palau",
            "Pennsylvania",
            "Puerto Rico",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virgin Islands",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"
        };
        public static readonly string[] StateValues =
        {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FM",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MH",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PW",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VI",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"
        };
    }

}
