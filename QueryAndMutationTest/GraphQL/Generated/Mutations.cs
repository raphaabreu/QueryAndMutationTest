using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace QueryAndMutationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Mutations
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            49,
            55,
            102,
            101,
            99,
            55,
            57,
            51,
            56,
            101,
            100,
            49,
            55,
            54,
            53,
            97,
            55,
            53,
            50,
            57,
            102,
            55,
            57,
            101,
            56,
            98,
            49,
            98,
            53,
            99,
            102,
            55
        };
        private readonly byte[] _content = new byte[]
        {
            109,
            117,
            116,
            97,
            116,
            105,
            111,
            110,
            32,
            83,
            101,
            116,
            67,
            111,
            117,
            110,
            116,
            40,
            36,
            99,
            111,
            117,
            110,
            116,
            58,
            32,
            73,
            110,
            116,
            33,
            41,
            32,
            123,
            32,
            115,
            101,
            116,
            67,
            111,
            117,
            110,
            116,
            40,
            118,
            97,
            108,
            117,
            101,
            58,
            32,
            36,
            99,
            111,
            117,
            110,
            116,
            41,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Mutations Default { get; } = new Mutations();

        public override string ToString() => 
            @"mutation SetCount($count: Int!) {
              setCount(value: $count)
            }";
    }
}
