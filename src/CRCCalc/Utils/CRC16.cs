using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCCalc
{
    public enum ECrcInitialValue
    {
        Zeros = 0x0000,
        NonZero1 = 0xffff,
        NonZero2 = 0x1D0F
    }

    public enum ECrcPolynomial
    {
        CRC16_ARINC = 0xA02B,       // ACARS applications
        CRC16_CCITT = 0x1021,       // X.25, V.41, HDLC FCS, XMODEM, Bluetooth, PACTOR, SD, DigRF, many others; known as CRC-CCITT
        CRC16_CDMA2000 = 0xC867,    // mobile networks
        CRC16_DECT = 0x0589,        // cordless telephones
        CRC16_T10_DIF = 0x8BB7,     // SCSI DIF
        CRC16_DNP = 0x3D65,         // DNP, IEC 870, M-Bus
        CRC16_IBM = 0x8005,         // Bisync, Modbus, USB, ANSI X3.28, SIA DC-07, many others; also known as CRC-16 and CRC-16-ANSI
    }

    public class CRC16
    {
        private ushort[] table = new ushort[256];

        public bool Reflected { get; set; }
        public ECrcInitialValue CrcInitialValue { get; set; }

        private ECrcPolynomial crcPolynomial;
        public ECrcPolynomial CrcPolynomial
        {
            get
            {
                return this.crcPolynomial;
            }
            set
            {
                this.crcPolynomial = value;
                UpdateLookupTable();
            }
        }

        public ushort GetChecksum(byte[] bytes)
        {
            ushort crc = (ushort)this.CrcInitialValue;
            for (int i = 0; i < bytes.Length; i++)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
            }
            if (this.Reflected)
                return ReflectValue(crc);
            return crc;
        }

        public byte[] GetChecksumBytes(byte[] bytes)
        {
            ushort crc = GetChecksum(bytes);
            return new byte[] { (byte)(crc >> 8), (byte)(crc & 0x00ff) };
        }

        public CRC16(ECrcInitialValue initialValue, ECrcPolynomial polynomial, bool reflected)
        {
            this.CrcInitialValue = initialValue;
            this.CrcPolynomial = polynomial;
            this.Reflected = reflected;

            UpdateLookupTable();
        }

        private ushort ReflectValue(ushort value)
        {
            uint result = 0;

            // Swap bit 0 for bit 7
            // bit 1 for bit 6, etc.
            for (int i = 0; i < 16; i++)
            {
                uint tmp = value & 1U;
                int j = 16 - i - 1;

                if (tmp != 0)
                    result |= 1U << j;

                value >>= 1;
            }

            return (ushort)result;
        }

        private void UpdateLookupTable()
        {
            ushort poly = (ushort)this.CrcPolynomial;

            ushort temp, a;

            for (int i = 0; i < table.Length; i++)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; j++)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                    {
                        temp = (ushort)((temp << 1) ^ poly);
                    }
                    else
                    {
                        temp <<= 1;
                    }
                    a <<= 1;
                }
                table[i] = temp;
            }

        }
    }
}
