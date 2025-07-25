// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
    /// <summary>Provides access to X86 AVX512BW hardware instructions via intrinsics.</summary>
    [Intrinsic]
    [CLSCompliant(false)]
    public abstract class Avx512BW : Avx512F
    {
        internal Avx512BW() { }

        /// <summary>Gets a value that indicates whether the APIs in this class are supported.</summary>
        /// <value><see langword="true" /> if the APIs are supported; otherwise, <see langword="false" />.</value>
        /// <remarks>A value of <see langword="false" /> indicates that the APIs will throw <see cref="PlatformNotSupportedException" />.</remarks>
        public static new bool IsSupported { get => IsSupported; }

        /// <summary>Provides access to the x86 AVX512BW+VL hardware instructions via intrinsics.</summary>
        [Intrinsic]
        public new abstract class VL : Avx512F.VL
        {
            internal VL() { }

            /// <summary>Gets a value that indicates whether the APIs in this class are supported.</summary>
            /// <value><see langword="true" /> if the APIs are supported; otherwise, <see langword="false" />.</value>
            /// <remarks>A value of <see langword="false" /> indicates that the APIs will throw <see cref="PlatformNotSupportedException" />.</remarks>
            public static new bool IsSupported { get => IsSupported; }

            /// <summary>
            ///   <para>__m128i _mm_cmpgt_epu8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(6)</para>
            /// </summary>
            public static Vector128<byte> CompareGreaterThan(Vector128<byte> left, Vector128<byte> right) => CompareGreaterThan(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmpge_epu8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(5)</para>
            /// </summary>
            public static Vector128<byte> CompareGreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmplt_epu8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(1)</para>
            /// </summary>
            public static Vector128<byte> CompareLessThan(Vector128<byte> left, Vector128<byte> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmple_epu8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(2)</para>
            /// </summary>
            public static Vector128<byte> CompareLessThanOrEqual(Vector128<byte> left, Vector128<byte> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmpne_epu8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8(4)</para>
            /// </summary>
            public static Vector128<byte> CompareNotEqual(Vector128<byte> left, Vector128<byte> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m256i _mm256_cmpgt_epu8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(6)</para>
            /// </summary>
            public static Vector256<byte> CompareGreaterThan(Vector256<byte> left, Vector256<byte> right) => CompareGreaterThan(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmpge_epu8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(5)</para>
            /// </summary>
            public static Vector256<byte> CompareGreaterThanOrEqual(Vector256<byte> left, Vector256<byte> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmplt_epu8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(1)</para>
            /// </summary>
            public static Vector256<byte> CompareLessThan(Vector256<byte> left, Vector256<byte> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmple_epu8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(2)</para>
            /// </summary>
            public static Vector256<byte> CompareLessThanOrEqual(Vector256<byte> left, Vector256<byte> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmpne_epu8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8(4)</para>
            /// </summary>
            public static Vector256<byte> CompareNotEqual(Vector256<byte> left, Vector256<byte> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m128i _mm_cmpge_epi16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(5)</para>
            /// </summary>
            public static Vector128<short> CompareGreaterThanOrEqual(Vector128<short> left, Vector128<short> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmplt_epi16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(1)</para>
            /// </summary>
            public static Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmple_epi16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(2)</para>
            /// </summary>
            public static Vector128<short> CompareLessThanOrEqual(Vector128<short> left, Vector128<short> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmpne_epi16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8(4)</para>
            /// </summary>
            public static Vector128<short> CompareNotEqual(Vector128<short> left, Vector128<short> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m256i _mm256_cmpge_epi16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(5)</para>
            /// </summary>
            public static Vector256<short> CompareGreaterThanOrEqual(Vector256<short> left, Vector256<short> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmplt_epi16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(1)</para>
            /// </summary>
            public static Vector256<short> CompareLessThan(Vector256<short> left, Vector256<short> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmple_epi16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(2)</para>
            /// </summary>
            public static Vector256<short> CompareLessThanOrEqual(Vector256<short> left, Vector256<short> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmpne_epi16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8(4)</para>
            /// </summary>
            public static Vector256<short> CompareNotEqual(Vector256<short> left, Vector256<short> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m128i _mm_cmpge_epi8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(5)</para>
            /// </summary>
            public static Vector128<sbyte> CompareGreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmplt_epi8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(1)</para>
            /// </summary>
            public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmple_epi8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(2)</para>
            /// </summary>
            public static Vector128<sbyte> CompareLessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmpne_epi8 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8(4)</para>
            /// </summary>
            public static Vector128<sbyte> CompareNotEqual(Vector128<sbyte> left, Vector128<sbyte> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m256i _mm256_cmpge_epi8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(5)</para>
            /// </summary>
            public static Vector256<sbyte> CompareGreaterThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmplt_epi8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(1)</para>
            /// </summary>
            public static Vector256<sbyte> CompareLessThan(Vector256<sbyte> left, Vector256<sbyte> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmple_epi8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(2)</para>
            /// </summary>
            public static Vector256<sbyte> CompareLessThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmpne_epi8 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8(4)</para>
            /// </summary>
            public static Vector256<sbyte> CompareNotEqual(Vector256<sbyte> left, Vector256<sbyte> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m128i _mm_cmpgt_epu16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(6)</para>
            /// </summary>
            public static Vector128<ushort> CompareGreaterThan(Vector128<ushort> left, Vector128<ushort> right) => CompareGreaterThan(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmpge_epu16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(5)</para>
            /// </summary>
            public static Vector128<ushort> CompareGreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmplt_epu16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(1)</para>
            /// </summary>
            public static Vector128<ushort> CompareLessThan(Vector128<ushort> left, Vector128<ushort> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmple_epu16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(2)</para>
            /// </summary>
            public static Vector128<ushort> CompareLessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m128i _mm_cmpne_epu16 (__m128i a, __m128i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8(4)</para>
            /// </summary>
            public static Vector128<ushort> CompareNotEqual(Vector128<ushort> left, Vector128<ushort> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m256i _mm256_cmpgt_epu16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(6)</para>
            /// </summary>
            public static Vector256<ushort> CompareGreaterThan(Vector256<ushort> left, Vector256<ushort> right) => CompareGreaterThan(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmpge_epu16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(5)</para>
            /// </summary>
            public static Vector256<ushort> CompareGreaterThanOrEqual(Vector256<ushort> left, Vector256<ushort> right) => CompareGreaterThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmplt_epu16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(1)</para>
            /// </summary>
            public static Vector256<ushort> CompareLessThan(Vector256<ushort> left, Vector256<ushort> right) => CompareLessThan(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmple_epu16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(2)</para>
            /// </summary>
            public static Vector256<ushort> CompareLessThanOrEqual(Vector256<ushort> left, Vector256<ushort> right) => CompareLessThanOrEqual(left, right);
            /// <summary>
            ///   <para>__m256i _mm256_cmpne_epu16 (__m256i a, __m256i b)</para>
            ///   <para>  VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8(4)</para>
            /// </summary>
            public static Vector256<ushort> CompareNotEqual(Vector256<ushort> left, Vector256<ushort> right) => CompareNotEqual(left, right);

            /// <summary>
            ///   <para>__m128i _mm_cvtepi16_epi8 (__m128i a)</para>
            ///   <para>  VPMOVWB xmm1/m64 {k1}{z}, xmm2</para>
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector128<short> value) => ConvertToVector128Byte(value);
            /// <summary>
            ///   <para>__m128i _mm_cvtepi16_epi8 (__m128i a)</para>
            ///   <para>  VPMOVWB xmm1/m64 {k1}{z}, xmm2</para>
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector128<ushort> value) => ConvertToVector128Byte(value);
            /// <summary>
            ///   <para>__m128i _mm256_cvtepi16_epi8 (__m256i a)</para>
            ///   <para>  VPMOVWB xmm1/m128 {k1}{z}, ymm2</para>
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<short> value) => ConvertToVector128Byte(value);
            /// <summary>
            ///   <para>__m128i _mm256_cvtepi16_epi8 (__m256i a)</para>
            ///   <para>  VPMOVWB xmm1/m128 {k1}{z}, ymm2</para>
            /// </summary>
            public static Vector128<byte> ConvertToVector128Byte(Vector256<ushort> value) => ConvertToVector128Byte(value);
            /// <summary>
            ///   <para>__m128i _mm_cvtusepi16_epi8 (__m128i a)</para>
            ///   <para>  VPMOVUWB xmm1/m64 {k1}{z}, xmm2</para>
            /// </summary>
            public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<ushort> value) => ConvertToVector128ByteWithSaturation(value);
            /// <summary>
            ///   <para>__m128i _mm256_cvtusepi16_epi8 (__m256i a)</para>
            ///   <para>  VPMOVUWB xmm1/m128 {k1}{z}, ymm2</para>
            /// </summary>
            public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<ushort> value) => ConvertToVector128ByteWithSaturation(value);

            /// <summary>
            ///   <para>__m128i _mm_cvtepi16_epi8 (__m128i a)</para>
            ///   <para>  VPMOVWB xmm1/m64 {k1}{z}, zmm2</para>
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector128<short> value) => ConvertToVector128SByte(value);
            /// <summary>
            ///   <para>__m128i _mm_cvtepi16_epi8 (__m128i a)</para>
            ///   <para>  VPMOVWB xmm1/m64 {k1}{z}, zmm2</para>
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector128<ushort> value) => ConvertToVector128SByte(value);
            /// <summary>
            ///   <para>__m128i _mm256_cvtepi16_epi8 (__m256i a)</para>
            ///   <para>  VPMOVWB xmm1/m128 {k1}{z}, zmm2</para>
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<short> value) => ConvertToVector128SByte(value);
            /// <summary>
            ///   <para>__m128i _mm256_cvtepi16_epi8 (__m256i a)</para>
            ///   <para>  VPMOVWB xmm1/m128 {k1}{z}, zmm2</para>
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByte(Vector256<ushort> value) => ConvertToVector128SByte(value);
            /// <summary>
            ///   <para>__m128i _mm_cvtsepi16_epi8 (__m128i a)</para>
            ///   <para>  VPMOVSWB xmm1/m64 {k1}{z}, zmm2</para>
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<short> value) => ConvertToVector128SByteWithSaturation(value);
            /// <summary>
            ///   <para>__m128i _mm256_cvtsepi16_epi8 (__m256i a)</para>
            ///   <para>  VPMOVSWB xmm1/m128 {k1}{z}, zmm2</para>
            /// </summary>
            public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<short> value) => ConvertToVector128SByteWithSaturation(value);

            /// <summary>
            ///   <para>__m128i _mm_permutexvar_epi16 (__m128i idx, __m128i a)</para>
            ///   <para>  VPERMW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            /// <remarks>The native and managed intrinsics have different order of parameters.</remarks>
            public static Vector128<short> PermuteVar8x16(Vector128<short> left, Vector128<short> control) => PermuteVar8x16(left, control);
            /// <summary>
            ///   <para>__m128i _mm_permutexvar_epi16 (__m128i idx, __m128i a)</para>
            ///   <para>  VPERMW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            /// <remarks>The native and managed intrinsics have different order of parameters.</remarks>
            public static Vector128<ushort> PermuteVar8x16(Vector128<ushort> left, Vector128<ushort> control) => PermuteVar8x16(left, control);

            /// <summary>
            ///   <para>__m128i _mm_permutex2var_epi16 (__m128i a, __m128i idx, __m128i b)</para>
            ///   <para>  VPERMI2W xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            ///   <para>  VPERMT2W xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<short> PermuteVar8x16x2(Vector128<short> lower, Vector128<short> indices, Vector128<short> upper) => PermuteVar8x16x2(lower, indices, upper);
            /// <summary>
            ///   <para>__m128i _mm_permutex2var_epi16 (__m128i a, __m128i idx, __m128i b)</para>
            ///   <para>  VPERMI2W xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            ///   <para>  VPERMT2W xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<ushort> PermuteVar8x16x2(Vector128<ushort> lower, Vector128<ushort> indices, Vector128<ushort> upper) => PermuteVar8x16x2(lower, indices, upper);

            /// <summary>
            ///   <para>__m256i _mm256_permutexvar_epi16 (__m256i idx, __m256i a)</para>
            ///   <para>  VPERMW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            /// <remarks>The native and managed intrinsics have different order of parameters.</remarks>
            public static Vector256<short> PermuteVar16x16(Vector256<short> left, Vector256<short> control) => PermuteVar16x16(left, control);
            /// <summary>
            ///   <para>__m256i _mm256_permutexvar_epi16 (__m256i idx, __m256i a)</para>
            ///   <para>  VPERMW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            /// <remarks>The native and managed intrinsics have different order of parameters.</remarks>
            public static Vector256<ushort> PermuteVar16x16(Vector256<ushort> left, Vector256<ushort> control) => PermuteVar16x16(left, control);

            /// <summary>
            ///   <para>__m256i _mm256_permutex2var_epi16 (__m256i a, __m256i idx, __m256i b)</para>
            ///   <para>  VPERMI2W ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            ///   <para>  VPERMT2W ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<short> PermuteVar16x16x2(Vector256<short> lower, Vector256<short> indices, Vector256<short> upper) => PermuteVar16x16x2(lower, indices, upper);
            /// <summary>
            ///   <para>__m256i _mm256_permutex2var_epi16 (__m256i a, __m256i idx, __m256i b)</para>
            ///   <para>  VPERMI2W ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            ///   <para>  VPERMT2W ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<ushort> PermuteVar16x16x2(Vector256<ushort> lower, Vector256<ushort> indices, Vector256<ushort> upper) => PermuteVar16x16x2(lower, indices, upper);

            /// <summary>
            ///   <para>__m128i _mm_sllv_epi16 (__m128i a, __m128i count)</para>
            ///   <para>  VPSLLVW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<short> ShiftLeftLogicalVariable(Vector128<short> value, Vector128<ushort> count) => ShiftLeftLogicalVariable(value, count);
            /// <summary>
            ///   <para>__m128i _mm_sllv_epi16 (__m128i a, __m128i count)</para>
            ///   <para>  VPSLLVW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<ushort> ShiftLeftLogicalVariable(Vector128<ushort> value, Vector128<ushort> count) => ShiftLeftLogicalVariable(value, count);
            /// <summary>
            ///   <para>__m256i _mm256_sllv_epi16 (__m256i a, __m256i count)</para>
            ///   <para>  VPSLLVW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<short> ShiftLeftLogicalVariable(Vector256<short> value, Vector256<ushort> count) => ShiftLeftLogicalVariable(value, count);
            /// <summary>
            ///   <para>__m256i _mm256_sllv_epi16 (__m256i a, __m256i count)</para>
            ///   <para>  VPSLLVW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<ushort> ShiftLeftLogicalVariable(Vector256<ushort> value, Vector256<ushort> count) => ShiftLeftLogicalVariable(value, count);

            /// <summary>
            ///   <para>__m128i _mm_srav_epi16 (__m128i a, __m128i count)</para>
            ///   <para>  VPSRAVW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<short> ShiftRightArithmeticVariable(Vector128<short> value, Vector128<ushort> count) => ShiftRightArithmeticVariable(value, count);
            /// <summary>
            ///   <para>__m256i _mm256_srav_epi16 (__m256i a, __m256i count)</para>
            ///   <para>  VPSRAVW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<short> ShiftRightArithmeticVariable(Vector256<short> value, Vector256<ushort> count) => ShiftRightArithmeticVariable(value, count);

            /// <summary>
            ///   <para>__m128i _mm_srlv_epi16 (__m128i a, __m128i count)</para>
            ///   <para>  VPSRLVW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<short> ShiftRightLogicalVariable(Vector128<short> value, Vector128<ushort> count) => ShiftRightLogicalVariable(value, count);
            /// <summary>
            ///   <para>__m128i _mm_srlv_epi16 (__m128i a, __m128i count)</para>
            ///   <para>  VPSRLVW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<ushort> ShiftRightLogicalVariable(Vector128<ushort> value, Vector128<ushort> count) => ShiftRightLogicalVariable(value, count);
            /// <summary>
            ///   <para>__m256i _mm256_srlv_epi16 (__m256i a, __m256i count)</para>
            ///   <para>  VPSRLVW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<short> ShiftRightLogicalVariable(Vector256<short> value, Vector256<ushort> count) => ShiftRightLogicalVariable(value, count);
            /// <summary>
            ///   <para>__m256i _mm256_srlv_epi16 (__m256i a, __m256i count)</para>
            ///   <para>  VPSRLVW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<ushort> ShiftRightLogicalVariable(Vector256<ushort> value, Vector256<ushort> count) => ShiftRightLogicalVariable(value, count);

            /// <summary>
            ///   <para>__m128i _mm_dbsad_epu8 (__m128i a, __m128i b, int imm8)</para>
            ///   <para>  VDBPSADBW xmm1 {k1}{z}, xmm2, xmm3/m128</para>
            /// </summary>
            public static Vector128<ushort> SumAbsoluteDifferencesInBlock32(Vector128<byte> left, Vector128<byte> right, [ConstantExpected] byte control) => SumAbsoluteDifferencesInBlock32(left, right, control);
            /// <summary>
            ///   <para>__m256i _mm256_dbsad_epu8 (__m256i a, __m256i b, int imm8)</para>
            ///   <para>  VDBPSADBW ymm1 {k1}{z}, ymm2, ymm3/m256</para>
            /// </summary>
            public static Vector256<ushort> SumAbsoluteDifferencesInBlock32(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte control) => SumAbsoluteDifferencesInBlock32(left, right, control);
        }

        /// <summary>Provides access to the x86 AVX512BW hardware instructions, that are only available to 64-bit processes, via intrinsics.</summary>
        [Intrinsic]
        public new abstract class X64 : Avx512F.X64
        {
            internal X64() { }

            /// <summary>Gets a value that indicates whether the APIs in this class are supported.</summary>
            /// <value><see langword="true" /> if the APIs are supported; otherwise, <see langword="false" />.</value>
            /// <remarks>A value of <see langword="false" /> indicates that the APIs will throw <see cref="PlatformNotSupportedException" />.</remarks>
            public static new bool IsSupported { get => IsSupported; }
        }

        /// <summary>
        ///   <para>__m512i _mm512_abs_epi8 (__m512i a)</para>
        ///   <para>  VPABSB zmm1 {k1}{z}, zmm2/m512</para>
        /// </summary>
        public static Vector512<byte> Abs(Vector512<sbyte> value) => Abs(value);
        /// <summary>
        ///   <para>__m512i _mm512_abs_epi16 (__m512i a)</para>
        ///   <para>  VPABSW zmm1 {k1}{z}, zmm2/m512</para>
        /// </summary>
        public static Vector512<ushort> Abs(Vector512<short> value) => Abs(value);

        /// <summary>
        ///   <para>__m512i _mm512_add_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> Add(Vector512<sbyte> left, Vector512<sbyte> right) => Add(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_add_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> Add(Vector512<byte> left, Vector512<byte> right) => Add(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_add_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> Add(Vector512<short> left, Vector512<short> right) => Add(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_add_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> Add(Vector512<ushort> left, Vector512<ushort> right) => Add(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_adds_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDSB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> AddSaturate(Vector512<sbyte> left, Vector512<sbyte> right) => AddSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_adds_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDUSB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> AddSaturate(Vector512<byte> left, Vector512<byte> right) => AddSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_adds_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDSW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> AddSaturate(Vector512<short> left, Vector512<short> right) => AddSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_adds_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPADDUSW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> AddSaturate(Vector512<ushort> left, Vector512<ushort> right) => AddSaturate(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_alignr_epi8 (__m512i a, __m512i b, const int count)</para>
        ///   <para>  VPALIGNR zmm1 {k1}{z}, zmm2, zmm3/m512, imm8</para>
        /// </summary>
        public static Vector512<sbyte> AlignRight(Vector512<sbyte> left, Vector512<sbyte> right, [ConstantExpected] byte mask) => AlignRight(left, right, mask);
        /// <summary>
        ///   <para>__m512i _mm512_alignr_epi8 (__m512i a, __m512i b, const int count)</para>
        ///   <para>  VPALIGNR zmm1 {k1}{z}, zmm2, zmm3/m512, imm8</para>
        /// </summary>
        public static Vector512<byte> AlignRight(Vector512<byte> left, Vector512<byte> right, [ConstantExpected] byte mask) => AlignRight(left, right, mask);

        /// <summary>
        ///   <para>__m512i _mm512_avg_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPAVGB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> Average(Vector512<byte> left, Vector512<byte> right) => Average(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_avg_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPAVGW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> Average(Vector512<ushort> left, Vector512<ushort> right) => Average(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_blendv_epu8 (__m512i a, __m512i b, __m512i mask)</para>
        ///   <para>  VPBLENDMB zmm1 {k1}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> BlendVariable(Vector512<byte> left, Vector512<byte> right, Vector512<byte> mask) => BlendVariable(left, right, mask);
        /// <summary>
        ///   <para>__m512i _mm512_blendv_epi16 (__m512i a, __m512i b, __m512i mask)</para>
        ///   <para>  VPBLENDMW zmm1 {k1}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> BlendVariable(Vector512<short> left, Vector512<short> right, Vector512<short> mask) => BlendVariable(left, right, mask);
        /// <summary>
        ///   <para>__m512i _mm512_blendv_epi8 (__m512i a, __m512i b, __m512i mask)</para>
        ///   <para>  VPBLENDMB zmm1 {k1}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> BlendVariable(Vector512<sbyte> left, Vector512<sbyte> right, Vector512<sbyte> mask) => BlendVariable(left, right, mask);
        /// <summary>
        ///   <para>__m512i _mm512_blendv_epu16 (__m512i a, __m512i b, __m512i mask)</para>
        ///   <para>  VPBLENDMW zmm1 {k1}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> BlendVariable(Vector512<ushort> left, Vector512<ushort> right, Vector512<ushort> mask) => BlendVariable(left, right, mask);

        /// <summary>
        ///   <para>__m512i _mm512_broadcastb_epi8 (__m128i a)</para>
        ///   <para>  VPBROADCASTB zmm1 {k1}{z}, xmm2/m8</para>
        /// </summary>
        public static Vector512<byte> BroadcastScalarToVector512(Vector128<byte> value) => BroadcastScalarToVector512(value);
        /// <summary>
        ///   <para>__m512i _mm512_broadcastb_epi8 (__m128i a)</para>
        ///   <para>  VPBROADCASTB zmm1 {k1}{z}, xmm2/m8</para>
        /// </summary>
        public static Vector512<sbyte> BroadcastScalarToVector512(Vector128<sbyte> value) => BroadcastScalarToVector512(value);
        /// <summary>
        ///   <para>__m512i _mm512_broadcastw_epi16 (__m128i a)</para>
        ///   <para>  VPBROADCASTW zmm1 {k1}{z}, xmm2/m16</para>
        /// </summary>
        public static Vector512<short> BroadcastScalarToVector512(Vector128<short> value) => BroadcastScalarToVector512(value);
        /// <summary>
        ///   <para>__m512i _mm512_broadcastw_epi16 (__m128i a)</para>
        ///   <para>  VPBROADCASTW zmm1 {k1}{z}, xmm2/m16</para>
        /// </summary>
        public static Vector512<ushort> BroadcastScalarToVector512(Vector128<ushort> value) => BroadcastScalarToVector512(value);

        /// <summary>
        ///   <para>__m512i _mm512_cmpeq_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPEQB k1 {k2}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> CompareEqual(Vector512<byte> left, Vector512<byte> right) => CompareEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpgt_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8(6)</para>
        /// </summary>
        public static Vector512<byte> CompareGreaterThan(Vector512<byte> left, Vector512<byte> right) => CompareGreaterThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpge_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8(5)</para>
        /// </summary>
        public static Vector512<byte> CompareGreaterThanOrEqual(Vector512<byte> left, Vector512<byte> right) => CompareGreaterThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmplt_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8(1)</para>
        /// </summary>
        public static Vector512<byte> CompareLessThan(Vector512<byte> left, Vector512<byte> right) => CompareLessThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmple_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8(2)</para>
        /// </summary>
        public static Vector512<byte> CompareLessThanOrEqual(Vector512<byte> left, Vector512<byte> right) => CompareLessThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpne_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8(4)</para>
        /// </summary>
        public static Vector512<byte> CompareNotEqual(Vector512<byte> left, Vector512<byte> right) => CompareNotEqual(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_cmpeq_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPEQW k1 {k2}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> CompareEqual(Vector512<short> left, Vector512<short> right) => CompareEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpgt_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPGTW k1 {k2}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> CompareGreaterThan(Vector512<short> left, Vector512<short> right) => CompareGreaterThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpge_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPW k1 {k2}, zmm2, zmm3/m512, imm8(5)</para>
        /// </summary>
        public static Vector512<short> CompareGreaterThanOrEqual(Vector512<short> left, Vector512<short> right) => CompareGreaterThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmplt_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPW k1 {k2}, zmm2, zmm3/m512, imm8(1)</para>
        /// </summary>
        public static Vector512<short> CompareLessThan(Vector512<short> left, Vector512<short> right) => CompareLessThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmple_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPW k1 {k2}, zmm2, zmm3/m512, imm8(2)</para>
        /// </summary>
        public static Vector512<short> CompareLessThanOrEqual(Vector512<short> left, Vector512<short> right) => CompareLessThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpne_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPW k1 {k2}, zmm2, zmm3/m512, imm8(4)</para>
        /// </summary>
        public static Vector512<short> CompareNotEqual(Vector512<short> left, Vector512<short> right) => CompareNotEqual(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_cmpeq_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPEQB k1 {k2}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> CompareEqual(Vector512<sbyte> left, Vector512<sbyte> right) => CompareEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpgt_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPGTB k1 {k2}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> CompareGreaterThan(Vector512<sbyte> left, Vector512<sbyte> right) => CompareGreaterThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpge_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPB k1 {k2}, zmm2, zmm3/m512, imm8(5)</para>
        /// </summary>
        public static Vector512<sbyte> CompareGreaterThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) => CompareGreaterThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmplt_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPB k1 {k2}, zmm2, zmm3/m512, imm8(1)</para>
        /// </summary>
        public static Vector512<sbyte> CompareLessThan(Vector512<sbyte> left, Vector512<sbyte> right) => CompareLessThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmple_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPB k1 {k2}, zmm2, zmm3/m512, imm8(2)</para>
        /// </summary>
        public static Vector512<sbyte> CompareLessThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) => CompareLessThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpne_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPB k1 {k2}, zmm2, zmm3/m512, imm8(4)</para>
        /// </summary>
        public static Vector512<sbyte> CompareNotEqual(Vector512<sbyte> left, Vector512<sbyte> right) => CompareNotEqual(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_cmpeq_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPEQW k1 {k2}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> CompareEqual(Vector512<ushort> left, Vector512<ushort> right) => CompareEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpgt_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8(6)</para>
        /// </summary>
        public static Vector512<ushort> CompareGreaterThan(Vector512<ushort> left, Vector512<ushort> right) => CompareGreaterThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpge_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8(5)</para>
        /// </summary>
        public static Vector512<ushort> CompareGreaterThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) => CompareGreaterThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmplt_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8(1)</para>
        /// </summary>
        public static Vector512<ushort> CompareLessThan(Vector512<ushort> left, Vector512<ushort> right) => CompareLessThan(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmple_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8(2)</para>
        /// </summary>
        public static Vector512<ushort> CompareLessThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) => CompareLessThanOrEqual(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_cmpne_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8(4)</para>
        /// </summary>
        public static Vector512<ushort> CompareNotEqual(Vector512<ushort> left, Vector512<ushort> right) => CompareNotEqual(left, right);

        /// <summary>
        ///   <para>__m256i _mm512_cvtepi16_epi8 (__m512i a)</para>
        ///   <para>  VPMOVWB ymm1/m256 {k1}{z}, zmm2</para>
        /// </summary>
        public static Vector256<byte> ConvertToVector256Byte(Vector512<short> value) => ConvertToVector256Byte(value);
        /// <summary>
        ///   <para>__m256i _mm512_cvtepi16_epi8 (__m512i a)</para>
        ///   <para>  VPMOVWB ymm1/m256 {k1}{z}, zmm2</para>
        /// </summary>
        public static Vector256<byte> ConvertToVector256Byte(Vector512<ushort> value) => ConvertToVector256Byte(value);
        /// <summary>
        ///   <para>__m256i _mm512_cvtusepi16_epi8 (__m512i a)</para>
        ///   <para>  VPMOVUWB ymm1/m256 {k1}{z}, zmm2</para>
        /// </summary>
        public static Vector256<byte> ConvertToVector256ByteWithSaturation(Vector512<ushort> value) => ConvertToVector256ByteWithSaturation(value);

        /// <summary>
        ///   <para>__m256i _mm512_cvtepi16_epi8 (__m512i a)</para>
        ///   <para>  VPMOVWB ymm1/m256 {k1}{z}, zmm2</para>
        /// </summary>
        public static Vector256<sbyte> ConvertToVector256SByte(Vector512<short> value) => ConvertToVector256SByte(value);
        /// <summary>
        ///   <para>__m256i _mm512_cvtepi16_epi8 (__m512i a)</para>
        ///   <para>  VPMOVWB ymm1/m256 {k1}{z}, zmm2</para>
        /// </summary>
        public static Vector256<sbyte> ConvertToVector256SByte(Vector512<ushort> value) => ConvertToVector256SByte(value);
        /// <summary>
        ///   <para>__m256i _mm512_cvtsepi16_epi8 (__m512i a)</para>
        ///   <para>  VPMOVSWB ymm1/m256 {k1}{z}, zmm2</para>
        /// </summary>
        public static Vector256<sbyte> ConvertToVector256SByteWithSaturation(Vector512<short> value) => ConvertToVector256SByteWithSaturation(value);

        /// <summary>
        ///   <para>__m512i _mm512_cvtepi8_epi16 (__m128i a)</para>
        ///   <para>  VPMOVSXBW zmm1 {k1}{z}, ymm2/m256</para>
        /// </summary>
        public static Vector512<short> ConvertToVector512Int16(Vector256<sbyte> value) => ConvertToVector512Int16(value);
        /// <summary>
        ///   <para>__m512i _mm512_cvtepu8_epi16 (__m128i a)</para>
        ///   <para>  VPMOVZXBW zmm1 {k1}{z}, ymm2/m256</para>
        /// </summary>
        public static Vector512<short> ConvertToVector512Int16(Vector256<byte> value) => ConvertToVector512Int16(value);
        /// <summary>
        ///   <para>__m512i _mm512_cvtepi8_epi16 (__m128i a)</para>
        ///   <para>  VPMOVSXBW zmm1 {k1}{z}, ymm2/m256</para>
        /// </summary>
        public static Vector512<ushort> ConvertToVector512UInt16(Vector256<sbyte> value) => ConvertToVector512UInt16(value);
        /// <summary>
        ///   <para>__m512i _mm512_cvtepu8_epi16 (__m128i a)</para>
        ///   <para>  VPMOVZXBW zmm1 {k1}{z}, ymm2/m256</para>
        /// </summary>
        public static Vector512<ushort> ConvertToVector512UInt16(Vector256<byte> value) => ConvertToVector512UInt16(value);

        /// <summary>
        ///   <para>__m512i _mm512_loadu_epi8 (__m512i const * mem_addr)</para>
        ///   <para>  VMOVDQU8 zmm1 {k1}{z}, m512</para>
        /// </summary>
        public static new unsafe Vector512<sbyte> LoadVector512(sbyte* address) => LoadVector512(address);
        /// <summary>
        ///   <para>__m512i _mm512_loadu_epi8 (__m512i const * mem_addr)</para>
        ///   <para>  VMOVDQU8 zmm1 {k1}{z}, m512</para>
        /// </summary>
        public static new unsafe Vector512<byte> LoadVector512(byte* address) => LoadVector512(address);
        /// <summary>
        ///   <para>__m512i _mm512_loadu_epi16 (__m512i const * mem_addr)</para>
        ///   <para>  VMOVDQU16 zmm1 {k1}{z}, m512</para>
        /// </summary>
        public static new unsafe Vector512<short> LoadVector512(short* address) => LoadVector512(address);
        /// <summary>
        ///   <para>__m512i _mm512_loadu_epi16 (__m512i const * mem_addr)</para>
        ///   <para>  VMOVDQU16 zmm1 {k1}{z}, m512</para>
        /// </summary>
        public static new unsafe Vector512<ushort> LoadVector512(ushort* address) => LoadVector512(address);

        /// <summary>
        ///   <para>__m512i _mm512_max_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPMAXSB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> Max(Vector512<sbyte> left, Vector512<sbyte> right) => Max(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_max_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPMAXUB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> Max(Vector512<byte> left, Vector512<byte> right) => Max(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_max_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMAXSW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> Max(Vector512<short> left, Vector512<short> right) => Max(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_max_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMAXUW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> Max(Vector512<ushort> left, Vector512<ushort> right) => Max(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_min_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPMINSB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> Min(Vector512<sbyte> left, Vector512<sbyte> right) => Min(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_min_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPMINUB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> Min(Vector512<byte> left, Vector512<byte> right) => Min(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_min_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMINSW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> Min(Vector512<short> left, Vector512<short> right) => Min(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_min_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMINUW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> Min(Vector512<ushort> left, Vector512<ushort> right) => Min(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_madd_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMADDWD zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<int> MultiplyAddAdjacent(Vector512<short> left, Vector512<short> right) => MultiplyAddAdjacent(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_maddubs_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMADDUBSW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> MultiplyAddAdjacent(Vector512<byte> left, Vector512<sbyte> right) => MultiplyAddAdjacent(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_mulhi_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMULHW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> MultiplyHigh(Vector512<short> left, Vector512<short> right) => MultiplyHigh(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_mulhi_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMULHUW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> MultiplyHigh(Vector512<ushort> left, Vector512<ushort> right) => MultiplyHigh(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_mulhrs_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMULHRSW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> MultiplyHighRoundScale(Vector512<short> left, Vector512<short> right) => MultiplyHighRoundScale(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_mullo_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMULLW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> MultiplyLow(Vector512<short> left, Vector512<short> right) => MultiplyLow(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_mullo_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPMULLW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> MultiplyLow(Vector512<ushort> left, Vector512<ushort> right) => MultiplyLow(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_packs_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPACKSSWB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> PackSignedSaturate(Vector512<short> left, Vector512<short> right) => PackSignedSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_packs_epi32 (__m512i a, __m512i b)</para>
        ///   <para>  VPACKSSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</para>
        /// </summary>
        public static Vector512<short> PackSignedSaturate(Vector512<int> left, Vector512<int> right) => PackSignedSaturate(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_packus_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPACKUSWB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> PackUnsignedSaturate(Vector512<short> left, Vector512<short> right) => PackUnsignedSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_packus_epi32 (__m512i a, __m512i b)</para>
        ///   <para>  VPACKUSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst</para>
        /// </summary>
        public static Vector512<ushort> PackUnsignedSaturate(Vector512<int> left, Vector512<int> right) => PackUnsignedSaturate(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_permutexvar_epi16 (__m512i idx, __m512i a)</para>
        ///   <para>  VPERMW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        /// <remarks>The native and managed intrinsics have different order of parameters.</remarks>
        public static Vector512<short> PermuteVar32x16(Vector512<short> left, Vector512<short> control) => PermuteVar32x16(left, control);
        /// <summary>
        ///   <para>__m512i _mm512_permutexvar_epi16 (__m512i idx, __m512i a)</para>
        ///   <para>  VPERMW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        /// <remarks>The native and managed intrinsics have different order of parameters.</remarks>
        public static Vector512<ushort> PermuteVar32x16(Vector512<ushort> left, Vector512<ushort> control) => PermuteVar32x16(left, control);

        /// <summary>
        ///   <para>__m512i _mm512_permutex2var_epi16 (__m512i a, __m512i idx, __m512i b)</para>
        ///   <para>  VPERMI2W zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        ///   <para>  VPERMT2W zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> PermuteVar32x16x2(Vector512<short> lower, Vector512<short> indices, Vector512<short> upper) => PermuteVar32x16x2(lower, indices, upper);
        /// <summary>
        ///   <para>__m512i _mm512_permutex2var_epi16 (__m512i a, __m512i idx, __m512i b)</para>
        ///   <para>  VPERMI2W zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        ///   <para>  VPERMT2W zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> PermuteVar32x16x2(Vector512<ushort> lower, Vector512<ushort> indices, Vector512<ushort> upper) => PermuteVar32x16x2(lower, indices, upper);

        /// <summary>
        ///   <para>__m512i _mm512_sll_epi16 (__m512i a, __m128i count)</para>
        ///   <para>  VPSLLW zmm1 {k1}{z}, zmm2, xmm3/m128</para>
        /// </summary>
        public static Vector512<short> ShiftLeftLogical(Vector512<short> value, Vector128<short> count) => ShiftLeftLogical(value, count);
        /// <summary>
        ///   <para>__m512i _mm512_sll_epi16 (__m512i a, __m128i count)</para>
        ///   <para>  VPSLLW zmm1 {k1}{z}, zmm2, xmm3/m128</para>
        /// </summary>
        public static Vector512<ushort> ShiftLeftLogical(Vector512<ushort> value, Vector128<ushort> count) => ShiftLeftLogical(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_slli_epi16 (__m512i a, int imm8)</para>
        ///   <para>  VPSLLW zmm1 {k1}{z}, zmm2, imm8</para>
        /// </summary>
        public static Vector512<short> ShiftLeftLogical(Vector512<short> value, [ConstantExpected] byte count) => ShiftLeftLogical(value, count);
        /// <summary>
        ///   <para>__m512i _mm512_slli_epi16 (__m512i a, int imm8)</para>
        ///   <para>  VPSLLW zmm1 {k1}{z}, zmm2, imm8</para>
        /// </summary>
        public static Vector512<ushort> ShiftLeftLogical(Vector512<ushort> value, [ConstantExpected] byte count) => ShiftLeftLogical(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_bslli_epi128 (__m512i a, const int imm8)</para>
        ///   <para>  VPSLLDQ zmm1, zmm2/m512, imm8</para>
        /// </summary>
        public static Vector512<sbyte> ShiftLeftLogical128BitLane(Vector512<sbyte> value, [ConstantExpected] byte numBytes) => ShiftLeftLogical128BitLane(value, numBytes);
        /// <summary>
        ///   <para>__m512i _mm512_bslli_epi128 (__m512i a, const int imm8)</para>
        ///   <para>  VPSLLDQ zmm1, zmm2/m512, imm8</para>
        /// </summary>
        public static Vector512<byte> ShiftLeftLogical128BitLane(Vector512<byte> value, [ConstantExpected] byte numBytes) => ShiftLeftLogical128BitLane(value, numBytes);

        /// <summary>
        ///   <para>__m512i _mm512_sllv_epi16 (__m512i a, __m512i count)</para>
        ///   <para>  VPSLLVW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> ShiftLeftLogicalVariable(Vector512<short> value, Vector512<ushort> count) => ShiftLeftLogicalVariable(value, count);
        /// <summary>
        ///   <para>__m512i _mm512_sllv_epi16 (__m512i a, __m512i count)</para>
        ///   <para>  VPSLLVW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> ShiftLeftLogicalVariable(Vector512<ushort> value, Vector512<ushort> count) => ShiftLeftLogicalVariable(value, count);

        /// <summary>
        ///   <para>_mm512_sra_epi16 (__m512i a, __m128i count)</para>
        ///   <para>  VPSRAW zmm1 {k1}{z}, zmm2, xmm3/m128</para>
        /// </summary>
        public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, Vector128<short> count) => ShiftRightArithmetic(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_srai_epi16 (__m512i a, int imm8)</para>
        ///   <para>  VPSRAW zmm1 {k1}{z}, zmm2, imm8</para>
        /// </summary>
        public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, [ConstantExpected] byte count) => ShiftRightArithmetic(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_srav_epi16 (__m512i a, __m512i count)</para>
        ///   <para>  VPSRAVW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> ShiftRightArithmeticVariable(Vector512<short> value, Vector512<ushort> count) => ShiftRightArithmeticVariable(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_srl_epi16 (__m512i a, __m128i count)</para>
        ///   <para>  VPSRLW zmm1 {k1}{z}, zmm2, xmm3/m128</para>
        /// </summary>
        public static Vector512<short> ShiftRightLogical(Vector512<short> value, Vector128<short> count) => ShiftRightLogical(value, count);
        /// <summary>
        ///   <para>__m512i _mm512_srl_epi16 (__m512i a, __m128i count)</para>
        ///   <para>  VPSRLW zmm1 {k1}{z}, zmm2, xmm3/m128</para>
        /// </summary>
        public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, Vector128<ushort> count) => ShiftRightLogical(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_srli_epi16 (__m512i a, int imm8)</para>
        ///   <para>  VPSRLW zmm1 {k1}{z}, zmm2, imm8</para>
        /// </summary>
        public static Vector512<short> ShiftRightLogical(Vector512<short> value, [ConstantExpected] byte count) => ShiftRightLogical(value, count);
        /// <summary>
        ///   <para>__m512i _mm512_srli_epi16 (__m512i a, int imm8)</para>
        ///   <para>  VPSRLW zmm1 {k1}{z}, zmm2, imm8</para>
        /// </summary>
        public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, [ConstantExpected] byte count) => ShiftRightLogical(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_bsrli_epi128 (__m512i a, const int imm8)</para>
        ///   <para>  VPSRLDQ zmm1, zmm2/m128, imm8</para>
        /// </summary>
        public static Vector512<sbyte> ShiftRightLogical128BitLane(Vector512<sbyte> value, [ConstantExpected] byte numBytes) => ShiftRightLogical128BitLane(value, numBytes);
        /// <summary>
        ///   <para>__m512i _mm512_bsrli_epi128 (__m512i a, const int imm8)</para>
        ///   <para>  VPSRLDQ zmm1, zmm2/m128, imm8</para>
        /// </summary>
        public static Vector512<byte> ShiftRightLogical128BitLane(Vector512<byte> value, [ConstantExpected] byte numBytes) => ShiftRightLogical128BitLane(value, numBytes);

        /// <summary>
        ///   <para>__m512i _mm512_srlv_epi16 (__m512i a, __m512i count)</para>
        ///   <para>  VPSRLVW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> ShiftRightLogicalVariable(Vector512<short> value, Vector512<ushort> count) => ShiftRightLogicalVariable(value, count);
        /// <summary>
        ///   <para>__m512i _mm512_srlv_epi16 (__m512i a, __m512i count)</para>
        ///   <para>  VPSRLVW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> ShiftRightLogicalVariable(Vector512<ushort> value, Vector512<ushort> count) => ShiftRightLogicalVariable(value, count);

        /// <summary>
        ///   <para>__m512i _mm512_shuffle_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPSHUFB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> Shuffle(Vector512<sbyte> value, Vector512<sbyte> mask) => Shuffle(value, mask);
        /// <summary>
        ///   <para>__m512i _mm512_shuffle_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPSHUFB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> Shuffle(Vector512<byte> value, Vector512<byte> mask) => Shuffle(value, mask);

        /// <summary>
        ///   <para>__m512i _mm512_shufflehi_epi16 (__m512i a, const int imm8)</para>
        ///   <para>  VPSHUFHW zmm1 {k1}{z}, zmm2/m512, imm8</para>
        /// </summary>
        public static Vector512<short> ShuffleHigh(Vector512<short> value, [ConstantExpected] byte control) => ShuffleHigh(value, control);
        /// <summary>
        ///   <para>__m512i _mm512_shufflehi_epi16 (__m512i a, const int imm8)</para>
        ///   <para>  VPSHUFHW zmm1 {k1}{z}, zmm2/m512, imm8</para>
        /// </summary>
        public static Vector512<ushort> ShuffleHigh(Vector512<ushort> value, [ConstantExpected] byte control) => ShuffleHigh(value, control);

        /// <summary>
        ///   <para>__m512i _mm512_shufflelo_epi16 (__m512i a, const int imm8)</para>
        ///   <para>  VPSHUFLW zmm1 {k1}{z}, zmm2/m512, imm8</para>
        /// </summary>
        public static Vector512<short> ShuffleLow(Vector512<short> value, [ConstantExpected] byte control) => ShuffleLow(value, control);
        /// <summary>
        ///   <para>__m512i _mm512_shufflelo_epi16 (__m512i a, const int imm8)</para>
        ///   <para>  VPSHUFLW zmm1 {k1}{z}, zmm2/m512, imm8</para>
        /// </summary>
        public static Vector512<ushort> ShuffleLow(Vector512<ushort> value, [ConstantExpected] byte control) => ShuffleLow(value, control);

        /// <summary>
        ///   <para>void _mm512_storeu_epi8 (__m512i * mem_addr, __m512i a)</para>
        ///   <para>  VMOVDQU8 m512 {k1}{z}, zmm1</para>
        /// </summary>
        public static new unsafe void Store(sbyte* address, Vector512<sbyte> source) => Store(address, source);
        /// <summary>
        ///   <para>void _mm512_storeu_epi8 (__m512i * mem_addr, __m512i a)</para>
        ///   <para>  VMOVDQU8 m512 {k1}{z}, zmm1</para>
        /// </summary>
        public static new unsafe void Store(byte* address, Vector512<byte> source) => Store(address, source);
        /// <summary>
        ///   <para>void _mm512_storeu_epi16 (__m512i * mem_addr, __m512i a)</para>
        ///   <para>  VMOVDQU16 m512 {k1}{z}, zmm1</para>
        /// </summary>
        public static new unsafe void Store(short* address, Vector512<short> source) => Store(address, source);
        /// <summary>
        ///   <para>void _mm512_storeu_epi16 (__m512i * mem_addr, __m512i a)</para>
        ///   <para>  VMOVDQU16 m512 {k1}{z}, zmm1</para>
        /// </summary>
        public static new unsafe void Store(ushort* address, Vector512<ushort> source) => Store(address, source);

        /// <summary>
        ///   <para>__m512i _mm512_sub_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> Subtract(Vector512<sbyte> left, Vector512<sbyte> right) => Subtract(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_sub_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBB zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> Subtract(Vector512<byte> left, Vector512<byte> right) => Subtract(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_sub_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> Subtract(Vector512<short> left, Vector512<short> right) => Subtract(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_sub_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> Subtract(Vector512<ushort> left, Vector512<ushort> right) => Subtract(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_subs_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBSB zmm1 {k1}{z}, zmm2, zmm3/m128</para>
        /// </summary>
        public static Vector512<sbyte> SubtractSaturate(Vector512<sbyte> left, Vector512<sbyte> right) => SubtractSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_subs_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBSW zmm1 {k1}{z}, zmm2, zmm3/m128</para>
        /// </summary>
        public static Vector512<short> SubtractSaturate(Vector512<short> left, Vector512<short> right) => SubtractSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_subs_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBUSB zmm1 {k1}{z}, zmm2, zmm3/m128</para>
        /// </summary>
        public static Vector512<byte> SubtractSaturate(Vector512<byte> left, Vector512<byte> right) => SubtractSaturate(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_subs_epu16 (__m512i a, __m512i b)</para>
        ///   <para>  VPSUBUSW zmm1 {k1}{z}, zmm2, zmm3/m128</para>
        /// </summary>
        public static Vector512<ushort> SubtractSaturate(Vector512<ushort> left, Vector512<ushort> right) => SubtractSaturate(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_sad_epu8 (__m512i a, __m512i b)</para>
        ///   <para>  VPSADBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> SumAbsoluteDifferences(Vector512<byte> left, Vector512<byte> right) => SumAbsoluteDifferences(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_dbsad_epu8 (__m512i a, __m512i b, int imm8)</para>
        ///   <para>  VDBPSADBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> SumAbsoluteDifferencesInBlock32(Vector512<byte> left, Vector512<byte> right, [ConstantExpected] byte control) => SumAbsoluteDifferencesInBlock32(left, right, control);

        /// <summary>
        ///   <para>__m512i _mm512_unpackhi_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKHBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> UnpackHigh(Vector512<sbyte> left, Vector512<sbyte> right) => UnpackHigh(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_unpackhi_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKHBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> UnpackHigh(Vector512<byte> left, Vector512<byte> right) => UnpackHigh(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_unpackhi_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKHWD zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> UnpackHigh(Vector512<short> left, Vector512<short> right) => UnpackHigh(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_unpackhi_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKHWD zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> UnpackHigh(Vector512<ushort> left, Vector512<ushort> right) => UnpackHigh(left, right);

        /// <summary>
        ///   <para>__m512i _mm512_unpacklo_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKLBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<sbyte> UnpackLow(Vector512<sbyte> left, Vector512<sbyte> right) => UnpackLow(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_unpacklo_epi8 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKLBW zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<byte> UnpackLow(Vector512<byte> left, Vector512<byte> right) => UnpackLow(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_unpacklo_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKLWD zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<short> UnpackLow(Vector512<short> left, Vector512<short> right) => UnpackLow(left, right);
        /// <summary>
        ///   <para>__m512i _mm512_unpacklo_epi16 (__m512i a, __m512i b)</para>
        ///   <para>  VPUNPCKLWD zmm1 {k1}{z}, zmm2, zmm3/m512</para>
        /// </summary>
        public static Vector512<ushort> UnpackLow(Vector512<ushort> left, Vector512<ushort> right) => UnpackLow(left, right);
    }
}
