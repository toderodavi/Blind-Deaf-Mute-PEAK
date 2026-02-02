using System;
using System.Collections.Generic;
using System.Text;

namespace BlindDeafMutePEAK
{   
    // Enum is a type that represents a set of named constants
    // In this case, the possible Role for a player is 0, 1 or 2.
    // Making it public makes it acessable in any part of the project
    public enum Role
    {
        Blind = 0,
        Deaf = 1,
        Mute = 2,
    }
}
