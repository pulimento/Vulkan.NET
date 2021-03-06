using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.Vulkan
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBaseOutStructure
	{
		public VkStructureType sType;
		public VkBaseOutStructure* pNext;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBaseInStructure
	{
		public VkStructureType sType;
		public VkBaseInStructure* pNext;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOffset2D
	{
		public int x;
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkOffset3D
	{
		public int x;
		public int y;
		public int z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExtent2D
	{
		public uint width;
		public uint height;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExtent3D
	{
		public uint width;
		public uint height;
		public uint depth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViewport
	{
		public float x;
		public float y;
		public float width;
		public float height;
		public float minDepth;
		public float maxDepth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRect2D
	{
		public VkOffset2D offset;
		public VkExtent2D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkClearRect
	{
		public VkRect2D rect;
		public uint baseArrayLayer;
		public uint layerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkComponentMapping
	{
		public VkComponentSwizzle r;
		public VkComponentSwizzle g;
		public VkComponentSwizzle b;
		public VkComponentSwizzle a;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProperties
	{
		public uint apiVersion;
		public uint driverVersion;
		public uint vendorID;
		public uint deviceID;
		public VkPhysicalDeviceType deviceType;
		public fixed byte deviceName[(int)Vulkan.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
		public fixed byte pipelineCacheUUID[(int)Vulkan.VK_UUID_SIZE];
		public VkPhysicalDeviceLimits limits;
		public VkPhysicalDeviceSparseProperties sparseProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExtensionProperties
	{
		public fixed byte extensionName[(int)Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
		public uint specVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkLayerProperties
	{
		public fixed byte layerName[(int)Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
		public uint specVersion;
		public uint implementationVersion;
		public fixed byte description[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkApplicationInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pApplicationName;
		public uint applicationVersion;
		public byte* pEngineName;
		public uint engineVersion;
		public uint apiVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAllocationCallbacks
	{
		public void* pUserData;
		public IntPtr pfnAllocation;
		public IntPtr pfnReallocation;
		public IntPtr pfnFree;
		public IntPtr pfnInternalAllocation;
		public IntPtr pfnInternalFree;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceQueueCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceQueueCreateFlagBits flags;
		public uint queueFamilyIndex;
		public uint queueCount;
		public float* pQueuePriorities;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint queueCreateInfoCount;
		public VkDeviceQueueCreateInfo* pQueueCreateInfos;
		public uint enabledLayerCount;
		public byte** ppEnabledLayerNames;
		public uint enabledExtensionCount;
		public byte** ppEnabledExtensionNames;
		public VkPhysicalDeviceFeatures* pEnabledFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkInstanceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkApplicationInfo* pApplicationInfo;
		public uint enabledLayerCount;
		public byte** ppEnabledLayerNames;
		public uint enabledExtensionCount;
		public byte** ppEnabledExtensionNames;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyProperties
	{
		public VkQueueFlagBits queueFlags;
		public uint queueCount;
		public uint timestampValidBits;
		public VkExtent3D minImageTransferGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryProperties
	{
		public uint memoryTypeCount;
		public VkMemoryType memoryTypes_0;
		public VkMemoryType memoryTypes_1;
		public VkMemoryType memoryTypes_2;
		public VkMemoryType memoryTypes_3;
		public VkMemoryType memoryTypes_4;
		public VkMemoryType memoryTypes_5;
		public VkMemoryType memoryTypes_6;
		public VkMemoryType memoryTypes_7;
		public VkMemoryType memoryTypes_8;
		public VkMemoryType memoryTypes_9;
		public VkMemoryType memoryTypes_10;
		public VkMemoryType memoryTypes_11;
		public VkMemoryType memoryTypes_12;
		public VkMemoryType memoryTypes_13;
		public VkMemoryType memoryTypes_14;
		public VkMemoryType memoryTypes_15;
		public VkMemoryType memoryTypes_16;
		public VkMemoryType memoryTypes_17;
		public VkMemoryType memoryTypes_18;
		public VkMemoryType memoryTypes_19;
		public VkMemoryType memoryTypes_20;
		public VkMemoryType memoryTypes_21;
		public VkMemoryType memoryTypes_22;
		public VkMemoryType memoryTypes_23;
		public VkMemoryType memoryTypes_24;
		public VkMemoryType memoryTypes_25;
		public VkMemoryType memoryTypes_26;
		public VkMemoryType memoryTypes_27;
		public VkMemoryType memoryTypes_28;
		public VkMemoryType memoryTypes_29;
		public VkMemoryType memoryTypes_30;
		public VkMemoryType memoryTypes_31;
		public uint memoryHeapCount;
		public VkMemoryHeap memoryHeaps_0;
		public VkMemoryHeap memoryHeaps_1;
		public VkMemoryHeap memoryHeaps_2;
		public VkMemoryHeap memoryHeaps_3;
		public VkMemoryHeap memoryHeaps_4;
		public VkMemoryHeap memoryHeaps_5;
		public VkMemoryHeap memoryHeaps_6;
		public VkMemoryHeap memoryHeaps_7;
		public VkMemoryHeap memoryHeaps_8;
		public VkMemoryHeap memoryHeaps_9;
		public VkMemoryHeap memoryHeaps_10;
		public VkMemoryHeap memoryHeaps_11;
		public VkMemoryHeap memoryHeaps_12;
		public VkMemoryHeap memoryHeaps_13;
		public VkMemoryHeap memoryHeaps_14;
		public VkMemoryHeap memoryHeaps_15;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong allocationSize;
		public uint memoryTypeIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryRequirements
	{
		public ulong size;
		public ulong alignment;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageFormatProperties
	{
		public VkImageAspectFlagBits aspectMask;
		public VkExtent3D imageGranularity;
		public VkSparseImageFormatFlagBits flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryRequirements
	{
		public VkSparseImageFormatProperties formatProperties;
		public uint imageMipTailFirstLod;
		public ulong imageMipTailSize;
		public ulong imageMipTailOffset;
		public ulong imageMipTailStride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryType
	{
		public VkMemoryPropertyFlagBits propertyFlags;
		public uint heapIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryHeap
	{
		public ulong size;
		public VkMemoryHeapFlagBits flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMappedMemoryRange
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public ulong offset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFormatProperties
	{
		public VkFormatFeatureFlagBits linearTilingFeatures;
		public VkFormatFeatureFlagBits optimalTilingFeatures;
		public VkFormatFeatureFlagBits bufferFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageFormatProperties
	{
		public VkExtent3D maxExtent;
		public uint maxMipLevels;
		public uint maxArrayLayers;
		public VkSampleCountFlagBits sampleCounts;
		public ulong maxResourceSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorBufferInfo
	{
		public VkBuffer buffer;
		public ulong offset;
		public ulong range;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorImageInfo
	{
		public VkSampler sampler;
		public VkImageView imageView;
		public VkImageLayout imageLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWriteDescriptorSet
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorSet dstSet;
		public uint dstBinding;
		public uint dstArrayElement;
		public uint descriptorCount;
		public VkDescriptorType descriptorType;
		public VkDescriptorImageInfo* pImageInfo;
		public VkDescriptorBufferInfo* pBufferInfo;
		public VkBufferView* pTexelBufferView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyDescriptorSet
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorSet srcSet;
		public uint srcBinding;
		public uint srcArrayElement;
		public VkDescriptorSet dstSet;
		public uint dstBinding;
		public uint dstArrayElement;
		public uint descriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCreateFlagBits flags;
		public ulong size;
		public VkBufferUsageFlagBits usage;
		public VkSharingMode sharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferViewCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBuffer buffer;
		public VkFormat format;
		public ulong offset;
		public ulong range;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSubresource
	{
		public VkImageAspectFlagBits aspectMask;
		public uint mipLevel;
		public uint arrayLayer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSubresourceLayers
	{
		public VkImageAspectFlagBits aspectMask;
		public uint mipLevel;
		public uint baseArrayLayer;
		public uint layerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSubresourceRange
	{
		public VkImageAspectFlagBits aspectMask;
		public uint baseMipLevel;
		public uint levelCount;
		public uint baseArrayLayer;
		public uint layerCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryBarrier
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccessFlagBits srcAccessMask;
		public VkAccessFlagBits dstAccessMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferMemoryBarrier
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccessFlagBits srcAccessMask;
		public VkAccessFlagBits dstAccessMask;
		public uint srcQueueFamilyIndex;
		public uint dstQueueFamilyIndex;
		public VkBuffer buffer;
		public ulong offset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageMemoryBarrier
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccessFlagBits srcAccessMask;
		public VkAccessFlagBits dstAccessMask;
		public VkImageLayout oldLayout;
		public VkImageLayout newLayout;
		public uint srcQueueFamilyIndex;
		public uint dstQueueFamilyIndex;
		public VkImage image;
		public VkImageSubresourceRange subresourceRange;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCreateFlagBits flags;
		public VkImageType imageType;
		public VkFormat format;
		public VkExtent3D extent;
		public uint mipLevels;
		public uint arrayLayers;
		public VkSampleCountFlagBits samples;
		public VkImageTiling tiling;
		public VkImageUsageFlagBits usage;
		public VkSharingMode sharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
		public VkImageLayout initialLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubresourceLayout
	{
		public ulong offset;
		public ulong size;
		public ulong rowPitch;
		public ulong arrayPitch;
		public ulong depthPitch;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageViewCreateFlagBits flags;
		public VkImage image;
		public VkImageViewType viewType;
		public VkFormat format;
		public VkComponentMapping components;
		public VkImageSubresourceRange subresourceRange;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferCopy
	{
		public ulong srcOffset;
		public ulong dstOffset;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseMemoryBind
	{
		public ulong resourceOffset;
		public ulong size;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
		public VkSparseMemoryBindFlagBits flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryBind
	{
		public VkImageSubresource subresource;
		public VkOffset3D offset;
		public VkExtent3D extent;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
		public VkSparseMemoryBindFlagBits flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseBufferMemoryBindInfo
	{
		public VkBuffer buffer;
		public uint bindCount;
		public VkSparseMemoryBind* pBinds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageOpaqueMemoryBindInfo
	{
		public VkImage image;
		public uint bindCount;
		public VkSparseMemoryBind* pBinds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryBindInfo
	{
		public VkImage image;
		public uint bindCount;
		public VkSparseImageMemoryBind* pBinds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindSparseInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public VkSemaphore* pWaitSemaphores;
		public uint bufferBindCount;
		public VkSparseBufferMemoryBindInfo* pBufferBinds;
		public uint imageOpaqueBindCount;
		public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
		public uint imageBindCount;
		public VkSparseImageMemoryBindInfo* pImageBinds;
		public uint signalSemaphoreCount;
		public VkSemaphore* pSignalSemaphores;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageCopy
	{
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffset;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffset;
		public VkExtent3D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageBlit
	{
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffsets_0;
		public VkOffset3D srcOffsets_1;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffsets_0;
		public VkOffset3D dstOffsets_1;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferImageCopy
	{
		public ulong bufferOffset;
		public uint bufferRowLength;
		public uint bufferImageHeight;
		public VkImageSubresourceLayers imageSubresource;
		public VkOffset3D imageOffset;
		public VkExtent3D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageResolve
	{
		public VkImageSubresourceLayers srcSubresource;
		public VkOffset3D srcOffset;
		public VkImageSubresourceLayers dstSubresource;
		public VkOffset3D dstOffset;
		public VkExtent3D extent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderModuleCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderModuleCreateFlagBits flags;
		public UIntPtr codeSize;
		public uint* pCode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutBinding
	{
		public uint binding;
		public VkDescriptorType descriptorType;
		public uint descriptorCount;
		public VkShaderStageFlagBits stageFlags;
		public VkSampler* pImmutableSamplers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorSetLayoutCreateFlagBits flags;
		public uint bindingCount;
		public VkDescriptorSetLayoutBinding* pBindings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorPoolSize
	{
		public VkDescriptorType type;
		public uint descriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorPoolCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorPoolCreateFlagBits flags;
		public uint maxSets;
		public uint poolSizeCount;
		public VkDescriptorPoolSize* pPoolSizes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDescriptorPool descriptorPool;
		public uint descriptorSetCount;
		public VkDescriptorSetLayout* pSetLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSpecializationMapEntry
	{
		public uint constantID;
		public uint offset;
		public UIntPtr size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSpecializationInfo
	{
		public uint mapEntryCount;
		public VkSpecializationMapEntry* pMapEntries;
		public UIntPtr dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineShaderStageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineShaderStageCreateFlagBits flags;
		public VkShaderStageFlagBits stage;
		public VkShaderModule module;
		public byte* pName;
		public VkSpecializationInfo* pSpecializationInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkComputePipelineCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlagBits flags;
		public VkPipelineShaderStageCreateInfo stage;
		public VkPipelineLayout layout;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputBindingDescription
	{
		public uint binding;
		public uint stride;
		public VkVertexInputRate inputRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputAttributeDescription
	{
		public uint location;
		public uint binding;
		public VkFormat format;
		public uint offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineVertexInputStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint vertexBindingDescriptionCount;
		public VkVertexInputBindingDescription* pVertexBindingDescriptions;
		public uint vertexAttributeDescriptionCount;
		public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkPrimitiveTopology topology;
		public VkBool32 primitiveRestartEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineTessellationStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint patchControlPoints;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint viewportCount;
		public VkViewport* pViewports;
		public uint scissorCount;
		public VkRect2D* pScissors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 depthClampEnable;
		public VkBool32 rasterizerDiscardEnable;
		public VkPolygonMode polygonMode;
		public VkCullModeFlagBits cullMode;
		public VkFrontFace frontFace;
		public VkBool32 depthBiasEnable;
		public float depthBiasConstantFactor;
		public float depthBiasClamp;
		public float depthBiasSlopeFactor;
		public float lineWidth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineMultisampleStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkSampleCountFlagBits rasterizationSamples;
		public VkBool32 sampleShadingEnable;
		public float minSampleShading;
		public uint* pSampleMask;
		public VkBool32 alphaToCoverageEnable;
		public VkBool32 alphaToOneEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineColorBlendAttachmentState
	{
		public VkBool32 blendEnable;
		public VkBlendFactor srcColorBlendFactor;
		public VkBlendFactor dstColorBlendFactor;
		public VkBlendOp colorBlendOp;
		public VkBlendFactor srcAlphaBlendFactor;
		public VkBlendFactor dstAlphaBlendFactor;
		public VkBlendOp alphaBlendOp;
		public VkColorComponentFlagBits colorWriteMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineColorBlendStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 logicOpEnable;
		public VkLogicOp logicOp;
		public uint attachmentCount;
		public VkPipelineColorBlendAttachmentState* pAttachments;
		public float blendConstants_0;
		public float blendConstants_1;
		public float blendConstants_2;
		public float blendConstants_3;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineDynamicStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint dynamicStateCount;
		public VkDynamicState* pDynamicStates;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkStencilOpState
	{
		public VkStencilOp failOp;
		public VkStencilOp passOp;
		public VkStencilOp depthFailOp;
		public VkCompareOp compareOp;
		public uint compareMask;
		public uint writeMask;
		public uint reference;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineDepthStencilStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 depthTestEnable;
		public VkBool32 depthWriteEnable;
		public VkCompareOp depthCompareOp;
		public VkBool32 depthBoundsTestEnable;
		public VkBool32 stencilTestEnable;
		public VkStencilOpState front;
		public VkStencilOpState back;
		public float minDepthBounds;
		public float maxDepthBounds;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGraphicsPipelineCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlagBits flags;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
		public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
		public VkPipelineTessellationStateCreateInfo* pTessellationState;
		public VkPipelineViewportStateCreateInfo* pViewportState;
		public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
		public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
		public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
		public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
		public VkPipelineDynamicStateCreateInfo* pDynamicState;
		public VkPipelineLayout layout;
		public VkRenderPass renderPass;
		public uint subpass;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCacheCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCacheCreateFlagBits flags;
		public UIntPtr initialDataSize;
		public void* pInitialData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPushConstantRange
	{
		public VkShaderStageFlagBits stageFlags;
		public uint offset;
		public uint size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineLayoutCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint setLayoutCount;
		public VkDescriptorSetLayout* pSetLayouts;
		public uint pushConstantRangeCount;
		public VkPushConstantRange* pPushConstantRanges;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSamplerCreateFlagBits flags;
		public VkFilter magFilter;
		public VkFilter minFilter;
		public VkSamplerMipmapMode mipmapMode;
		public VkSamplerAddressMode addressModeU;
		public VkSamplerAddressMode addressModeV;
		public VkSamplerAddressMode addressModeW;
		public float mipLodBias;
		public VkBool32 anisotropyEnable;
		public float maxAnisotropy;
		public VkBool32 compareEnable;
		public VkCompareOp compareOp;
		public float minLod;
		public float maxLod;
		public VkBorderColor borderColor;
		public VkBool32 unnormalizedCoordinates;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandPoolCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCommandPoolCreateFlagBits flags;
		public uint queueFamilyIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCommandPool commandPool;
		public VkCommandBufferLevel level;
		public uint commandBufferCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPass renderPass;
		public uint subpass;
		public VkFramebuffer framebuffer;
		public VkBool32 occlusionQueryEnable;
		public VkQueryControlFlagBits queryFlags;
		public VkQueryPipelineStatisticFlagBits pipelineStatistics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCommandBufferUsageFlagBits flags;
		public VkCommandBufferInheritanceInfo* pInheritanceInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPass renderPass;
		public VkFramebuffer framebuffer;
		public VkRect2D renderArea;
		public uint clearValueCount;
		public VkClearValue* pClearValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkClearDepthStencilValue
	{
		public float depth;
		public uint stencil;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkClearAttachment
	{
		public VkImageAspectFlagBits aspectMask;
		public uint colorAttachment;
		public VkClearValue clearValue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentDescription
	{
		public VkAttachmentDescriptionFlagBits flags;
		public VkFormat format;
		public VkSampleCountFlagBits samples;
		public VkAttachmentLoadOp loadOp;
		public VkAttachmentStoreOp storeOp;
		public VkAttachmentLoadOp stencilLoadOp;
		public VkAttachmentStoreOp stencilStoreOp;
		public VkImageLayout initialLayout;
		public VkImageLayout finalLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentReference
	{
		public uint attachment;
		public VkImageLayout layout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDescription
	{
		public VkSubpassDescriptionFlagBits flags;
		public VkPipelineBindPoint pipelineBindPoint;
		public uint inputAttachmentCount;
		public VkAttachmentReference* pInputAttachments;
		public uint colorAttachmentCount;
		public VkAttachmentReference* pColorAttachments;
		public VkAttachmentReference* pResolveAttachments;
		public VkAttachmentReference* pDepthStencilAttachment;
		public uint preserveAttachmentCount;
		public uint* pPreserveAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDependency
	{
		public uint srcSubpass;
		public uint dstSubpass;
		public VkPipelineStageFlagBits srcStageMask;
		public VkPipelineStageFlagBits dstStageMask;
		public VkAccessFlagBits srcAccessMask;
		public VkAccessFlagBits dstAccessMask;
		public VkDependencyFlagBits dependencyFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPassCreateFlagBits flags;
		public uint attachmentCount;
		public VkAttachmentDescription* pAttachments;
		public uint subpassCount;
		public VkSubpassDescription* pSubpasses;
		public uint dependencyCount;
		public VkSubpassDependency* pDependencies;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkEventCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFenceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFenceCreateFlagBits flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFeatures
	{
		public VkBool32 robustBufferAccess;
		public VkBool32 fullDrawIndexUint32;
		public VkBool32 imageCubeArray;
		public VkBool32 independentBlend;
		public VkBool32 geometryShader;
		public VkBool32 tessellationShader;
		public VkBool32 sampleRateShading;
		public VkBool32 dualSrcBlend;
		public VkBool32 logicOp;
		public VkBool32 multiDrawIndirect;
		public VkBool32 drawIndirectFirstInstance;
		public VkBool32 depthClamp;
		public VkBool32 depthBiasClamp;
		public VkBool32 fillModeNonSolid;
		public VkBool32 depthBounds;
		public VkBool32 wideLines;
		public VkBool32 largePoints;
		public VkBool32 alphaToOne;
		public VkBool32 multiViewport;
		public VkBool32 samplerAnisotropy;
		public VkBool32 textureCompressionETC2;
		public VkBool32 textureCompressionASTC_LDR;
		public VkBool32 textureCompressionBC;
		public VkBool32 occlusionQueryPrecise;
		public VkBool32 pipelineStatisticsQuery;
		public VkBool32 vertexPipelineStoresAndAtomics;
		public VkBool32 fragmentStoresAndAtomics;
		public VkBool32 shaderTessellationAndGeometryPointSize;
		public VkBool32 shaderImageGatherExtended;
		public VkBool32 shaderStorageImageExtendedFormats;
		public VkBool32 shaderStorageImageMultisample;
		public VkBool32 shaderStorageImageReadWithoutFormat;
		public VkBool32 shaderStorageImageWriteWithoutFormat;
		public VkBool32 shaderUniformBufferArrayDynamicIndexing;
		public VkBool32 shaderSampledImageArrayDynamicIndexing;
		public VkBool32 shaderStorageBufferArrayDynamicIndexing;
		public VkBool32 shaderStorageImageArrayDynamicIndexing;
		public VkBool32 shaderClipDistance;
		public VkBool32 shaderCullDistance;
		public VkBool32 shaderFloat64;
		public VkBool32 shaderInt64;
		public VkBool32 shaderInt16;
		public VkBool32 shaderResourceResidency;
		public VkBool32 shaderResourceMinLod;
		public VkBool32 sparseBinding;
		public VkBool32 sparseResidencyBuffer;
		public VkBool32 sparseResidencyImage2D;
		public VkBool32 sparseResidencyImage3D;
		public VkBool32 sparseResidency2Samples;
		public VkBool32 sparseResidency4Samples;
		public VkBool32 sparseResidency8Samples;
		public VkBool32 sparseResidency16Samples;
		public VkBool32 sparseResidencyAliased;
		public VkBool32 variableMultisampleRate;
		public VkBool32 inheritedQueries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSparseProperties
	{
		public VkBool32 residencyStandard2DBlockShape;
		public VkBool32 residencyStandard2DMultisampleBlockShape;
		public VkBool32 residencyStandard3DBlockShape;
		public VkBool32 residencyAlignedMipSize;
		public VkBool32 residencyNonResidentStrict;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLimits
	{
		public uint maxImageDimension1D;
		public uint maxImageDimension2D;
		public uint maxImageDimension3D;
		public uint maxImageDimensionCube;
		public uint maxImageArrayLayers;
		public uint maxTexelBufferElements;
		public uint maxUniformBufferRange;
		public uint maxStorageBufferRange;
		public uint maxPushConstantsSize;
		public uint maxMemoryAllocationCount;
		public uint maxSamplerAllocationCount;
		public ulong bufferImageGranularity;
		public ulong sparseAddressSpaceSize;
		public uint maxBoundDescriptorSets;
		public uint maxPerStageDescriptorSamplers;
		public uint maxPerStageDescriptorUniformBuffers;
		public uint maxPerStageDescriptorStorageBuffers;
		public uint maxPerStageDescriptorSampledImages;
		public uint maxPerStageDescriptorStorageImages;
		public uint maxPerStageDescriptorInputAttachments;
		public uint maxPerStageResources;
		public uint maxDescriptorSetSamplers;
		public uint maxDescriptorSetUniformBuffers;
		public uint maxDescriptorSetUniformBuffersDynamic;
		public uint maxDescriptorSetStorageBuffers;
		public uint maxDescriptorSetStorageBuffersDynamic;
		public uint maxDescriptorSetSampledImages;
		public uint maxDescriptorSetStorageImages;
		public uint maxDescriptorSetInputAttachments;
		public uint maxVertexInputAttributes;
		public uint maxVertexInputBindings;
		public uint maxVertexInputAttributeOffset;
		public uint maxVertexInputBindingStride;
		public uint maxVertexOutputComponents;
		public uint maxTessellationGenerationLevel;
		public uint maxTessellationPatchSize;
		public uint maxTessellationControlPerVertexInputComponents;
		public uint maxTessellationControlPerVertexOutputComponents;
		public uint maxTessellationControlPerPatchOutputComponents;
		public uint maxTessellationControlTotalOutputComponents;
		public uint maxTessellationEvaluationInputComponents;
		public uint maxTessellationEvaluationOutputComponents;
		public uint maxGeometryShaderInvocations;
		public uint maxGeometryInputComponents;
		public uint maxGeometryOutputComponents;
		public uint maxGeometryOutputVertices;
		public uint maxGeometryTotalOutputComponents;
		public uint maxFragmentInputComponents;
		public uint maxFragmentOutputAttachments;
		public uint maxFragmentDualSrcAttachments;
		public uint maxFragmentCombinedOutputResources;
		public uint maxComputeSharedMemorySize;
		public uint maxComputeWorkGroupCount_0;
		public uint maxComputeWorkGroupCount_1;
		public uint maxComputeWorkGroupCount_2;
		public uint maxComputeWorkGroupInvocations;
		public uint maxComputeWorkGroupSize_0;
		public uint maxComputeWorkGroupSize_1;
		public uint maxComputeWorkGroupSize_2;
		public uint subPixelPrecisionBits;
		public uint subTexelPrecisionBits;
		public uint mipmapPrecisionBits;
		public uint maxDrawIndexedIndexValue;
		public uint maxDrawIndirectCount;
		public float maxSamplerLodBias;
		public float maxSamplerAnisotropy;
		public uint maxViewports;
		public uint maxViewportDimensions_0;
		public uint maxViewportDimensions_1;
		public float viewportBoundsRange_0;
		public float viewportBoundsRange_1;
		public uint viewportSubPixelBits;
		public UIntPtr minMemoryMapAlignment;
		public ulong minTexelBufferOffsetAlignment;
		public ulong minUniformBufferOffsetAlignment;
		public ulong minStorageBufferOffsetAlignment;
		public int minTexelOffset;
		public uint maxTexelOffset;
		public int minTexelGatherOffset;
		public uint maxTexelGatherOffset;
		public float minInterpolationOffset;
		public float maxInterpolationOffset;
		public uint subPixelInterpolationOffsetBits;
		public uint maxFramebufferWidth;
		public uint maxFramebufferHeight;
		public uint maxFramebufferLayers;
		public VkSampleCountFlagBits framebufferColorSampleCounts;
		public VkSampleCountFlagBits framebufferDepthSampleCounts;
		public VkSampleCountFlagBits framebufferStencilSampleCounts;
		public VkSampleCountFlagBits framebufferNoAttachmentsSampleCounts;
		public uint maxColorAttachments;
		public VkSampleCountFlagBits sampledImageColorSampleCounts;
		public VkSampleCountFlagBits sampledImageIntegerSampleCounts;
		public VkSampleCountFlagBits sampledImageDepthSampleCounts;
		public VkSampleCountFlagBits sampledImageStencilSampleCounts;
		public VkSampleCountFlagBits storageImageSampleCounts;
		public uint maxSampleMaskWords;
		public VkBool32 timestampComputeAndGraphics;
		public float timestampPeriod;
		public uint maxClipDistances;
		public uint maxCullDistances;
		public uint maxCombinedClipAndCullDistances;
		public uint discreteQueuePriorities;
		public float pointSizeRange_0;
		public float pointSizeRange_1;
		public float lineWidthRange_0;
		public float lineWidthRange_1;
		public float pointSizeGranularity;
		public float lineWidthGranularity;
		public VkBool32 strictLines;
		public VkBool32 standardSampleLocations;
		public ulong optimalBufferCopyOffsetAlignment;
		public ulong optimalBufferCopyRowPitchAlignment;
		public ulong nonCoherentAtomSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryPoolCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkQueryType queryType;
		public uint queryCount;
		public VkQueryPipelineStatisticFlagBits pipelineStatistics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFramebufferCreateFlagBits flags;
		public VkRenderPass renderPass;
		public uint attachmentCount;
		public VkImageView* pAttachments;
		public uint width;
		public uint height;
		public uint layers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrawIndirectCommand
	{
		public uint vertexCount;
		public uint instanceCount;
		public uint firstVertex;
		public uint firstInstance;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrawIndexedIndirectCommand
	{
		public uint indexCount;
		public uint instanceCount;
		public uint firstIndex;
		public int vertexOffset;
		public uint firstInstance;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDispatchIndirectCommand
	{
		public uint x;
		public uint y;
		public uint z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public VkSemaphore* pWaitSemaphores;
		public VkPipelineStageFlagBits* pWaitDstStageMask;
		public uint commandBufferCount;
		public VkCommandBuffer* pCommandBuffers;
		public uint signalSemaphoreCount;
		public VkSemaphore* pSignalSemaphores;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPropertiesKHR
	{
		public VkDisplayKHR display;
		public byte* displayName;
		public VkExtent2D physicalDimensions;
		public VkExtent2D physicalResolution;
		public VkSurfaceTransformFlagBitsKHR supportedTransforms;
		public VkBool32 planeReorderPossible;
		public VkBool32 persistentContent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlanePropertiesKHR
	{
		public VkDisplayKHR currentDisplay;
		public uint currentStackIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModeParametersKHR
	{
		public VkExtent2D visibleRegion;
		public uint refreshRate;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModePropertiesKHR
	{
		public VkDisplayModeKHR displayMode;
		public VkDisplayModeParametersKHR parameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModeCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDisplayModeParametersKHR parameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneCapabilitiesKHR
	{
		public VkDisplayPlaneAlphaFlagBitsKHR supportedAlpha;
		public VkOffset2D minSrcPosition;
		public VkOffset2D maxSrcPosition;
		public VkExtent2D minSrcExtent;
		public VkExtent2D maxSrcExtent;
		public VkOffset2D minDstPosition;
		public VkOffset2D maxDstPosition;
		public VkExtent2D minDstExtent;
		public VkExtent2D maxDstExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplaySurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDisplayModeKHR displayMode;
		public uint planeIndex;
		public uint planeStackIndex;
		public VkSurfaceTransformFlagBitsKHR transform;
		public float globalAlpha;
		public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;
		public VkExtent2D imageExtent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPresentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRect2D srcRect;
		public VkRect2D dstRect;
		public VkBool32 persistent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilitiesKHR
	{
		public uint minImageCount;
		public uint maxImageCount;
		public VkExtent2D currentExtent;
		public VkExtent2D minImageExtent;
		public VkExtent2D maxImageExtent;
		public uint maxImageArrayLayers;
		public VkSurfaceTransformFlagBitsKHR supportedTransforms;
		public VkSurfaceTransformFlagBitsKHR currentTransform;
		public VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha;
		public VkImageUsageFlagBits supportedUsageFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViSurfaceCreateInfoNN
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public void* window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWaylandSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr display;
		public IntPtr surface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWin32SurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr hinstance;
		public IntPtr hwnd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkXlibSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr dpy;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkXcbSurfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr connection;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImagePipeSurfaceCreateInfoFUCHSIA
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr imagePipeHandle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkStreamDescriptorSurfaceCreateInfoGGP
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr streamDescriptor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFormatKHR
	{
		public VkFormat format;
		public VkColorSpaceKHR colorSpace;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainCreateFlagBitsKHR flags;
		public VkSurfaceKHR surface;
		public uint minImageCount;
		public VkFormat imageFormat;
		public VkColorSpaceKHR imageColorSpace;
		public VkExtent2D imageExtent;
		public uint imageArrayLayers;
		public VkImageUsageFlagBits imageUsage;
		public VkSharingMode imageSharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
		public VkSurfaceTransformFlagBitsKHR preTransform;
		public VkCompositeAlphaFlagBitsKHR compositeAlpha;
		public VkPresentModeKHR presentMode;
		public VkBool32 clipped;
		public VkSwapchainKHR oldSwapchain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public VkSemaphore* pWaitSemaphores;
		public uint swapchainCount;
		public VkSwapchainKHR* pSwapchains;
		public uint* pImageIndices;
		public VkResult* pResults;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugReportCallbackCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDebugReportFlagBitsEXT flags;
		public IntPtr pfnCallback;
		public void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkValidationFlagsEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint disabledValidationCheckCount;
		public VkValidationCheckEXT* pDisabledValidationChecks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkValidationFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint enabledValidationFeatureCount;
		public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
		public uint disabledValidationFeatureCount;
		public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRasterizationOrderAMD rasterizationOrder;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugMarkerObjectNameInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDebugReportObjectTypeEXT objectType;
		public ulong vkObject;
		public byte* pObjectName;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugMarkerObjectTagInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDebugReportObjectTypeEXT objectType;
		public ulong vkObject;
		public ulong tagName;
		public UIntPtr tagSize;
		public void* pTag;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugMarkerMarkerInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pMarkerName;
		public float color_0;
		public float color_1;
		public float color_2;
		public float color_3;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dedicatedAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDedicatedAllocationBufferCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dedicatedAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalImageFormatPropertiesNV
	{
		public VkImageFormatProperties imageFormatProperties;
		public VkExternalMemoryFeatureFlagBitsNV externalMemoryFeatures;
		public VkExternalMemoryHandleTypeFlagBitsNV exportFromImportedHandleTypes;
		public VkExternalMemoryHandleTypeFlagBitsNV compatibleHandleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryImageCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBitsNV handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryAllocateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBitsNV handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryWin32HandleInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBitsNV handleType;
		public IntPtr handle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryWin32HandleInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public uint dwAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint acquireCount;
		public VkDeviceMemory* pAcquireSyncs;
		public ulong* pAcquireKeys;
		public uint* pAcquireTimeoutMilliseconds;
		public uint releaseCount;
		public VkDeviceMemory* pReleaseSyncs;
		public ulong* pReleaseKeys;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceGeneratedCommands;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxGraphicsShaderGroupCount;
		public uint maxIndirectSequenceCount;
		public uint maxIndirectCommandsTokenCount;
		public uint maxIndirectCommandsStreamCount;
		public uint maxIndirectCommandsTokenOffset;
		public uint maxIndirectCommandsStreamStride;
		public uint minSequencesCountBufferOffsetAlignment;
		public uint minSequencesIndexBufferOffsetAlignment;
		public uint minIndirectCommandsBufferOffsetAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGraphicsShaderGroupCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
		public VkPipelineTessellationStateCreateInfo* pTessellationState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGraphicsPipelineShaderGroupsCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint groupCount;
		public VkGraphicsShaderGroupCreateInfoNV* pGroups;
		public uint pipelineCount;
		public VkPipeline* pPipelines;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindShaderGroupIndirectCommandNV
	{
		public uint groupIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindIndexBufferIndirectCommandNV
	{
		public ulong bufferAddress;
		public uint size;
		public VkIndexType indexType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindVertexBufferIndirectCommandNV
	{
		public ulong bufferAddress;
		public uint size;
		public uint stride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSetStateFlagsIndirectCommandNV
	{
		public uint data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIndirectCommandsStreamNV
	{
		public VkBuffer buffer;
		public ulong offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIndirectCommandsLayoutTokenNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkIndirectCommandsTokenTypeNV tokenType;
		public uint stream;
		public uint offset;
		public uint vertexBindingUnit;
		public VkBool32 vertexDynamicStride;
		public VkPipelineLayout pushconstantPipelineLayout;
		public VkShaderStageFlagBits pushconstantShaderStageFlags;
		public uint pushconstantOffset;
		public uint pushconstantSize;
		public VkIndirectStateFlagBitsNV indirectStateFlags;
		public uint indexTypeCount;
		public VkIndexType* pIndexTypes;
		public uint* pIndexTypeValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkIndirectCommandsLayoutUsageFlagBitsNV flags;
		public VkPipelineBindPoint pipelineBindPoint;
		public uint tokenCount;
		public VkIndirectCommandsLayoutTokenNV* pTokens;
		public uint streamCount;
		public uint* pStreamStrides;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeneratedCommandsInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineBindPoint pipelineBindPoint;
		public VkPipeline pipeline;
		public VkIndirectCommandsLayoutNV indirectCommandsLayout;
		public uint streamCount;
		public VkIndirectCommandsStreamNV* pStreams;
		public uint sequencesCount;
		public VkBuffer preprocessBuffer;
		public ulong preprocessOffset;
		public ulong preprocessSize;
		public VkBuffer sequencesCountBuffer;
		public ulong sequencesCountOffset;
		public VkBuffer sequencesIndexBuffer;
		public ulong sequencesIndexOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeneratedCommandsMemoryRequirementsInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineBindPoint pipelineBindPoint;
		public VkPipeline pipeline;
		public VkIndirectCommandsLayoutNV indirectCommandsLayout;
		public uint maxSequencesCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFeatures2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPhysicalDeviceFeatures features;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPhysicalDeviceProperties properties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFormatProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormatProperties formatProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageFormatProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageFormatProperties imageFormatProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageFormatInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public VkImageType type;
		public VkImageTiling tiling;
		public VkImageUsageFlagBits usage;
		public VkImageCreateFlagBits flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueueFamilyProperties queueFamilyProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPhysicalDeviceMemoryProperties memoryProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageFormatProperties2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSparseImageFormatProperties properties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public VkImageType type;
		public VkSampleCountFlagBits samples;
		public VkImageUsageFlagBits usage;
		public VkImageTiling tiling;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePushDescriptorPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxPushDescriptors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkConformanceVersion
	{
		public byte major;
		public byte minor;
		public byte subminor;
		public byte patch;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDriverProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDriverId driverID;
		public fixed byte driverName[(int)Vulkan.VK_MAX_DRIVER_NAME_SIZE];
		public fixed byte driverInfo[(int)Vulkan.VK_MAX_DRIVER_INFO_SIZE];
		public VkConformanceVersion conformanceVersion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentRegionsKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public VkPresentRegionKHR* pRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentRegionKHR
	{
		public uint rectangleCount;
		public VkRectLayerKHR* pRectangles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRectLayerKHR
	{
		public VkOffset2D offset;
		public VkExtent2D extent;
		public uint layer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVariablePointersFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 variablePointersStorageBuffer;
		public VkBool32 variablePointers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryProperties
	{
		public VkExternalMemoryFeatureFlagBits externalMemoryFeatures;
		public VkExternalMemoryHandleTypeFlagBits exportFromImportedHandleTypes;
		public VkExternalMemoryHandleTypeFlagBits compatibleHandleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalImageFormatProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryProperties externalMemoryProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalBufferInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBufferCreateFlagBits flags;
		public VkBufferUsageFlagBits usage;
		public VkExternalMemoryHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalBufferProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryProperties externalMemoryProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceIDProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte deviceUUID[(int)Vulkan.VK_UUID_SIZE];
		public fixed byte driverUUID[(int)Vulkan.VK_UUID_SIZE];
		public fixed byte deviceLUID[(int)Vulkan.VK_LUID_SIZE];
		public uint deviceNodeMask;
		public VkBool32 deviceLUIDValid;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryImageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBits handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalMemoryBufferCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBits handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBits handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBits handleType;
		public IntPtr handle;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportMemoryWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public uint dwAccess;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryWin32HandlePropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public VkExternalMemoryHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBits handleType;
		public int fd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryFdPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
		public VkExternalMemoryHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint acquireCount;
		public VkDeviceMemory* pAcquireSyncs;
		public ulong* pAcquireKeys;
		public uint* pAcquireTimeouts;
		public uint releaseCount;
		public VkDeviceMemory* pReleaseSyncs;
		public ulong* pReleaseKeys;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalSemaphoreHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalSemaphoreProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalSemaphoreHandleTypeFlagBits exportFromImportedHandleTypes;
		public VkExternalSemaphoreHandleTypeFlagBits compatibleHandleTypes;
		public VkExternalSemaphoreFeatureFlagBits externalSemaphoreFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportSemaphoreCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalSemaphoreHandleTypeFlagBits handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkSemaphoreImportFlagBits flags;
		public VkExternalSemaphoreHandleTypeFlagBits handleType;
		public IntPtr handle;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public uint dwAccess;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkD3D12FenceSubmitInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreValuesCount;
		public ulong* pWaitSemaphoreValues;
		public uint signalSemaphoreValuesCount;
		public ulong* pSignalSemaphoreValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreGetWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkExternalSemaphoreHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportSemaphoreFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkSemaphoreImportFlagBits flags;
		public VkExternalSemaphoreHandleTypeFlagBits handleType;
		public int fd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreGetFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public VkExternalSemaphoreHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalFenceInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalFenceHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalFenceProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalFenceHandleTypeFlagBits exportFromImportedHandleTypes;
		public VkExternalFenceHandleTypeFlagBits compatibleHandleTypes;
		public VkExternalFenceFeatureFlagBits externalFenceFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportFenceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalFenceHandleTypeFlagBits handleTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportFenceWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkFenceImportFlagBits flags;
		public VkExternalFenceHandleTypeFlagBits handleType;
		public IntPtr handle;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExportFenceWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr pAttributes;
		public uint dwAccess;
		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFenceGetWin32HandleInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkExternalFenceHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportFenceFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkFenceImportFlagBits flags;
		public VkExternalFenceHandleTypeFlagBits handleType;
		public int fd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFenceGetFdInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFence fence;
		public VkExternalFenceHandleTypeFlagBits handleType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 multiview;
		public VkBool32 multiviewGeometryShader;
		public VkBool32 multiviewTessellationShader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxMultiviewViewCount;
		public uint maxMultiviewInstanceIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassMultiviewCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint subpassCount;
		public uint* pViewMasks;
		public uint dependencyCount;
		public int* pViewOffsets;
		public uint correlationMaskCount;
		public uint* pCorrelationMasks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilities2EXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint minImageCount;
		public uint maxImageCount;
		public VkExtent2D currentExtent;
		public VkExtent2D minImageExtent;
		public VkExtent2D maxImageExtent;
		public uint maxImageArrayLayers;
		public VkSurfaceTransformFlagBitsKHR supportedTransforms;
		public VkSurfaceTransformFlagBitsKHR currentTransform;
		public VkCompositeAlphaFlagBitsKHR supportedCompositeAlpha;
		public VkImageUsageFlagBits supportedUsageFlags;
		public VkSurfaceCounterFlagBitsEXT supportedSurfaceCounters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPowerInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPowerStateEXT powerState;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceEventInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceEventTypeEXT deviceEvent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayEventInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayEventTypeEXT displayEvent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainCounterCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceCounterFlagBitsEXT surfaceCounters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceGroupProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint physicalDeviceCount;
		public VkPhysicalDevice physicalDevices_0;
		public VkPhysicalDevice physicalDevices_1;
		public VkPhysicalDevice physicalDevices_2;
		public VkPhysicalDevice physicalDevices_3;
		public VkPhysicalDevice physicalDevices_4;
		public VkPhysicalDevice physicalDevices_5;
		public VkPhysicalDevice physicalDevices_6;
		public VkPhysicalDevice physicalDevices_7;
		public VkPhysicalDevice physicalDevices_8;
		public VkPhysicalDevice physicalDevices_9;
		public VkPhysicalDevice physicalDevices_10;
		public VkPhysicalDevice physicalDevices_11;
		public VkPhysicalDevice physicalDevices_12;
		public VkPhysicalDevice physicalDevices_13;
		public VkPhysicalDevice physicalDevices_14;
		public VkPhysicalDevice physicalDevices_15;
		public VkPhysicalDevice physicalDevices_16;
		public VkPhysicalDevice physicalDevices_17;
		public VkPhysicalDevice physicalDevices_18;
		public VkPhysicalDevice physicalDevices_19;
		public VkPhysicalDevice physicalDevices_20;
		public VkPhysicalDevice physicalDevices_21;
		public VkPhysicalDevice physicalDevices_22;
		public VkPhysicalDevice physicalDevices_23;
		public VkPhysicalDevice physicalDevices_24;
		public VkPhysicalDevice physicalDevices_25;
		public VkPhysicalDevice physicalDevices_26;
		public VkPhysicalDevice physicalDevices_27;
		public VkPhysicalDevice physicalDevices_28;
		public VkPhysicalDevice physicalDevices_29;
		public VkPhysicalDevice physicalDevices_30;
		public VkPhysicalDevice physicalDevices_31;
		public VkBool32 subsetAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryAllocateFlagsInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryAllocateFlagBits flags;
		public uint deviceMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindBufferMemoryInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceIndexCount;
		public uint* pDeviceIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImageMemoryInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImageMemoryDeviceGroupInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceIndexCount;
		public uint* pDeviceIndices;
		public uint splitInstanceBindRegionCount;
		public VkRect2D* pSplitInstanceBindRegions;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupRenderPassBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceMask;
		public uint deviceRenderAreaCount;
		public VkRect2D* pDeviceRenderAreas;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint deviceMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreCount;
		public uint* pWaitSemaphoreDeviceIndices;
		public uint commandBufferCount;
		public uint* pCommandBufferDeviceMasks;
		public uint signalSemaphoreCount;
		public uint* pSignalSemaphoreDeviceIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupBindSparseInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint resourceDeviceIndex;
		public uint memoryDeviceIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed uint presentMask[(int)Vulkan.VK_MAX_DEVICE_GROUP_SIZE];
		public VkDeviceGroupPresentModeFlagBitsKHR modes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSwapchainCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainKHR swapchain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImageMemorySwapchainInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainKHR swapchain;
		public uint imageIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAcquireNextImageInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainKHR swapchain;
		public ulong timeout;
		public VkSemaphore semaphore;
		public VkFence fence;
		public uint deviceMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupPresentInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public uint* pDeviceMasks;
		public VkDeviceGroupPresentModeFlagBitsKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupDeviceCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint physicalDeviceCount;
		public VkPhysicalDevice* pPhysicalDevices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceGroupSwapchainCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceGroupPresentModeFlagBitsKHR modes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorUpdateTemplateEntry
	{
		public uint dstBinding;
		public uint dstArrayElement;
		public uint descriptorCount;
		public VkDescriptorType descriptorType;
		public UIntPtr offset;
		public UIntPtr stride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint descriptorUpdateEntryCount;
		public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
		public VkDescriptorUpdateTemplateType templateType;
		public VkDescriptorSetLayout descriptorSetLayout;
		public VkPipelineBindPoint pipelineBindPoint;
		public VkPipelineLayout pipelineLayout;
		public uint set;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkXYColorEXT
	{
		public float x;
		public float y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkHdrMetadataEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkXYColorEXT displayPrimaryRed;
		public VkXYColorEXT displayPrimaryGreen;
		public VkXYColorEXT displayPrimaryBlue;
		public VkXYColorEXT whitePoint;
		public float maxLuminance;
		public float minLuminance;
		public float maxContentLightLevel;
		public float maxFrameAverageLightLevel;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 localDimmingSupport;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 localDimmingEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRefreshCycleDurationGOOGLE
	{
		public ulong refreshDuration;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPastPresentationTimingGOOGLE
	{
		public uint presentID;
		public ulong desiredPresentTime;
		public ulong actualPresentTime;
		public ulong earliestPresentTime;
		public ulong presentMargin;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentTimesInfoGOOGLE
	{
		public VkStructureType sType;
		public void* pNext;
		public uint swapchainCount;
		public VkPresentTimeGOOGLE* pTimes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentTimeGOOGLE
	{
		public uint presentID;
		public ulong desiredPresentTime;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkIOSSurfaceCreateInfoMVK
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public void* pView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMacOSSurfaceCreateInfoMVK
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public void* pView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMetalSurfaceCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public IntPtr pLayer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViewportWScalingNV
	{
		public float xcoeff;
		public float ycoeff;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 viewportWScalingEnable;
		public uint viewportCount;
		public VkViewportWScalingNV* pViewportWScalings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkViewportSwizzleNV
	{
		public VkViewportCoordinateSwizzleNV x;
		public VkViewportCoordinateSwizzleNV y;
		public VkViewportCoordinateSwizzleNV z;
		public VkViewportCoordinateSwizzleNV w;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint viewportCount;
		public VkViewportSwizzleNV* pViewportSwizzles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxDiscardRectangles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDiscardRectangleModeEXT discardRectangleMode;
		public uint discardRectangleCount;
		public VkRect2D* pDiscardRectangles;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 perViewPositionAllComponents;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkInputAttachmentAspectReference
	{
		public uint subpass;
		public uint inputAttachmentIndex;
		public VkImageAspectFlagBits aspectMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint aspectReferenceCount;
		public VkInputAttachmentAspectReference* pAspectReferences;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceKHR surface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilities2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceCapabilitiesKHR surfaceCapabilities;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFormat2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceFormatKHR surfaceFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayProperties2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPropertiesKHR displayProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneProperties2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPlanePropertiesKHR displayPlaneProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayModeProperties2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayModePropertiesKHR displayModeProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneInfo2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayModeKHR mode;
		public uint planeIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDisplayPlaneCapabilities2KHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDisplayPlaneCapabilitiesKHR capabilities;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSharedPresentSurfaceCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageUsageFlagBits sharedPresentSupportedUsageFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevice16BitStorageFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 storageBuffer16BitAccess;
		public VkBool32 uniformAndStorageBuffer16BitAccess;
		public VkBool32 storagePushConstant16;
		public VkBool32 storageInputOutput16;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubgroupProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint subgroupSize;
		public VkShaderStageFlagBits supportedStages;
		public VkSubgroupFeatureFlagBits supportedOperations;
		public VkBool32 quadOperationsInAllStages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSubgroupExtendedTypes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferMemoryRequirementsInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageMemoryRequirementsInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageSparseMemoryRequirementsInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryRequirements2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryRequirements memoryRequirements;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSparseImageMemoryRequirements2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSparseImageMemoryRequirements memoryRequirements;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePointClippingProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPointClippingBehavior pointClippingBehavior;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryDedicatedRequirements
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 prefersDedicatedAllocation;
		public VkBool32 requiresDedicatedAllocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryDedicatedAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImage image;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewUsageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageUsageFlagBits usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkTessellationDomainOrigin domainOrigin;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerYcbcrConversionInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSamplerYcbcrConversion conversion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerYcbcrConversionCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public VkSamplerYcbcrModelConversion ycbcrModel;
		public VkSamplerYcbcrRange ycbcrRange;
		public VkComponentMapping components;
		public VkChromaLocation xChromaOffset;
		public VkChromaLocation yChromaOffset;
		public VkFilter chromaFilter;
		public VkBool32 forceExplicitReconstruction;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindImagePlaneMemoryInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageAspectFlagBits planeAspect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImagePlaneMemoryRequirementsInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageAspectFlagBits planeAspect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 samplerYcbcrConversion;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerYcbcrConversionImageFormatProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint combinedImageSamplerDescriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTextureLODGatherFormatPropertiesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 supportsTextureGatherLODBiasAMD;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkConditionalRenderingBeginInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
		public ulong offset;
		public VkConditionalRenderingFlagBitsEXT flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkProtectedSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 protectedSubmit;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProtectedMemoryFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 protectedMemory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceProtectedMemoryProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 protectedNoFault;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceQueueInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceQueueCreateFlagBits flags;
		public uint queueFamilyIndex;
		public uint queueIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 coverageToColorEnable;
		public uint coverageToColorLocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 filterMinmaxSingleComponentFormats;
		public VkBool32 filterMinmaxImageComponentMapping;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSampleLocationEXT
	{
		public float x;
		public float y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSampleLocationsInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSampleCountFlagBits sampleLocationsPerPixel;
		public VkExtent2D sampleLocationGridSize;
		public uint sampleLocationsCount;
		public VkSampleLocationEXT* pSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentSampleLocationsEXT
	{
		public uint attachmentIndex;
		public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassSampleLocationsEXT
	{
		public uint subpassIndex;
		public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachmentInitialSampleLocationsCount;
		public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
		public uint postSubpassSampleLocationsCount;
		public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineSampleLocationsStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 sampleLocationsEnable;
		public VkSampleLocationsInfoEXT sampleLocationsInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSampleCountFlagBits sampleLocationSampleCounts;
		public VkExtent2D maxSampleLocationGridSize;
		public float sampleLocationCoordinateRange_0;
		public float sampleLocationCoordinateRange_1;
		public uint sampleLocationSubPixelBits;
		public VkBool32 variableSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMultisamplePropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D maxSampleLocationGridSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSamplerReductionModeCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSamplerReductionMode reductionMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 advancedBlendCoherentOperations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint advancedBlendMaxColorAttachments;
		public VkBool32 advancedBlendIndependentBlend;
		public VkBool32 advancedBlendNonPremultipliedSrcColor;
		public VkBool32 advancedBlendNonPremultipliedDstColor;
		public VkBool32 advancedBlendCorrelatedOverlap;
		public VkBool32 advancedBlendAllOperations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 srcPremultiplied;
		public VkBool32 dstPremultiplied;
		public VkBlendOverlapEXT blendOverlap;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 inlineUniformBlock;
		public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxInlineUniformBlockSize;
		public uint maxPerStageDescriptorInlineUniformBlocks;
		public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
		public uint maxDescriptorSetInlineUniformBlocks;
		public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWriteDescriptorSetInlineUniformBlockEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxInlineUniformBlockBindings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkCoverageModulationModeNV coverageModulationMode;
		public VkBool32 coverageModulationTableEnable;
		public uint coverageModulationTableCount;
		public float* pCoverageModulationTable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageFormatListCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint viewFormatCount;
		public VkFormat* pViewFormats;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkValidationCacheCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public UIntPtr initialDataSize;
		public void* pInitialData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderModuleValidationCacheCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkValidationCacheEXT validationCache;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMaintenance3Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxPerSetDescriptors;
		public ulong maxMemoryAllocationSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutSupport
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 supported;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderDrawParametersFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderDrawParameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderFloat16;
		public VkBool32 shaderInt8;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderFloatControlsIndependence denormBehaviorIndependence;
		public VkShaderFloatControlsIndependence roundingModeIndependence;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
		public VkBool32 shaderDenormPreserveFloat16;
		public VkBool32 shaderDenormPreserveFloat32;
		public VkBool32 shaderDenormPreserveFloat64;
		public VkBool32 shaderDenormFlushToZeroFloat16;
		public VkBool32 shaderDenormFlushToZeroFloat32;
		public VkBool32 shaderDenormFlushToZeroFloat64;
		public VkBool32 shaderRoundingModeRTEFloat16;
		public VkBool32 shaderRoundingModeRTEFloat32;
		public VkBool32 shaderRoundingModeRTEFloat64;
		public VkBool32 shaderRoundingModeRTZFloat16;
		public VkBool32 shaderRoundingModeRTZFloat32;
		public VkBool32 shaderRoundingModeRTZFloat64;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceHostQueryResetFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 hostQueryReset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkNativeBufferUsage2ANDROID
	{
		public ulong consumer;
		public ulong producer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkNativeBufferANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public void* handle;
		public int stride;
		public int format;
		public int usage;
		public VkNativeBufferUsage2ANDROID usage2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSwapchainImageCreateInfoANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSwapchainImageUsageFlagBitsANDROID usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePresentationPropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 sharedImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderResourceUsageAMD
	{
		public uint numUsedVgprs;
		public uint numUsedSgprs;
		public uint ldsSizePerLocalWorkGroup;
		public UIntPtr ldsUsageSizeInBytes;
		public UIntPtr scratchMemUsageInBytes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShaderStatisticsInfoAMD
	{
		public VkShaderStageFlagBits shaderStageMask;
		public VkShaderResourceUsageAMD resourceUsage;
		public uint numPhysicalVgprs;
		public uint numPhysicalSgprs;
		public uint numAvailableVgprs;
		public uint numAvailableSgprs;
		public uint computeWorkGroupSize_0;
		public uint computeWorkGroupSize_1;
		public uint computeWorkGroupSize_2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueueGlobalPriorityEXT globalPriority;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsObjectNameInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkObjectType objectType;
		public ulong objectHandle;
		public byte* pObjectName;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsObjectTagInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkObjectType objectType;
		public ulong objectHandle;
		public ulong tagName;
		public UIntPtr tagSize;
		public void* pTag;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsLabelEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* pLabelName;
		public float color_0;
		public float color_1;
		public float color_2;
		public float color_3;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkDebugUtilsMessageSeverityFlagBitsEXT messageSeverity;
		public VkDebugUtilsMessageTypeFlagBitsEXT messageType;
		public IntPtr pfnUserCallback;
		public void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public byte* pMessageIdName;
		public int messageIdNumber;
		public byte* pMessage;
		public uint queueLabelCount;
		public VkDebugUtilsLabelEXT* pQueueLabels;
		public uint cmdBufLabelCount;
		public VkDebugUtilsLabelEXT* pCmdBufLabels;
		public uint objectCount;
		public VkDebugUtilsObjectNameInfoEXT* pObjects;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportMemoryHostPointerInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExternalMemoryHandleTypeFlagBits handleType;
		public void* pHostPointer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryHostPointerPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong minImportedHostPointerAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public float primitiveOverestimationSize;
		public float maxExtraPrimitiveOverestimationSize;
		public float extraPrimitiveOverestimationSizeGranularity;
		public VkBool32 primitiveUnderestimation;
		public VkBool32 conservativePointAndLineRasterization;
		public VkBool32 degenerateTrianglesRasterized;
		public VkBool32 degenerateLinesRasterized;
		public VkBool32 fullyCoveredFragmentShaderInputVariable;
		public VkBool32 conservativeRasterizationPostDepthCoverage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCalibratedTimestampInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkTimeDomainEXT timeDomain;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderEngineCount;
		public uint shaderArraysPerEngineCount;
		public uint computeUnitsPerShaderArray;
		public uint simdPerComputeUnit;
		public uint wavefrontsPerSimd;
		public uint wavefrontSize;
		public uint sgprsPerSimd;
		public uint minSgprAllocation;
		public uint maxSgprAllocation;
		public uint sgprAllocationGranularity;
		public uint vgprsPerSimd;
		public uint minVgprAllocation;
		public uint maxVgprAllocation;
		public uint vgprAllocationGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderCoreProperties2AMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderCorePropertiesFlagBitsAMD shaderCoreFeatures;
		public uint activeComputeUnitCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
		public float extraPrimitiveOverestimationSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
		public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
		public VkBool32 shaderSampledImageArrayNonUniformIndexing;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageImageArrayNonUniformIndexing;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
		public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
		public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
		public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUpdateUnusedWhilePending;
		public VkBool32 descriptorBindingPartiallyBound;
		public VkBool32 descriptorBindingVariableDescriptorCount;
		public VkBool32 runtimeDescriptorArray;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDescriptorIndexingProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxUpdateAfterBindDescriptorsInAllPools;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
		public VkBool32 robustBufferAccessUpdateAfterBind;
		public VkBool32 quadDivergentImplicitLod;
		public uint maxPerStageDescriptorUpdateAfterBindSamplers;
		public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
		public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
		public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
		public uint maxPerStageUpdateAfterBindResources;
		public uint maxDescriptorSetUpdateAfterBindSamplers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindSampledImages;
		public uint maxDescriptorSetUpdateAfterBindStorageImages;
		public uint maxDescriptorSetUpdateAfterBindInputAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint bindingCount;
		public VkDescriptorBindingFlagBits* pBindingFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint descriptorSetCount;
		public uint* pDescriptorCounts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupport
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxVariableDescriptorCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentDescription2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAttachmentDescriptionFlagBits flags;
		public VkFormat format;
		public VkSampleCountFlagBits samples;
		public VkAttachmentLoadOp loadOp;
		public VkAttachmentStoreOp storeOp;
		public VkAttachmentLoadOp stencilLoadOp;
		public VkAttachmentStoreOp stencilStoreOp;
		public VkImageLayout initialLayout;
		public VkImageLayout finalLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentReference2
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachment;
		public VkImageLayout layout;
		public VkImageAspectFlagBits aspectMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDescription2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSubpassDescriptionFlagBits flags;
		public VkPipelineBindPoint pipelineBindPoint;
		public uint viewMask;
		public uint inputAttachmentCount;
		public VkAttachmentReference2* pInputAttachments;
		public uint colorAttachmentCount;
		public VkAttachmentReference2* pColorAttachments;
		public VkAttachmentReference2* pResolveAttachments;
		public VkAttachmentReference2* pDepthStencilAttachment;
		public uint preserveAttachmentCount;
		public uint* pPreserveAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDependency2
	{
		public VkStructureType sType;
		public void* pNext;
		public uint srcSubpass;
		public uint dstSubpass;
		public VkPipelineStageFlagBits srcStageMask;
		public VkPipelineStageFlagBits dstStageMask;
		public VkAccessFlagBits srcAccessMask;
		public VkAccessFlagBits dstAccessMask;
		public VkDependencyFlagBits dependencyFlags;
		public int viewOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassCreateInfo2
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRenderPassCreateFlagBits flags;
		public uint attachmentCount;
		public VkAttachmentDescription2* pAttachments;
		public uint subpassCount;
		public VkSubpassDescription2* pSubpasses;
		public uint dependencyCount;
		public VkSubpassDependency2* pDependencies;
		public uint correlatedViewMaskCount;
		public uint* pCorrelatedViewMasks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSubpassContents contents;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassEndInfo
	{
		public VkStructureType sType;
		public void* pNext;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 timelineSemaphore;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong maxTimelineSemaphoreValueDifference;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreTypeCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphoreType semaphoreType;
		public ulong initialValue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTimelineSemaphoreSubmitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint waitSemaphoreValueCount;
		public ulong* pWaitSemaphoreValues;
		public uint signalSemaphoreValueCount;
		public ulong* pSignalSemaphoreValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreWaitInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphoreWaitFlagBits flags;
		public uint semaphoreCount;
		public VkSemaphore* pSemaphores;
		public ulong* pValues;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSemaphoreSignalInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSemaphore semaphore;
		public ulong value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkVertexInputBindingDivisorDescriptionEXT
	{
		public uint binding;
		public uint divisor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint vertexBindingDivisorCount;
		public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxVertexAttribDivisor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePCIBusInfoPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint pciDomain;
		public uint pciBus;
		public uint pciDevice;
		public uint pciFunction;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImportAndroidHardwareBufferInfoANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferUsageANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong androidHardwareBufferUsage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferPropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong allocationSize;
		public uint memoryTypeBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat format;
		public ulong externalFormat;
		public VkFormatFeatureFlagBits formatFeatures;
		public VkComponentMapping samplerYcbcrConversionComponents;
		public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
		public VkSamplerYcbcrRange suggestedYcbcrRange;
		public VkChromaLocation suggestedXChromaOffset;
		public VkChromaLocation suggestedYChromaOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 conditionalRenderingEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkExternalFormatANDROID
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong externalFormat;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevice8BitStorageFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 storageBuffer8BitAccess;
		public VkBool32 uniformAndStorageBuffer8BitAccess;
		public VkBool32 storagePushConstant8;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 conditionalRendering;
		public VkBool32 inheritedConditionalRendering;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 vulkanMemoryModel;
		public VkBool32 vulkanMemoryModelDeviceScope;
		public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderBufferInt64Atomics;
		public VkBool32 shaderSharedInt64Atomics;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 vertexAttributeInstanceRateDivisor;
		public VkBool32 vertexAttributeInstanceRateZeroDivisor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineStageFlagBits checkpointExecutionStageMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCheckpointDataNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineStageFlagBits stage;
		public void* pCheckpointMarker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDepthStencilResolveProperties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkResolveModeFlagBits supportedDepthResolveModes;
		public VkResolveModeFlagBits supportedStencilResolveModes;
		public VkBool32 independentResolveNone;
		public VkBool32 independentResolve;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSubpassDescriptionDepthStencilResolve
	{
		public VkStructureType sType;
		public void* pNext;
		public VkResolveModeFlagBits depthResolveMode;
		public VkResolveModeFlagBits stencilResolveMode;
		public VkAttachmentReference2* pDepthStencilResolveAttachment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewASTCDecodeModeEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat decodeMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 decodeModeSharedExponent;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 transformFeedback;
		public VkBool32 geometryStreams;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxTransformFeedbackStreams;
		public uint maxTransformFeedbackBuffers;
		public ulong maxTransformFeedbackBufferSize;
		public uint maxTransformFeedbackStreamDataSize;
		public uint maxTransformFeedbackBufferDataSize;
		public uint maxTransformFeedbackBufferDataStride;
		public VkBool32 transformFeedbackQueries;
		public VkBool32 transformFeedbackStreamsLinesTriangles;
		public VkBool32 transformFeedbackRasterizationStreamSelect;
		public VkBool32 transformFeedbackDraw;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public uint rasterizationStream;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 representativeFragmentTest;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 representativeFragmentTestEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceExclusiveScissorFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 exclusiveScissor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint exclusiveScissorCount;
		public VkRect2D* pExclusiveScissors;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 cornerSampledImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 computeDerivativeGroupQuads;
		public VkBool32 computeDerivativeGroupLinear;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentShaderBarycentric;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imageFootprint;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 dedicatedAllocationImageAliasing;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkShadingRatePaletteNV
	{
		public uint shadingRatePaletteEntryCount;
		public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shadingRateImageEnable;
		public uint viewportCount;
		public VkShadingRatePaletteNV* pShadingRatePalettes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShadingRateImageFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shadingRateImage;
		public VkBool32 shadingRateCoarseSampleOrder;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShadingRateImagePropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D shadingRateTexelSize;
		public uint shadingRatePaletteSize;
		public uint shadingRateMaxCoarseSamples;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCoarseSampleLocationNV
	{
		public uint pixelX;
		public uint pixelY;
		public uint sample;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCoarseSampleOrderCustomNV
	{
		public VkShadingRatePaletteEntryNV shadingRate;
		public uint sampleCount;
		public uint sampleLocationCount;
		public VkCoarseSampleLocationNV* pSampleLocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCoarseSampleOrderTypeNV sampleOrderType;
		public uint customSampleOrderCount;
		public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 taskShader;
		public VkBool32 meshShader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxDrawMeshTasksCount;
		public uint maxTaskWorkGroupInvocations;
		public uint maxTaskWorkGroupSize_0;
		public uint maxTaskWorkGroupSize_1;
		public uint maxTaskWorkGroupSize_2;
		public uint maxTaskTotalMemorySize;
		public uint maxTaskOutputCount;
		public uint maxMeshWorkGroupInvocations;
		public uint maxMeshWorkGroupSize_0;
		public uint maxMeshWorkGroupSize_1;
		public uint maxMeshWorkGroupSize_2;
		public uint maxMeshTotalMemorySize;
		public uint maxMeshOutputVertices;
		public uint maxMeshOutputPrimitives;
		public uint maxMeshMultiviewViewCount;
		public uint meshOutputPerVertexGranularity;
		public uint meshOutputPerPrimitiveGranularity;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrawMeshTasksIndirectCommandNV
	{
		public uint taskCount;
		public uint firstTask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRayTracingShaderGroupTypeKHR type;
		public uint generalShader;
		public uint closestHitShader;
		public uint anyHitShader;
		public uint intersectionShader;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingShaderGroupCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkRayTracingShaderGroupTypeKHR type;
		public uint generalShader;
		public uint closestHitShader;
		public uint anyHitShader;
		public uint intersectionShader;
		public void* pShaderGroupCaptureReplayHandle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingPipelineCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlagBits flags;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public uint groupCount;
		public VkRayTracingShaderGroupCreateInfoNV* pGroups;
		public uint maxRecursionDepth;
		public VkPipelineLayout layout;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingPipelineCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreateFlagBits flags;
		public uint stageCount;
		public VkPipelineShaderStageCreateInfo* pStages;
		public uint groupCount;
		public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
		public uint maxRecursionDepth;
		public VkPipelineLibraryCreateInfoKHR libraries;
		public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
		public VkPipelineLayout layout;
		public VkPipeline basePipelineHandle;
		public int basePipelineIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryTrianglesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer vertexData;
		public ulong vertexOffset;
		public uint vertexCount;
		public ulong vertexStride;
		public VkFormat vertexFormat;
		public VkBuffer indexData;
		public ulong indexOffset;
		public uint indexCount;
		public VkIndexType indexType;
		public VkBuffer transformData;
		public ulong transformOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryAABBNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer aabbData;
		public uint numAABBs;
		public uint stride;
		public ulong offset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryDataNV
	{
		public VkGeometryTrianglesNV triangles;
		public VkGeometryAABBNV aabbs;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkGeometryNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkGeometryTypeKHR geometryType;
		public VkGeometryDataNV geometry;
		public VkGeometryFlagBitsKHR flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureTypeKHR type;
		public VkBuildAccelerationStructureFlagBitsKHR flags;
		public uint instanceCount;
		public uint geometryCount;
		public VkGeometryNV* pGeometries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong compactedSize;
		public VkAccelerationStructureInfoNV info;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBindAccelerationStructureMemoryInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR accelerationStructure;
		public VkDeviceMemory memory;
		public ulong memoryOffset;
		public uint deviceIndexCount;
		public uint* pDeviceIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkWriteDescriptorSetAccelerationStructureKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint accelerationStructureCount;
		public VkAccelerationStructureKHR* pAccelerationStructures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureMemoryRequirementsTypeKHR type;
		public VkAccelerationStructureBuildTypeKHR buildType;
		public VkAccelerationStructureKHR accelerationStructure;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureMemoryRequirementsTypeKHR type;
		public VkAccelerationStructureKHR accelerationStructure;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rayTracing;
		public VkBool32 rayTracingShaderGroupHandleCaptureReplay;
		public VkBool32 rayTracingShaderGroupHandleCaptureReplayMixed;
		public VkBool32 rayTracingAccelerationStructureCaptureReplay;
		public VkBool32 rayTracingIndirectTraceRays;
		public VkBool32 rayTracingIndirectAccelerationStructureBuild;
		public VkBool32 rayTracingHostAccelerationStructureCommands;
		public VkBool32 rayQuery;
		public VkBool32 rayTracingPrimitiveCulling;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderGroupHandleSize;
		public uint maxRecursionDepth;
		public uint maxShaderGroupStride;
		public uint shaderGroupBaseAlignment;
		public ulong maxGeometryCount;
		public ulong maxInstanceCount;
		public ulong maxPrimitiveCount;
		public uint maxDescriptorSetAccelerationStructures;
		public uint shaderGroupHandleCaptureReplaySize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderGroupHandleSize;
		public uint maxRecursionDepth;
		public uint maxShaderGroupStride;
		public uint shaderGroupBaseAlignment;
		public ulong maxGeometryCount;
		public ulong maxInstanceCount;
		public ulong maxTriangleCount;
		public uint maxDescriptorSetAccelerationStructures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkStridedBufferRegionKHR
	{
		public VkBuffer buffer;
		public ulong offset;
		public ulong stride;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTraceRaysIndirectCommandKHR
	{
		public uint width;
		public uint height;
		public uint depth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrmFormatModifierPropertiesListEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint drmFormatModifierCount;
		public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDrmFormatModifierPropertiesEXT
	{
		public ulong drmFormatModifier;
		public uint drmFormatModifierPlaneCount;
		public VkFormatFeatureFlagBits drmFormatModifierTilingFeatures;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong drmFormatModifier;
		public VkSharingMode sharingMode;
		public uint queueFamilyIndexCount;
		public uint* pQueueFamilyIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageDrmFormatModifierListCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint drmFormatModifierCount;
		public ulong* pDrmFormatModifiers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong drmFormatModifier;
		public uint drmFormatModifierPlaneCount;
		public VkSubresourceLayout* pPlaneLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageDrmFormatModifierPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong drmFormatModifier;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageStencilUsageCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageUsageFlagBits stencilUsage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentDensityMap;
		public VkBool32 fragmentDensityMapDynamic;
		public VkBool32 fragmentDensityMapNonSubsampledImages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkExtent2D minFragmentDensityTexelSize;
		public VkExtent2D maxFragmentDensityTexelSize;
		public VkBool32 fragmentDensityInvocations;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassFragmentDensityMapCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAttachmentReference fragmentDensityMapAttachment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 scalarBlockLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 supportsProtected;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 uniformBufferStandardLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 depthClipEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkBool32 depthClipEnable;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed ulong heapBudget[(int)Vulkan.VK_MAX_MEMORY_HEAPS];
		public fixed ulong heapUsage[(int)Vulkan.VK_MAX_MEMORY_HEAPS];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 memoryPriority;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryPriorityAllocateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public float priority;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 bufferDeviceAddress;
		public VkBool32 bufferDeviceAddressCaptureReplay;
		public VkBool32 bufferDeviceAddressMultiDevice;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 bufferDeviceAddress;
		public VkBool32 bufferDeviceAddressCaptureReplay;
		public VkBool32 bufferDeviceAddressMultiDevice;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferDeviceAddressInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferOpaqueCaptureAddressCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong opaqueCaptureAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkBufferDeviceAddressCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong deviceAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageViewType imageViewType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFilterCubicImageViewImageFormatPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 filterCubic;
		public VkBool32 filterCubicMinmax;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 imagelessFramebuffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferAttachmentsCreateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachmentImageInfoCount;
		public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferAttachmentImageInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageCreateFlagBits flags;
		public VkImageUsageFlagBits usage;
		public uint width;
		public uint height;
		public uint layerCount;
		public uint viewFormatCount;
		public VkFormat* pViewFormats;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassAttachmentBeginInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public uint attachmentCount;
		public VkImageView* pAttachments;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 textureCompressionASTC_HDR;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 cooperativeMatrix;
		public VkBool32 cooperativeMatrixRobustBufferAccess;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlagBits cooperativeMatrixSupportedStages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCooperativeMatrixPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint MSize;
		public uint NSize;
		public uint KSize;
		public VkComponentTypeNV AType;
		public VkComponentTypeNV BType;
		public VkComponentTypeNV CType;
		public VkComponentTypeNV DType;
		public VkScopeNV scope;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 ycbcrImageArrays;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewHandleInfoNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageView imageView;
		public VkDescriptorType descriptorType;
		public VkSampler sampler;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkImageViewAddressPropertiesNVX
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong deviceAddress;
		public ulong size;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPresentFrameTokenGGP
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr frameToken;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCreationFeedbackEXT
	{
		public VkPipelineCreationFeedbackFlagBitsEXT flags;
		public ulong duration;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCreationFeedbackCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCreationFeedbackEXT* pPipelineCreationFeedback;
		public uint pipelineStageCreationFeedbackCount;
		public VkPipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFullScreenExclusiveInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFullScreenExclusiveEXT fullScreenExclusive;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public IntPtr hmonitor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fullScreenExclusiveSupported;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePerformanceQueryFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 performanceCounterQueryPools;
		public VkBool32 performanceCounterMultipleQueryPools;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePerformanceQueryPropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 allowCommandBufferQueryCopies;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceCounterKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceCounterUnitKHR unit;
		public VkPerformanceCounterScopeKHR scope;
		public VkPerformanceCounterStorageKHR storage;
		public fixed byte uuid[(int)Vulkan.VK_UUID_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceCounterDescriptionKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceCounterDescriptionFlagBitsKHR flags;
		public fixed byte name[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte category[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryPoolPerformanceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint queueFamilyIndex;
		public uint counterIndexCount;
		public uint* pCounterIndices;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAcquireProfilingLockInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAcquireProfilingLockFlagBitsKHR flags;
		public ulong timeout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceQuerySubmitInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint counterPassIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkHeadlessSurfaceCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 coverageReductionMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCoverageReductionStateCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint flags;
		public VkCoverageReductionModeNV coverageReductionMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkFramebufferMixedSamplesCombinationNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkCoverageReductionModeNV coverageReductionMode;
		public VkSampleCountFlagBits rasterizationSamples;
		public VkSampleCountFlagBits depthStencilSamples;
		public VkSampleCountFlagBits colorSamples;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderIntegerFunctions2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceValueINTEL
	{
		public VkPerformanceValueTypeINTEL type;
		public VkPerformanceValueDataINTEL data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkInitializePerformanceApiInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public void* pUserData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkQueryPoolPerformanceQueryCreateInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceMarkerInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong marker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceStreamMarkerInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public uint marker;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceOverrideInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceOverrideTypeINTEL type;
		public VkBool32 enable;
		public ulong parameter;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPerformanceConfigurationAcquireInfoINTEL
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPerformanceConfigurationTypeINTEL type;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderClockFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSubgroupClock;
		public VkBool32 shaderDeviceClock;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 indexTypeUint8;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public uint shaderSMCount;
		public uint shaderWarpsPerSM;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderSMBuiltins;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 fragmentShaderSampleInterlock;
		public VkBool32 fragmentShaderPixelInterlock;
		public VkBool32 fragmentShaderShadingRateInterlock;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 separateDepthStencilLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentReferenceStencilLayout
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageLayout stencilLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAttachmentDescriptionStencilLayout
	{
		public VkStructureType sType;
		public void* pNext;
		public VkImageLayout stencilInitialLayout;
		public VkImageLayout stencilFinalLayout;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineExecutableInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipeline pipeline;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutablePropertiesKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkShaderStageFlagBits stages;
		public fixed byte name[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public uint subgroupSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutableInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipeline pipeline;
		public uint executableIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutableStatisticKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte name[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public VkPipelineExecutableStatisticFormatKHR format;
		public VkPipelineExecutableStatisticValueKHR value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte name[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte description[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public VkBool32 isText;
		public UIntPtr dataSize;
		public void* pData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 shaderDemoteToHelperInvocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 texelBufferAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong storageTexelBufferOffsetAlignmentBytes;
		public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
		public ulong uniformTexelBufferOffsetAlignmentBytes;
		public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 subgroupSizeControl;
		public VkBool32 computeFullSubgroups;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint minSubgroupSize;
		public uint maxSubgroupSize;
		public uint maxComputeWorkgroupSubgroups;
		public VkShaderStageFlagBits requiredSubgroupSizeStages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint requiredSubgroupSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong opaqueCaptureAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfo
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceMemory memory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLineRasterizationFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 rectangularLines;
		public VkBool32 bresenhamLines;
		public VkBool32 smoothLines;
		public VkBool32 stippledRectangularLines;
		public VkBool32 stippledBresenhamLines;
		public VkBool32 stippledSmoothLines;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceLineRasterizationPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public uint lineSubPixelPrecisionBits;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineRasterizationLineStateCreateInfoEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkLineRasterizationModeEXT lineRasterizationMode;
		public VkBool32 stippledLineEnable;
		public uint lineStippleFactor;
		public ushort lineStipplePattern;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 pipelineCreationCacheControl;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan11Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 storageBuffer16BitAccess;
		public VkBool32 uniformAndStorageBuffer16BitAccess;
		public VkBool32 storagePushConstant16;
		public VkBool32 storageInputOutput16;
		public VkBool32 multiview;
		public VkBool32 multiviewGeometryShader;
		public VkBool32 multiviewTessellationShader;
		public VkBool32 variablePointersStorageBuffer;
		public VkBool32 variablePointers;
		public VkBool32 protectedMemory;
		public VkBool32 samplerYcbcrConversion;
		public VkBool32 shaderDrawParameters;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan11Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte deviceUUID[(int)Vulkan.VK_UUID_SIZE];
		public fixed byte driverUUID[(int)Vulkan.VK_UUID_SIZE];
		public fixed byte deviceLUID[(int)Vulkan.VK_LUID_SIZE];
		public uint deviceNodeMask;
		public VkBool32 deviceLUIDValid;
		public uint subgroupSize;
		public VkShaderStageFlagBits subgroupSupportedStages;
		public VkSubgroupFeatureFlagBits subgroupSupportedOperations;
		public VkBool32 subgroupQuadOperationsInAllStages;
		public VkPointClippingBehavior pointClippingBehavior;
		public uint maxMultiviewViewCount;
		public uint maxMultiviewInstanceIndex;
		public VkBool32 protectedNoFault;
		public uint maxPerSetDescriptors;
		public ulong maxMemoryAllocationSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan12Features
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 samplerMirrorClampToEdge;
		public VkBool32 drawIndirectCount;
		public VkBool32 storageBuffer8BitAccess;
		public VkBool32 uniformAndStorageBuffer8BitAccess;
		public VkBool32 storagePushConstant8;
		public VkBool32 shaderBufferInt64Atomics;
		public VkBool32 shaderSharedInt64Atomics;
		public VkBool32 shaderFloat16;
		public VkBool32 shaderInt8;
		public VkBool32 descriptorIndexing;
		public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
		public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
		public VkBool32 shaderSampledImageArrayNonUniformIndexing;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageImageArrayNonUniformIndexing;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
		public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
		public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
		public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
		public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
		public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
		public VkBool32 descriptorBindingUpdateUnusedWhilePending;
		public VkBool32 descriptorBindingPartiallyBound;
		public VkBool32 descriptorBindingVariableDescriptorCount;
		public VkBool32 runtimeDescriptorArray;
		public VkBool32 samplerFilterMinmax;
		public VkBool32 scalarBlockLayout;
		public VkBool32 imagelessFramebuffer;
		public VkBool32 uniformBufferStandardLayout;
		public VkBool32 shaderSubgroupExtendedTypes;
		public VkBool32 separateDepthStencilLayouts;
		public VkBool32 hostQueryReset;
		public VkBool32 timelineSemaphore;
		public VkBool32 bufferDeviceAddress;
		public VkBool32 bufferDeviceAddressCaptureReplay;
		public VkBool32 bufferDeviceAddressMultiDevice;
		public VkBool32 vulkanMemoryModel;
		public VkBool32 vulkanMemoryModelDeviceScope;
		public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
		public VkBool32 shaderOutputViewportIndex;
		public VkBool32 shaderOutputLayer;
		public VkBool32 subgroupBroadcastDynamicId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceVulkan12Properties
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDriverId driverID;
		public fixed byte driverName[(int)Vulkan.VK_MAX_DRIVER_NAME_SIZE];
		public fixed byte driverInfo[(int)Vulkan.VK_MAX_DRIVER_INFO_SIZE];
		public VkConformanceVersion conformanceVersion;
		public VkShaderFloatControlsIndependence denormBehaviorIndependence;
		public VkShaderFloatControlsIndependence roundingModeIndependence;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
		public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
		public VkBool32 shaderDenormPreserveFloat16;
		public VkBool32 shaderDenormPreserveFloat32;
		public VkBool32 shaderDenormPreserveFloat64;
		public VkBool32 shaderDenormFlushToZeroFloat16;
		public VkBool32 shaderDenormFlushToZeroFloat32;
		public VkBool32 shaderDenormFlushToZeroFloat64;
		public VkBool32 shaderRoundingModeRTEFloat16;
		public VkBool32 shaderRoundingModeRTEFloat32;
		public VkBool32 shaderRoundingModeRTEFloat64;
		public VkBool32 shaderRoundingModeRTZFloat16;
		public VkBool32 shaderRoundingModeRTZFloat32;
		public VkBool32 shaderRoundingModeRTZFloat64;
		public uint maxUpdateAfterBindDescriptorsInAllPools;
		public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
		public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
		public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
		public VkBool32 robustBufferAccessUpdateAfterBind;
		public VkBool32 quadDivergentImplicitLod;
		public uint maxPerStageDescriptorUpdateAfterBindSamplers;
		public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
		public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
		public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
		public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
		public uint maxPerStageUpdateAfterBindResources;
		public uint maxDescriptorSetUpdateAfterBindSamplers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
		public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
		public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
		public uint maxDescriptorSetUpdateAfterBindSampledImages;
		public uint maxDescriptorSetUpdateAfterBindStorageImages;
		public uint maxDescriptorSetUpdateAfterBindInputAttachments;
		public VkResolveModeFlagBits supportedDepthResolveModes;
		public VkResolveModeFlagBits supportedStencilResolveModes;
		public VkBool32 independentResolveNone;
		public VkBool32 independentResolve;
		public VkBool32 filterMinmaxSingleComponentFormats;
		public VkBool32 filterMinmaxImageComponentMapping;
		public ulong maxTimelineSemaphoreValueDifference;
		public VkSampleCountFlagBits framebufferIntegerColorSampleCounts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineCompilerControlCreateInfoAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkPipelineCompilerControlFlagBitsAMD compilerControlFlags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 deviceCoherentMemory;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceToolPropertiesEXT
	{
		public VkStructureType sType;
		public void* pNext;
		public fixed byte name[(int)Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
		public fixed byte version[(int)Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
		public VkToolPurposeFlagBitsEXT purposes;
		public fixed byte description[(int)Vulkan.VK_MAX_DESCRIPTION_SIZE];
		public fixed byte layer[(int)Vulkan.VK_MAX_EXTENSION_NAME_SIZE];
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryTrianglesDataKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkFormat vertexFormat;
		public VkDeviceOrHostAddressConstKHR vertexData;
		public ulong vertexStride;
		public VkIndexType indexType;
		public VkDeviceOrHostAddressConstKHR indexData;
		public VkDeviceOrHostAddressConstKHR transformData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryAabbsDataKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceOrHostAddressConstKHR data;
		public ulong stride;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryInstancesDataKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 arrayOfPointers;
		public VkDeviceOrHostAddressConstKHR data;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureGeometryKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkGeometryTypeKHR geometryType;
		public VkAccelerationStructureGeometryDataKHR geometry;
		public VkGeometryFlagBitsKHR flags;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureTypeKHR type;
		public VkBuildAccelerationStructureFlagBitsKHR flags;
		public VkBool32 update;
		public VkAccelerationStructureKHR srcAccelerationStructure;
		public VkAccelerationStructureKHR dstAccelerationStructure;
		public VkBool32 geometryArrayOfPointers;
		public uint geometryCount;
		public VkAccelerationStructureGeometryKHR** ppGeometries;
		public VkDeviceOrHostAddressKHR scratchData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureBuildOffsetInfoKHR
	{
		public uint primitiveCount;
		public uint primitiveOffset;
		public uint firstVertex;
		public uint transformOffset;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureCreateGeometryTypeInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkGeometryTypeKHR geometryType;
		public uint maxPrimitiveCount;
		public VkIndexType indexType;
		public uint maxVertexCount;
		public VkFormat vertexFormat;
		public VkBool32 allowsTransforms;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public ulong compactedSize;
		public VkAccelerationStructureTypeKHR type;
		public VkBuildAccelerationStructureFlagBitsKHR flags;
		public uint maxGeometryCount;
		public VkAccelerationStructureCreateGeometryTypeInfoKHR* pGeometryInfos;
		public ulong deviceAddress;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAabbPositionsKHR
	{
		public float minX;
		public float minY;
		public float minZ;
		public float maxX;
		public float maxY;
		public float maxZ;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkTransformMatrixKHR
	{
		public float matrix_0;
		public float matrix_1;
		public float matrix_2;
		public float matrix_3;
		public float matrix_4;
		public float matrix_5;
		public float matrix_6;
		public float matrix_7;
		public float matrix_8;
		public float matrix_9;
		public float matrix_10;
		public float matrix_11;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureInstanceKHR
	{
		public VkTransformMatrixKHR transform;
		public uint instanceCustomIndex;
		public uint mask;
		public uint instanceShaderBindingTableRecordOffset;
		public VkGeometryInstanceFlagBitsKHR flags;
		public ulong accelerationStructureReference;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureDeviceAddressInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR accelerationStructure;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkAccelerationStructureVersionKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public byte* versionData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyAccelerationStructureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR src;
		public VkAccelerationStructureKHR dst;
		public VkCopyAccelerationStructureModeKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyAccelerationStructureToMemoryInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkAccelerationStructureKHR src;
		public VkDeviceOrHostAddressKHR dst;
		public VkCopyAccelerationStructureModeKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCopyMemoryToAccelerationStructureInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceOrHostAddressConstKHR src;
		public VkAccelerationStructureKHR dst;
		public VkCopyAccelerationStructureModeKHR mode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRayTracingPipelineInterfaceCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint maxPayloadSize;
		public uint maxAttributeSize;
		public uint maxCallableSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeferredOperationInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeferredOperationKHR operationHandle;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPipelineLibraryCreateInfoKHR
	{
		public VkStructureType sType;
		public void* pNext;
		public uint libraryCount;
		public VkPipeline* pLibraries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkRenderPassTransformBeginInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceTransformFlagBitsKHR transform;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
	{
		public VkStructureType sType;
		public void* pNext;
		public VkSurfaceTransformFlagBitsKHR transform;
		public VkRect2D renderArea;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkBool32 diagnosticsConfig;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct VkDeviceDiagnosticsConfigCreateInfoNV
	{
		public VkStructureType sType;
		public void* pNext;
		public VkDeviceDiagnosticsConfigFlagBitsNV flags;
	}

}

