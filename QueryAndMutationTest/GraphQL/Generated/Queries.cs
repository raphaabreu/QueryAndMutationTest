using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace QueryAndMutationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
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
            97,
            50,
            49,
            100,
            57,
            50,
            49,
            100,
            102,
            49,
            54,
            50,
            102,
            54,
            100,
            99,
            48,
            99,
            102,
            51,
            50,
            101,
            53,
            100,
            50,
            53,
            97,
            55,
            49,
            55,
            56,
            99
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            71,
            101,
            116,
            67,
            111,
            117,
            110,
            116,
            32,
            123,
            32,
            99,
            111,
            117,
            110,
            116,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query GetCount {
              count
            }";
    }
}
