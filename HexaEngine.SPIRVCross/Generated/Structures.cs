// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace HexaEngine.SPIRVCross
{
	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// See C++ API. 
	/// </summary>
	public partial struct SpvcReflectedResource
	{
		public uint Id;
		public uint BaseTypeId;
		public uint TypeId;
		public unsafe byte* Name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcReflectedBuiltinResource
	{
		public SpvBuiltIn Builtin;
		public uint ValueTypeId;
		public SpvcReflectedResource Resource;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// See C++ API. 
	/// </summary>
	public partial struct SpvcEntryPoint
	{
		public SpvExecutionModel ExecutionModel;
		public unsafe byte* Name;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// See C++ API. 
	/// </summary>
	public partial struct SpvcCombinedImageSampler
	{
		public uint CombinedId;
		public uint ImageId;
		public uint SamplerId;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// See C++ API. 
	/// </summary>
	public partial struct SpvcSpecializationConstant
	{
		public uint Id;
		public uint ConstantId;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// See C++ API. 
	/// </summary>
	public partial struct SpvcBufferRange
	{
		public uint Index;
		public nuint Offset;
		public nuint Range;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// See C++ API. 
	/// </summary>
	public partial struct SpvcHlslRootConstants
	{
		public uint Start;
		public uint End;
		public uint Binding;
		public uint Space;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// See C++ API. 
	/// </summary>
	public partial struct SpvcHlslVertexAttributeRemap
	{
		public uint Location;
		public unsafe byte* Semantic;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// Maps to C++ API. Deprecated; use spvc_msl_shader_interface_var. 
	/// </summary>
	public partial struct SpvcMslVertexAttribute
	{
		public uint Location;
		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. 
		/// </summary>
		public uint MslBuffer;
		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. 
		/// </summary>
		public uint MslOffset;
		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. 
		/// </summary>
		public uint MslStride;
		/// <summary>
		/// Obsolete, do not use. Only lingers on for ABI compatibility. 
		/// </summary>
		public bool PerInstance;
		public SpvcMslShaderVariableFormat Format;
		public SpvBuiltIn Builtin;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// Maps to C++ API. Deprecated; use spvc_msl_shader_interface_var_2. 
	/// </summary>
	public partial struct SpvcMslShaderInterfaceVar
	{
		public uint Location;
		public SpvcMslShaderVariableFormat Format;
		public SpvBuiltIn Builtin;
		public uint Vecsize;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// Maps to C++ API. 
	/// </summary>
	public partial struct SpvcMslShaderInterfaceVar2
	{
		public uint Location;
		public SpvcMslShaderVariableFormat Format;
		public SpvBuiltIn Builtin;
		public uint Vecsize;
		public SpvcMslShaderVariableRate Rate;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// Maps to C++ API. 
	/// </summary>
	public partial struct SpvcMslResourceBinding
	{
		public SpvExecutionModel Stage;
		public uint DescSet;
		public uint Binding;
		public uint MslBuffer;
		public uint MslTexture;
		public uint MslSampler;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// Maps to C++ API. 
	/// </summary>
	public partial struct SpvcMslConstexprSampler
	{
		public SpvcMslSamplerCoord Coord;
		public SpvcMslSamplerFilter MinFilter;
		public SpvcMslSamplerFilter MagFilter;
		public SpvcMslSamplerMipFilter MipFilter;
		public SpvcMslSamplerAddress SAddress;
		public SpvcMslSamplerAddress TAddress;
		public SpvcMslSamplerAddress RAddress;
		public SpvcMslSamplerCompareFunc CompareFunc;
		public SpvcMslSamplerBorderColor BorderColor;
		public float LodClampMin;
		public float LodClampMax;
		public int MaxAnisotropy;
		public bool CompareEnable;
		public bool LodClampEnable;
		public bool AnisotropyEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// Maps to the sampler Y'CbCr conversion-related portions of MSLConstexprSampler. See C++ API for defaults and details. 
	/// </summary>
	public partial struct SpvcMslSamplerYcbcrConversion
	{
		public uint Planes;
		public SpvcMslFormatResolution Resolution;
		public SpvcMslSamplerFilter ChromaFilter;
		public SpvcMslChromaLocation XChromaOffset;
		public SpvcMslChromaLocation YChromaOffset;
		public SpvcMslComponentSwizzle Swizzle_0;
		public SpvcMslComponentSwizzle Swizzle_1;
		public SpvcMslComponentSwizzle Swizzle_2;
		public SpvcMslComponentSwizzle Swizzle_3;
		public SpvcMslSamplerYcbcrModelConversion YcbcrModel;
		public SpvcMslSamplerYcbcrRange YcbcrRange;
		public uint Bpc;
	}

	[StructLayout(LayoutKind.Sequential)]
	/// <summary>
	/// Maps to C++ API. 
	/// </summary>
	public partial struct SpvcHlslResourceBindingMapping
	{
		public uint RegisterSpace;
		public uint RegisterBinding;
	}

	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcHlslResourceBinding
	{
		public SpvExecutionModel Stage;
		public uint DescSet;
		public uint Binding;
		public SpvcHlslResourceBindingMapping Cbv;
		public SpvcHlslResourceBindingMapping Uav;
		public SpvcHlslResourceBindingMapping Srv;
		public SpvcHlslResourceBindingMapping Sampler;
	}

}
