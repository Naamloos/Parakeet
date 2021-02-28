using System;
using System.Collections.Generic;
using System.Text;

namespace Parakeet.Attributes
{
    // Up for consideration: automatically generate packet IDs based on eg alfabetical name (type.tostring?)
    public class PacketAttribute : Attribute
    {
        public int Id { get; private set; }

        public PacketAttribute(int id)
        {
            Id = id;
        }
    }
}
