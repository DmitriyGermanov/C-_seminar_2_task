namespace Task_00
{
    internal class Bits
    {
        private long data;
        public long Data { get => data; private set => data = value; }

        public Bits(long data) => this.data = data;
        public static implicit operator Bits(int value) => new Bits(value);
        public static implicit operator Bits(byte value) => new Bits(value);
        public static implicit operator Bits(long value) => new Bits(value);

        public override string? ToString() => data.ToString();
    }
}