﻿public partial class ZC {

    [PacketHandler(HEADER, "ZC_PARTY_CONFIG", SIZE)]
    public class PARTY_CONFIG : InPacket {

        public const PacketHeader HEADER = PacketHeader.ZC_PARTY_CONFIG;
        public const int SIZE = 3;

        public bool Read(BinaryReader br) {
            return true;
        }
    }
}
