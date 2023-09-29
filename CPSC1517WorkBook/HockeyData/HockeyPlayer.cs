namespace Hockey.Data
{
    public class HockeyPlayer
    {
        // data fields
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInPounds;

        // private Position _position;
        // private Shot _shot;


        //properties
        public string BirthPlace 
        {
            get
            {
                return _birthPlace;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");
                }

                // if we get here, then no exception is happened. Else can be used howeve, it's redundant because there's only one branch of execution. Either an excpetion is thrown or the value is valid and is inputted into the _birthplace.
                _birthPlace = value;
            }
        }
        // TODO: Complete the remaining string properties

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name cannot be null or empty.");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last Name cannot be null or empty.");
                }

                _lastName = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive.");
                }
                _heightInInches = value;
            }
        }
        // TODO: Complete the remaining int property
        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be positive.");
                }
                _weightInPounds = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Now))
                {
                    throw new ArgumentException("Date of birth cannot be in the future.")
                }
                _dateOfBirth = value;
            }

        }
        
        public Position Position { get; set; }

        public Shot Shot { get; set; }
        //constructors

        /// <summary>
        /// Creates a default instance of a Hockey Player
        /// </summary>
        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _heightInInches = 0;
            _weightInPounds = 0;
            Shot = Shot.Left;
            Position = Position.Center;
        }
        
        
        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly DateOfBirth, int weightInPounds, int heightInInches, Position position, Shot shot)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
            HeightInInches = heightInInches;
            WeightInPounds = weightInPounds;
            DateOfBirth = dateOfBirth;
            Position = position;
            Shot = shot;
        }
    }
}